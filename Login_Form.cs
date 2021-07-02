using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvetPerspectiva
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form1 f = new Form1();
            f.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
