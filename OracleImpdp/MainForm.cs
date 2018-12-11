using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace OracleImpdp
{
    /// <summary>
    /// 导入程序
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ll_dump_file_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //弹出选择文件
            //如果设置了DUPMP文件夹，则默认
            if (tb_dpdump.Text.Length > 0)
            {
                if (Directory.Exists(tb_dpdump.Text))
                {
                    ofd_dump_file.InitialDirectory = tb_dpdump.Text;
                }
            }
            ofd_dump_file.ShowDialog();
        }

        private void ofd_dmp_file_FileOk(object sender, CancelEventArgs e)
        {
            tb_dumpfile.Text = ofd_dump_file.FileName;
            var names = ofd_dump_file.SafeFileName.Split('-');
            if (names.Length > 2)
            {
                tb_tablespace.Text = names[0];
                tb_schemas.Text = names[1];
            }
        }

        private void Impdp_click(object sender, EventArgs e)
        {
            var sysdba = tb_sysdba.Text.Trim();
            var example = tb_example.Text.Trim();
            var directory = tb_directory.Text.Trim();
            var tablespace = tb_tablespace.Text.Trim();
            var schemas = tb_schemas.Text.Trim();
            var dumpfile = tb_dumpfile.Text.Trim();//文件路径
            var to_tablespace = tb_to_tablespace.Text.Trim();
            var to_schemas = tb_to_schemas.Text.Trim();
            var def_pwd = tb_def_pwd.Text.Trim();
            var rarPath = tb_winrar.Text.Trim();
            var dpdump = tb_dpdump.Text.Trim();
            var dumpfileName = string.Empty;

            //如果是压缩文件，需要先解压到dpdump文件夹
            var file = new FileInfo(dumpfile);
            if (!file.Exists)
            {
                MessageBox.Show("文件不存在！");
                return;
            }
            if (!Directory.Exists(dpdump))
            {
                MessageBox.Show("DPDUMP 目录无效！");
                return;
            }
            var log = new StringBuilder();
            log.AppendLine("[" + DateTime.Now.ToString("yyyyMMdd HHmmss.fff") + "] IMPDP");
            dumpfileName = file.Name.TrimEnd(file.Extension.ToCharArray());
            var cmdList = new List<string>();
            if (file.Extension.Equals(".rar", StringComparison.OrdinalIgnoreCase))
            {
                //解压到dpdump文件夹(-o+ 文件存在则覆盖，默认遇到已存在的会弹出提示，如果用 -o- 则可能会提示没有要解压的文件)
                var rarCmd = string.Format("\"{0}\" X \"{1}\" \"{2}\" -o+", rarPath, dumpfile, dpdump);
                cmdList.Add(rarCmd);
                log.AppendLine("解压文件 到" + dpdump);
            }
            else
            {
                //如果不在dpdump文件夹，则移动到该文件夹
                if (file.Directory.FullName.Equals(dpdump, StringComparison.OrdinalIgnoreCase) == false)
                {
                    //移动文件
                    var moveCmd = string.Format("MOVE \"{0}\" \"{1}\"", dumpfile, dpdump);
                    cmdList.Add(moveCmd);
                    log.AppendLine("移动文件 到" + dpdump);
                }
            }
            //如果是备份文件，需要修改dumpfile值（检测是否在dpdump文件夹，如果不在则复制/移动）
            var impdpCmdBuilder = new StringBuilder("IMPDP");
            impdpCmdBuilder.AppendFormat(" {0}", sysdba);
            if (example.Length > 0)
            {
                impdpCmdBuilder.AppendFormat("@{0}", example);
            }
            impdpCmdBuilder.AppendFormat(" DIRECTORY={0}", directory);
            impdpCmdBuilder.AppendFormat(" DUMPFILE={0}.DMP", dumpfileName);
            impdpCmdBuilder.AppendFormat(" SCHEMAS={0}", schemas);
            if (to_tablespace.Length > 0)
            {
                if (!tablespace.Equals(to_tablespace, StringComparison.OrdinalIgnoreCase))
                {
                    impdpCmdBuilder.AppendFormat(" remap_tablespace={0}:{1}", tablespace, to_tablespace);
                }
            }
            if (to_schemas.Length > 0)
            {
                if (!schemas.Equals(to_schemas, StringComparison.OrdinalIgnoreCase))
                {
                    impdpCmdBuilder.AppendFormat(" remap_schema={0}:{1}", schemas, to_schemas);
                }
            }
            else
            {
                to_schemas = schemas;
            }
            var impdpCmd = impdpCmdBuilder.ToString();
            cmdList.Add(impdpCmd);
            log.AppendLine("导入数据库 " + impdpCmd);
            cmdList.Add("exit");
            if (MessageBox.Show(string.Join("\n", cmdList.ToArray()), "命令确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.Start();
                foreach (var item in cmdList)
                {
                    p.StandardInput.WriteLine(item);
                    Thread.Sleep(100);
                }
                p.WaitForExit();
                p.Close();
                //修改密码
                if (string.IsNullOrEmpty(def_pwd) == false)
                {
                    //修改用户默认密码
                    Process pp = new Process();
                    pp.StartInfo.FileName = "sqlplus.exe";
                    pp.StartInfo.UseShellExecute = false;
                    pp.StartInfo.RedirectStandardInput = true;
                    pp.Start();
                    if (example.Length > 0)
                    {
                        pp.StandardInput.WriteLine(string.Format("{0}@{1}", sysdba, example));
                    }
                    else
                    {
                        pp.StandardInput.WriteLine(sysdba);
                    }
                    pp.StandardInput.WriteLine(string.Format("alter user {0} identified by {1};", to_schemas, def_pwd));
                    pp.StandardInput.WriteLine("exit");
                    pp.WaitForExit();
                    pp.Close();
                    log.AppendLine("修改用户密码为 " + to_schemas + "/" + def_pwd);
                }
                //存入ini
                using (var sw = new StreamWriter(iniPath, false))
                {
                    sw.WriteLine("SYSDBA=" + sysdba);
                    sw.WriteLine("EXAMPLE=" + example);
                    sw.WriteLine("DIRECTORY=" + directory);
                    sw.WriteLine("TABLESPACE=" + tablespace);
                    sw.WriteLine("SCHEMAS=" + schemas);
                    sw.WriteLine("R-TABLESPACE=" + to_tablespace);
                    sw.WriteLine("R-SCHEMAS=" + to_schemas);
                    sw.WriteLine("DEF-PWD=" + def_pwd);
                    sw.WriteLine("WINRAR=" + rarPath);
                    sw.WriteLine("DPDUMP=" + dpdump);
                    sw.WriteLine("AUTOEXIT=" + cb_auto_exit.Checked);
                }
                //写日志
                using (var sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine(log);
                    sw.WriteLine("");
                }
                //完成后退出
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
            //还原配置项
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
                    if (dir.ContainsKey("R-TABLESPACE"))
                    {
                        tb_to_tablespace.Text = dir["R-TABLESPACE"];
                    }
                    if (dir.ContainsKey("R-SCHEMAS"))
                    {
                        tb_to_schemas.Text = dir["R-SCHEMAS"];
                    }
                    if (dir.ContainsKey("DEF-PWD"))
                    {
                        tb_def_pwd.Text = dir["DEF-PWD"];
                    }
                    if (dir.ContainsKey("WINRAR"))
                    {
                        tb_winrar.Text = dir["WINRAR"];
                    }
                    if (dir.ContainsKey("DPDUMP"))
                    {
                        tb_dpdump.Text = dir["DPDUMP"];
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
