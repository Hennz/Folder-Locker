using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using SvkLocker;
using System.Configuration;

namespace FolderLock
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
            lblVersion.Text = "Version : " + ConfigurationSettings.AppSettings["AppVersion"];
            txtPassword.Select();
        }

        private void btnOkConfirm_Click(object sender, EventArgs e)
        {
            string sKey = "12345678";
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            FileStream fsread = new FileStream("licence.dat", FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);

            string decryptData = new StreamReader(cryptostreamDecr).ReadToEnd();

            fsread.Flush();
            fsread.Close();

            if (decryptData == txtPassword.Text)
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Password.Try again!", "Wrong password", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void First_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
