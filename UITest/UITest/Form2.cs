using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UITest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void crownDockPanel1_Load(object sender, EventArgs e)
        {

        }

        private void dreamForm1_Enter(object sender, EventArgs e)
        {

        }

        private void crownButton1_Click(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                UITest.Settings1.Default.username = txtUsername.Text.Trim();
                UITest.Settings1.Default.password = txtPassword.Text.Trim();

            }
            else
            {
                UITest.Settings1.Default.username = String.Empty;
                UITest.Settings1.Default.password = String.Empty;
            }

            UITest.Settings1.Default.remember = chkRemember.Checked;
            UITest.Settings1.Default.Save();

            this.Hide();
            Form1 loader = new Form1(txtUsername.Text.Trim());
            loader.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUsername.Text = UITest.Settings1.Default.username;
            txtPassword.Text = UITest.Settings1.Default.password;
            chkRemember.Checked = UITest.Settings1.Default.remember;
        }
    }
}
