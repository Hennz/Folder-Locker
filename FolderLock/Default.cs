using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SvkLocker
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();           
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                        
            Application.Run(new Default());            
        }

        private void Default_Load(object sender, EventArgs e)
        {
            this.Show();            
            Thread.Sleep(3000);
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
            
        }              
    }
}
