using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using FolderLock;
using System.Configuration;

namespace SvkLocker
{
    public partial class Form1 : Form
    {
        #region memter variables
        string key;
        string filedata;
        #endregion

        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = "Version : " + ConfigurationSettings.AppSettings["AppVersion"];
            Check();
        }

        private string _password { get; set; }

        private string _confirmPassword { get; set; }

        public void Check()
        {
            string curDir = Directory.GetCurrentDirectory();
            FileInfo fi = new FileInfo(curDir + "\\licence.dat");

            if (fi.Exists)
            {
                /*---Security Key for Encryption or Decryption of file----*/
                string sKey = "12345678";

                try
                {
                    //FileInfo f1 = new FileInfo("licence.dat");
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                    DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

                    FileStream fsread = new FileStream("licence.dat", FileMode.Open, FileAccess.Read);
                    ICryptoTransform desdecrypt = DES.CreateDecryptor();
                    CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);

                    string decryptData = new StreamReader(cryptostreamDecr).ReadToEnd();

                    fsread.Flush();
                    fsread.Close();

                    if (decryptData.Length > 0)
                    {
                        First frm = new First();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password.Try again!", "Login", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {

            }
        }

        private void btnOkConfirm_click(object sender, EventArgs e)
        {
            //if (btnOkConfirm.Text == "OK")
            //{
            if (txtPassword.Text != string.Empty)
            {
                _password = txtPassword.Text;
                //txtPassword.Visible = false;
                //txtConfirm.Visible = true;
                //label1.Text = "Re-enter password";
                //btnOkConfirm.Text = "Confirm";
                // txtConfirm.Focus();
            }
            //}
            //else
            //{
            _confirmPassword = txtConfirm.Text;

            if (_password == _confirmPassword)
            {

                FileInfo f = new FileInfo("temp.dat");
                StreamWriter sw = f.CreateText();

                sw.Write(txtPassword.Text);
                sw.Close();

                //encrypt the file
                EncryptFile(@"temp.dat", @"licence.dat", "12345678");

                f.Attributes = FileAttributes.Hidden;
                FileInfo f2 = new FileInfo("licence.dat");
                f2.Attributes = FileAttributes.Hidden;

                MessageBox.Show("Password set successfully. Enter Password to open SvkLocker.", "licence", MessageBoxButtons.OK);
                First frm = new First();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Password did not match.Try again!", "Error", MessageBoxButtons.OK);
                txtPassword.Text = "";
                txtConfirm.Text = "";
                txtPassword.Focus();
                btnOkConfirm.Text = "OK";
                // txtPassword.Visible = true;
                //txtConfirm.Visible = false;
                label1.Text = "Enter Password";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //txtPassword.Text = "Enter password";
            //txtPassword.ForeColor = Color.Gray;
            //txtConfirm.Text = "Re-enter password";
            //txtConfirm.ForeColor = Color.Gray;
            lblStrength.Text = "";
        }


        public void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            try
            {
                FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);

                FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.OpenOrCreate, FileAccess.Write);
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = DES.CreateEncryptor();
                CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);

                byte[] bytearrayinput = new byte[fsInput.Length];
                fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Close();
                fsInput.Close();
                fsEncrypted.Close();
            }
            catch (Exception ex)
            { }
        }

        public void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            try
            {
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

                FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
                ICryptoTransform desdecrypt = DES.CreateDecryptor();
                CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
                string content = new StreamReader(cryptostreamDecr).ReadToEnd();

                StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
                fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
                fsDecrypted.Flush();
                fsDecrypted.Close();
            }
            catch (Exception ex)
            { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password")
            {
                lblPassword.Visible = false;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            int length = txtPassword.Text.Length;

            if (txtPassword.Text.Length == 0)
            {
                txtConfirm.ReadOnly = true;
            }
            else
            {
                txtConfirm.ReadOnly = false;
            }

            if (length <= 4 && length > 0)
            {
                lblStrength.Text = "Weak";
                lblStrength.ForeColor = Color.Red;
            };

            if (length > 4 && length <= 8)
            {
                lblStrength.Text = "Medium";
                lblStrength.ForeColor = Color.Orange;
            };

            if (length > 8)
            {
                lblStrength.Text = "Strong";
                lblStrength.ForeColor = Color.Green;
            };

            if (txtPassword.Text.Length == 0)
            {
                lblStrength.Text = "";
                //    lblPassword.Visible = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text == "Enter password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirm_click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Re-enter password")
            {
                txtConfirm.Text = "";
            }
        }

        private void txtConfirm_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtConfirm.Text.Length > 1)
            {
                txtConfirm.ForeColor = Color.Black;
            }

            //            if (txtConfirm.Text.Length == 0)
            //            {
            //                //txtConfirm.Text = "Re-enter password";                                
            ////                lblReEnterPassword.Visible = true;             
            //            }
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtConfirm.Text == "Re-enter password")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.Black;
            }

        }

        private void lblReEnterPassword_Click(object sender, EventArgs e)
        {
            lblReEnterPassword.Visible = false;
            txtConfirm.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            txtPassword.Focus();
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            lblReEnterPassword.Visible = false;
            txtConfirm.Focus();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            txtPassword.Focus();
        }

    }
}
