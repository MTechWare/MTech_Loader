using System.Security.Cryptography.Xml;

namespace UITest
{
    public partial class Form1 : Form
    {
        string appname;
        private string username;

        public Form1(string loginName)
        {
            this.username = loginName;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dreamForm1_Enter(object sender, EventArgs e)
        {

        }

        private void crownDockPanel1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Download-FileInfo")
            {
                AppNameHere.Text = "Download-FileInfo";

                AppVer.Text = "1.0.0.0";
                AppVer.ForeColor = Color.Orange;

                acclevel.Text = "Beta Access";
                acclevel.ForeColor = Color.LightBlue;

                Statusapp.Text = "Online";
                Statusapp.ForeColor = Color.Green;

                appname = "app.exe";
            }
        }

        private void AppVer_Click(object sender, EventArgs e)
        {

        }
    }
}
