namespace OracleImpdp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ofd_dump_file = new System.Windows.Forms.OpenFileDialog();
            this.ll_dump_file = new System.Windows.Forms.LinkLabel();
            this.tb_dumpfile = new System.Windows.Forms.TextBox();
            this.tb_to_tablespace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_to_schemas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_auto_exit = new System.Windows.Forms.CheckBox();
            this.tb_tablespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_impdp = new System.Windows.Forms.Button();
            this.tb_example = new System.Windows.Forms.TextBox();
            this.tb_schemas = new System.Windows.Forms.TextBox();
            this.tb_winrar = new System.Windows.Forms.TextBox();
            this.tb_dpdump = new System.Windows.Forms.TextBox();
            this.tb_directory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sysdba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_def_pwd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofd_dump_file
            // 
            this.ofd_dump_file.Filter = "rar|*.rar|dump|*.dmp";
            this.ofd_dump_file.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_dmp_file_FileOk);
            // 
            // ll_dump_file
            // 
            this.ll_dump_file.AutoSize = true;
            this.ll_dump_file.Location = new System.Drawing.Point(18, 98);
            this.ll_dump_file.Name = "ll_dump_file";
            this.ll_dump_file.Size = new System.Drawing.Size(59, 12);
            this.ll_dump_file.TabIndex = 147;
            this.ll_dump_file.TabStop = true;
            this.ll_dump_file.Text = "DUMP.FILE";
            this.ll_dump_file.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_dump_file_LinkClicked);
            // 
            // tb_dumpfile
            // 
            this.tb_dumpfile.Location = new System.Drawing.Point(83, 93);
            this.tb_dumpfile.Name = "tb_dumpfile";
            this.tb_dumpfile.ReadOnly = true;
            this.tb_dumpfile.Size = new System.Drawing.Size(239, 21);
            this.tb_dumpfile.TabIndex = 4;
            // 
            // tb_to_tablespace
            // 
            this.tb_to_tablespace.Location = new System.Drawing.Point(83, 174);
            this.tb_to_tablespace.Name = "tb_to_tablespace";
            this.tb_to_tablespace.Size = new System.Drawing.Size(239, 21);
            this.tb_to_tablespace.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 142;
            this.label8.Text = "R-TABLESPACE";
            // 
            // tb_to_schemas
            // 
            this.tb_to_schemas.Location = new System.Drawing.Point(83, 201);
            this.tb_to_schemas.Name = "tb_to_schemas";
            this.tb_to_schemas.Size = new System.Drawing.Size(239, 21);
            this.tb_to_schemas.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 144;
            this.label9.Text = "R-SCHEMAS";
            // 
            // cb_auto_exit
            // 
            this.cb_auto_exit.AutoSize = true;
            this.cb_auto_exit.Checked = true;
            this.cb_auto_exit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_auto_exit.Location = new System.Drawing.Point(83, 314);
            this.cb_auto_exit.Name = "cb_auto_exit";
            this.cb_auto_exit.Size = new System.Drawing.Size(84, 16);
            this.cb_auto_exit.TabIndex = 12;
            this.cb_auto_exit.Text = "完成后退出";
            this.cb_auto_exit.UseVisualStyleBackColor = true;
            // 
            // tb_tablespace
            // 
            this.tb_tablespace.Location = new System.Drawing.Point(83, 120);
            this.tb_tablespace.Name = "tb_tablespace";
            this.tb_tablespace.Size = new System.Drawing.Size(239, 21);
            this.tb_tablespace.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 132;
            this.label7.Text = "TABLESPACE";
            // 
            // btn_impdp
            // 
            this.btn_impdp.Location = new System.Drawing.Point(247, 310);
            this.btn_impdp.Name = "btn_impdp";
            this.btn_impdp.Size = new System.Drawing.Size(75, 23);
            this.btn_impdp.TabIndex = 13;
            this.btn_impdp.Text = "Impdp";
            this.btn_impdp.UseVisualStyleBackColor = true;
            this.btn_impdp.Click += new System.EventHandler(this.Impdp_click);
            // 
            // tb_example
            // 
            this.tb_example.Location = new System.Drawing.Point(83, 39);
            this.tb_example.Name = "tb_example";
            this.tb_example.Size = new System.Drawing.Size(239, 21);
            this.tb_example.TabIndex = 2;
            this.tb_example.Text = "ORCL";
            // 
            // tb_schemas
            // 
            this.tb_schemas.Location = new System.Drawing.Point(83, 147);
            this.tb_schemas.Name = "tb_schemas";
            this.tb_schemas.Size = new System.Drawing.Size(239, 21);
            this.tb_schemas.TabIndex = 6;
            // 
            // tb_winrar
            // 
            this.tb_winrar.Location = new System.Drawing.Point(83, 255);
            this.tb_winrar.Name = "tb_winrar";
            this.tb_winrar.Size = new System.Drawing.Size(239, 21);
            this.tb_winrar.TabIndex = 10;
            this.tb_winrar.Text = "WINRAR";
            // 
            // tb_dpdump
            // 
            this.tb_dpdump.Location = new System.Drawing.Point(83, 282);
            this.tb_dpdump.Name = "tb_dpdump";
            this.tb_dpdump.Size = new System.Drawing.Size(239, 21);
            this.tb_dpdump.TabIndex = 11;
            // 
            // tb_directory
            // 
            this.tb_directory.Location = new System.Drawing.Point(83, 66);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(239, 21);
            this.tb_directory.TabIndex = 3;
            this.tb_directory.Text = "data_pump_dir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 128;
            this.label6.Text = "EXAMPLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 136;
            this.label4.Text = "WINRAR";
            // 
            // tb_sysdba
            // 
            this.tb_sysdba.Location = new System.Drawing.Point(83, 12);
            this.tb_sysdba.Name = "tb_sysdba";
            this.tb_sysdba.Size = new System.Drawing.Size(239, 21);
            this.tb_sysdba.TabIndex = 1;
            this.tb_sysdba.Text = "system/******";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 138;
            this.label2.Text = "DPDUMP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 134;
            this.label5.Text = "SCHEMAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 130;
            this.label3.Text = "DIRECTORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 126;
            this.label1.Text = "SYSDBA";
            // 
            // tb_def_pwd
            // 
            this.tb_def_pwd.Location = new System.Drawing.Point(83, 228);
            this.tb_def_pwd.Name = "tb_def_pwd";
            this.tb_def_pwd.Size = new System.Drawing.Size(239, 21);
            this.tb_def_pwd.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 149;
            this.label10.Text = "DEF-PWD";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.tb_def_pwd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ll_dump_file);
            this.Controls.Add(this.tb_dumpfile);
            this.Controls.Add(this.tb_to_tablespace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_to_schemas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_auto_exit);
            this.Controls.Add(this.tb_tablespace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_impdp);
            this.Controls.Add(this.tb_example);
            this.Controls.Add(this.tb_schemas);
            this.Controls.Add(this.tb_winrar);
            this.Controls.Add(this.tb_dpdump);
            this.Controls.Add(this.tb_directory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sysdba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Impdp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd_dump_file;
        private System.Windows.Forms.LinkLabel ll_dump_file;
        private System.Windows.Forms.TextBox tb_dumpfile;
        private System.Windows.Forms.TextBox tb_to_tablespace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_to_schemas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_auto_exit;
        private System.Windows.Forms.TextBox tb_tablespace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_impdp;
        private System.Windows.Forms.TextBox tb_example;
        private System.Windows.Forms.TextBox tb_schemas;
        private System.Windows.Forms.TextBox tb_winrar;
        private System.Windows.Forms.TextBox tb_dpdump;
        private System.Windows.Forms.TextBox tb_directory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sysdba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_def_pwd;
        private System.Windows.Forms.Label label10;
    }
}

