using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace SvkLocker
{
    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);
                
        private void btnStandBy_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }

        public Form2()
        {
            InitializeComponent();
        }

        public string  url{ get; set; }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath.LastIndexOf(".{") == -1)
                {
                    btnLock.Visible = true;
                    btnUnlock.Visible = false;
                    url = folderBrowserDialog1.SelectedPath;
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    btnUnlock.Visible = true;
                    btnLock.Visible = false;
                    url = folderBrowserDialog1.SelectedPath; ;
                    textBox1.Text = folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf("."));
                }
            }
        }

        private void btnLockPc_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(url);
            d.MoveTo(url + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
            url = url + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            //DirectoryInfo d1 = new DirectoryInfo(url);            
            //d1.Attributes = FileAttributes.System;            
            btnUnlock.Visible = true;
            btnLock.Visible = false;
            MessageBox.Show("Folder locked successfully.", "Lock", MessageBoxButtons.OK);     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(url);
            d.MoveTo(url.Substring(0, url.IndexOf(".")));
            url = url.Substring(0, url.IndexOf("."));
            btnUnlock.Visible = false;
            btnLock.Visible = true;
            MessageBox.Show("Folder unlocked.", "Unlock", MessageBoxButtons.OK);
        }

        private void btnUnlock_MouseHover(object sender, EventArgs e)
        {
            titleUnclock.Visible = true;
        }

        private void btnUnlock_MouseLeave(object sender, EventArgs e)
        {
            titleUnclock.Visible = false;
        }

        private void btnLock_MouseHover(object sender, EventArgs e)
        {
            titleLock.Visible = true;
        }

        private void btnLock_MouseLeave(object sender, EventArgs e)
        {
            titleLock.Visible = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
