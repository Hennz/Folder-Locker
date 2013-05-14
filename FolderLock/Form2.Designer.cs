namespace SvkLocker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnlock = new System.Windows.Forms.PictureBox();
            this.titleUnclock = new System.Windows.Forms.Label();
            this.titleLock = new System.Windows.Forms.Label();
            this.btnStandBy = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnLockPc = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnlock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(540, 95);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(48, 20);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT FOLDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Developed by : Deepak Arora";
            // 
            // btnLock
            // 
            this.btnLock.Image = ((System.Drawing.Image)(resources.GetObject("btnLock.Image")));
            this.btnLock.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLock.InitialImage")));
            this.btnLock.Location = new System.Drawing.Point(135, 141);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(53, 51);
            this.btnLock.TabIndex = 10;
            this.btnLock.TabStop = false;
            this.btnLock.Visible = false;
            this.btnLock.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnLock.MouseLeave += new System.EventHandler(this.btnLock_MouseLeave);
            this.btnLock.MouseHover += new System.EventHandler(this.btnLock_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select the folder you want to lock or unlock.";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlock.Image")));
            this.btnUnlock.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUnlock.InitialImage")));
            this.btnUnlock.Location = new System.Drawing.Point(219, 141);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(54, 51);
            this.btnUnlock.TabIndex = 12;
            this.btnUnlock.TabStop = false;
            this.btnUnlock.Visible = false;
            this.btnUnlock.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnUnlock.MouseLeave += new System.EventHandler(this.btnUnlock_MouseLeave);
            this.btnUnlock.MouseHover += new System.EventHandler(this.btnUnlock_MouseHover);
            // 
            // titleUnclock
            // 
            this.titleUnclock.AutoSize = true;
            this.titleUnclock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.titleUnclock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleUnclock.Location = new System.Drawing.Point(238, 127);
            this.titleUnclock.Name = "titleUnclock";
            this.titleUnclock.Size = new System.Drawing.Size(68, 13);
            this.titleUnclock.TabIndex = 13;
            this.titleUnclock.Text = "Unlock File";
            this.titleUnclock.Visible = false;
            // 
            // titleLock
            // 
            this.titleLock.AutoSize = true;
            this.titleLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.titleLock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLock.Location = new System.Drawing.Point(164, 127);
            this.titleLock.Name = "titleLock";
            this.titleLock.Size = new System.Drawing.Size(56, 13);
            this.titleLock.TabIndex = 14;
            this.titleLock.Text = "Lock File";
            this.titleLock.Visible = false;
            // 
            // btnStandBy
            // 
            this.btnStandBy.Location = new System.Drawing.Point(112, 22);
            this.btnStandBy.Name = "btnStandBy";
            this.btnStandBy.Size = new System.Drawing.Size(75, 23);
            this.btnStandBy.TabIndex = 18;
            this.btnStandBy.Text = "Stand By";
            this.btnStandBy.UseVisualStyleBackColor = true;
            this.btnStandBy.Click += new System.EventHandler(this.btnStandBy_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.Location = new System.Drawing.Point(212, 22);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(84, 23);
            this.btnHibernate.TabIndex = 17;
            this.btnHibernate.Text = "Hibernate";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnLockPc
            // 
            this.btnLockPc.Location = new System.Drawing.Point(12, 22);
            this.btnLockPc.Name = "btnLockPc";
            this.btnLockPc.Size = new System.Drawing.Size(75, 23);
            this.btnLockPc.TabIndex = 16;
            this.btnLockPc.Text = "Lock PC";
            this.btnLockPc.UseVisualStyleBackColor = true;
            this.btnLockPc.Click += new System.EventHandler(this.btnLockPc_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(312, 22);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(75, 23);
            this.btnLogOff.TabIndex = 15;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnLogOff);
            this.panel1.Controls.Add(this.btnStandBy);
            this.panel1.Controls.Add(this.btnLockPc);
            this.panel1.Controls.Add(this.btnHibernate);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 55);
            this.panel1.TabIndex = 19;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(412, 22);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 23);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Verdana", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(5, 188);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(71, 12);
            this.lblVersion.TabIndex = 20;
            this.lblVersion.Text = "Version : 0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 6.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Change password is available only in paid version. Get your paid copy contact ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(409, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "darora@85@live.com";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLock);
            this.Controls.Add(this.titleUnclock);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SvkLocker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btnLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnlock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnLock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnUnlock;
        private System.Windows.Forms.Label titleUnclock;
        private System.Windows.Forms.Label titleLock;
        private System.Windows.Forms.Button btnStandBy;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnLockPc;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}