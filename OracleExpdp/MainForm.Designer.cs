namespace OracleExpdp
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
            this.tb_tablespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_expdp = new System.Windows.Forms.Button();
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
            this.cb_package = new System.Windows.Forms.CheckBox();
            this.cb_auto_exit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_tablespace
            // 
            this.tb_tablespace.Location = new System.Drawing.Point(83, 95);
            this.tb_tablespace.Name = "tb_tablespace";
            this.tb_tablespace.Size = new System.Drawing.Size(239, 21);
            this.tb_tablespace.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "TABLESPACE";
            // 
            // btn_expdp
            // 
            this.btn_expdp.Location = new System.Drawing.Point(247, 203);
            this.btn_expdp.Name = "btn_expdp";
            this.btn_expdp.Size = new System.Drawing.Size(75, 23);
            this.btn_expdp.TabIndex = 99;
            this.btn_expdp.Text = "Expdp";
            this.btn_expdp.UseVisualStyleBackColor = true;
            this.btn_expdp.Click += new System.EventHandler(this.expdp_Click);
            // 
            // tb_example
            // 
            this.tb_example.Location = new System.Drawing.Point(83, 41);
            this.tb_example.Name = "tb_example";
            this.tb_example.Size = new System.Drawing.Size(239, 21);
            this.tb_example.TabIndex = 3;
            this.tb_example.Text = "ORCL";
            // 
            // tb_schemas
            // 
            this.tb_schemas.Location = new System.Drawing.Point(83, 122);
            this.tb_schemas.Name = "tb_schemas";
            this.tb_schemas.Size = new System.Drawing.Size(239, 21);
            this.tb_schemas.TabIndex = 9;
            // 
            // tb_winrar
            // 
            this.tb_winrar.Location = new System.Drawing.Point(83, 149);
            this.tb_winrar.Name = "tb_winrar";
            this.tb_winrar.Size = new System.Drawing.Size(239, 21);
            this.tb_winrar.TabIndex = 11;
            this.tb_winrar.Text = "WINRAR";
            // 
            // tb_dpdump
            // 
            this.tb_dpdump.Location = new System.Drawing.Point(83, 176);
            this.tb_dpdump.Name = "tb_dpdump";
            this.tb_dpdump.Size = new System.Drawing.Size(239, 21);
            this.tb_dpdump.TabIndex = 13;
            // 
            // tb_directory
            // 
            this.tb_directory.Location = new System.Drawing.Point(83, 68);
            this.tb_directory.Name = "tb_directory";
            this.tb_directory.Size = new System.Drawing.Size(239, 21);
            this.tb_directory.TabIndex = 5;
            this.tb_directory.Text = "data_pump_dir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "EXAMPLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "WINRAR";
            // 
            // tb_sysdba
            // 
            this.tb_sysdba.Location = new System.Drawing.Point(83, 14);
            this.tb_sysdba.Name = "tb_sysdba";
            this.tb_sysdba.Size = new System.Drawing.Size(239, 21);
            this.tb_sysdba.TabIndex = 1;
            this.tb_sysdba.Text = "system/******";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "DPDUMP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "SCHEMAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECTORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SYSDBA";
            // 
            // cb_package
            // 
            this.cb_package.AutoSize = true;
            this.cb_package.Checked = true;
            this.cb_package.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_package.Location = new System.Drawing.Point(29, 207);
            this.cb_package.Name = "cb_package";
            this.cb_package.Size = new System.Drawing.Size(48, 16);
            this.cb_package.TabIndex = 100;
            this.cb_package.Text = "打包";
            this.cb_package.UseVisualStyleBackColor = true;
            // 
            // cb_auto_exit
            // 
            this.cb_auto_exit.AutoSize = true;
            this.cb_auto_exit.Checked = true;
            this.cb_auto_exit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_auto_exit.Location = new System.Drawing.Point(83, 207);
            this.cb_auto_exit.Name = "cb_auto_exit";
            this.cb_auto_exit.Size = new System.Drawing.Size(84, 16);
            this.cb_auto_exit.TabIndex = 101;
            this.cb_auto_exit.Text = "完成后退出";
            this.cb_auto_exit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.cb_auto_exit);
            this.Controls.Add(this.cb_package);
            this.Controls.Add(this.tb_tablespace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_expdp);
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
            this.Text = "Oracle Expdp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tablespace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_expdp;
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
        private System.Windows.Forms.CheckBox cb_package;
        private System.Windows.Forms.CheckBox cb_auto_exit;
    }
}

