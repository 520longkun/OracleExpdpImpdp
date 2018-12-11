using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OracleExpdp
{
    /// <summary>
    /// 导出程序
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void expdp_Click(object sender, EventArgs e)
        {
            var sysdba = tb_sysdba.Text.Trim();
            var example = tb_example.Text.Trim();
            var schemas = tb_schemas.Text.Trim();
            var tablespace = tb_tablespace.Text.Trim();
            var directory = tb_directory.Text.Trim();
            if (string.IsNullOrEmpty(schemas))
            {
                MessageBox.Show("schemas 不能为空！");
                return;
            }
            //即将产生的备份文件名（不含后缀）
            var dumpfile = string.Format("{0}-{1}-{2}", tablespace, schemas, DateTime.Now.ToString("yyyyMMdd")).ToUpper();

            var rarPath = tb_winrar.Text.Trim();
            var dpdump = tb_dpdump.Text.Trim();

            var expdpCmd = string.Format("EXPDP {0}@{1} DIRECTORY={2} DUMPFILE={3}.DMP SCHEMAS={4}",
                            sysdba, example, directory, dumpfile, schemas);
            var rarCmd = string.Empty;
            if (MessageBox.Show(expdpCmd, "命令确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //执行日志
                var log = new StringBuilder();
                log.AppendLine("[" + DateTime.Now.ToString("yyyyMMdd HHmmss.fff") + "] EXPDP");
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                //执行导出
                log.AppendLine(">CMD:" + expdpCmd);
                p.StandardInput.WriteLine(expdpCmd);
                var selectFile = string.Format("{0}\\{1}.DMP", dpdump, dumpfile);
                log.AppendLine(">>已导出到：" + selectFile);
                //执行打包
                if (cb_package.Checked && rarPath.Length > 0 && dpdump.Length > 0)
                {
                    //打包(-ep忽略文件路径，-df压缩后删除文件)
                    rarCmd = string.Format("\"{0}\" a -ep -df \"{1}\\{2}\" \"{1}\\{2}.DMP\"",
                       rarPath, dpdump, dumpfile);
                    selectFile = string.Format("{0}\\{1}.rar", dpdump, dumpfile);
                }
                if (!string.IsNullOrEmpty(rarCmd))
                {
                    log.AppendLine(">CMD:" + rarCmd);
                    p.StandardInput.WriteLine(rarCmd);
                    log.AppendLine(">>已打包到：" + selectFile);
                }
                //退出cmd
                p.StandardInput.WriteLine("exit");
                p.WaitForExit();
                p.Close();
                //存入ini
                using (var sw = new StreamWriter(iniPath, false))
                {
                    sw.WriteLine("SYSDBA=" + sysdba);
                    sw.WriteLine("EXAMPLE=" + example);
                    sw.WriteLine("DIRECTORY=" + directory);
                    sw.WriteLine("TABLESPACE=" + tablespace);
                    sw.WriteLine("SCHEMAS=" + schemas);
                    sw.WriteLine("WINRAR=" + rarPath);
                    sw.WriteLine("DPDUMP=" + dpdump);
                    sw.WriteLine("PACKAGE=" + cb_package.Checked);
                    sw.WriteLine("AUTOEXIT=" + cb_auto_exit.Checked);
                }
                //写日志
                using (var sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine(log);
                    sw.WriteLine("");
                }
                //在window中打开文件夹并定位到该文件(没压缩就选中DMP)
                Process.Start("Explorer", string.Format("/select,\"{0}\"", selectFile));
                if (cb_auto_exit.Checked)
                {
                    this.Close();
                }
            }
        }
        string iniPath = string.Format("{0}\\{1}.ini", Application.StartupPath, Application.ProductName);
        string logPath = string.Format("{0}\\{1}.log", Application.StartupPath, Application.ProductName);
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(iniPath))
            {
                var dir = new Dictionary<string, string>();
                //加载配置文件
                using (var sr = new StreamReader(iniPath))
                {
                    var l = sr.ReadLine();
                    while (l != null)
                    {
                        var s = l.Split('=');
                        dir[s[0]] = s[1];
                        l = sr.ReadLine();
                    }
                }
                if (dir.Count > 0)
                {
                    if (dir.ContainsKey("SYSDBA"))
                    {
                        tb_sysdba.Text = dir["SYSDBA"];
                    }
                    if (dir.ContainsKey("EXAMPLE"))
                    {
                        tb_example.Text = dir["EXAMPLE"];
                    }
                    if (dir.ContainsKey("DIRECTORY"))
                    {
                        tb_directory.Text = dir["DIRECTORY"];
                    }
                    if (dir.ContainsKey("TABLESPACE"))
                    {
                        tb_tablespace.Text = dir["TABLESPACE"];
                    }
                    if (dir.ContainsKey("SCHEMAS"))
                    {
                        tb_schemas.Text = dir["SCHEMAS"];
                    }
                    if (dir.ContainsKey("WINRAR"))
                    {
                        tb_winrar.Text = dir["WINRAR"];
                    }
                    if (dir.ContainsKey("DPDUMP"))
                    {
                        tb_dpdump.Text = dir["DPDUMP"];
                    }
                    if (dir.ContainsKey("PACKAGE"))
                    {
                        cb_package.Checked = dir["PACKAGE"] == "True";
                    }
                    if (dir.ContainsKey("AUTOEXIT"))
                    {
                        cb_auto_exit.Checked = dir["AUTOEXIT"] == "True";
                    }
                }
            }
        }
    }
}
