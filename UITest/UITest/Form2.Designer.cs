namespace UITest
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
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            chkRemember = new ReaLTaiizor.Controls.ForeverCheckBox();
            txtPassword = new ReaLTaiizor.Controls.CrownTextBox();
            txtUsername = new ReaLTaiizor.Controls.CrownTextBox();
            pictureBox1 = new PictureBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            dreamForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.BackColor = Color.FromArgb(244, 241, 243);
            dreamForm1.ColorA = Color.FromArgb(255, 128, 0);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(crownLabel2);
            dreamForm1.Controls.Add(crownLabel1);
            dreamForm1.Controls.Add(crownButton1);
            dreamForm1.Controls.Add(chkRemember);
            dreamForm1.Controls.Add(txtPassword);
            dreamForm1.Controls.Add(txtUsername);
            dreamForm1.Controls.Add(pictureBox1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.MinimumSize = new Size(261, 65);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(375, 249);
            dreamForm1.TabIndex = 1;
            dreamForm1.TabStop = false;
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 50;
            dreamForm1.Enter += dreamForm1_Enter;
            // 
            // crownButton1
            // 
            crownButton1.ButtonStyle = ReaLTaiizor.Enum.Crown.ButtonStyle.Flat;
            crownButton1.Location = new Point(29, 211);
            crownButton1.Name = "crownButton1";
            crownButton1.Padding = new Padding(5);
            crownButton1.Size = new Size(317, 23);
            crownButton1.TabIndex = 5;
            crownButton1.Text = "Login";
            crownButton1.Click += crownButton1_Click;
            // 
            // chkRemember
            // 
            chkRemember.BackColor = Color.FromArgb(41, 41, 41);
            chkRemember.BaseColor = Color.FromArgb(45, 47, 49);
            chkRemember.BorderColor = Color.FromArgb(255, 128, 0);
            chkRemember.Checked = false;
            chkRemember.Font = new Font("Segoe UI", 10F);
            chkRemember.ForeColor = Color.FromArgb(243, 243, 243);
            chkRemember.Location = new Point(29, 178);
            chkRemember.Name = "chkRemember";
            chkRemember.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            chkRemember.Size = new Size(130, 22);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Rememver Me";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(69, 73, 74);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(220, 220, 220);
            txtPassword.Location = new Point(29, 135);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(317, 32);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(69, 73, 74);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(220, 220, 220);
            txtUsername.Location = new Point(29, 77);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(317, 32);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.MTechLogin1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 44);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.FromArgb(41, 41, 41);
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(29, 59);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(63, 15);
            crownLabel1.TabIndex = 6;
            crownLabel1.Text = "Username:";
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.BackColor = Color.FromArgb(41, 41, 41);
            crownLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel2.Location = new Point(29, 117);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(60, 15);
            crownLabel2.TabIndex = 7;
            crownLabel2.Text = "Password:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 249);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            dreamForm1.ResumeLayout(false);
            dreamForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CrownTextBox txtPassword;
        private ReaLTaiizor.Controls.CrownTextBox txtUsername;
        private ReaLTaiizor.Controls.ForeverCheckBox chkRemember;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
    }
}