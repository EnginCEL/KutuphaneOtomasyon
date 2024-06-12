namespace KutuphaneOtomasyon.User
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            lblUyelik = new LinkLabel();
            label8 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            btnGiris = new Button();
            txtuser = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            label7 = new Label();
            yntcpassword = new TextBox();
            label5 = new Label();
            button1 = new Button();
            yntcusername = new TextBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 635);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lgnbg;
            pictureBox2.Location = new Point(-22, 306);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book_png_10;
            pictureBox1.Location = new Point(78, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Blinker", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(183, 487);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Login Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Blinker", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 439);
            label1.Name = "label1";
            label1.Size = new Size(245, 29);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyon";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(319, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(642, 554);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = SystemColors.ButtonHighlight;
            tabPage1.BackgroundImage = Properties.Resources.formbg;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(lblUyelik);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnGiris);
            tabPage1.Controls.Add(txtuser);
            tabPage1.Controls.Add(label3);
            tabPage1.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(634, 519);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanıcı Girişi";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(508, 7);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 12;
            button2.Text = "ÇIKIŞ X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblUyelik
            // 
            lblUyelik.AutoSize = true;
            lblUyelik.BackColor = Color.Transparent;
            lblUyelik.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lblUyelik.LinkColor = Color.RoyalBlue;
            lblUyelik.Location = new Point(249, 322);
            lblUyelik.Name = "lblUyelik";
            lblUyelik.Size = new Size(59, 23);
            lblUyelik.TabIndex = 11;
            lblUyelik.TabStop = true;
            lblUyelik.Text = "Üye Ol";
            lblUyelik.LinkClicked += lblUyelik_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Blinker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(347, 59);
            label8.Name = "label8";
            label8.Size = new Size(180, 29);
            label8.TabIndex = 10;
            label8.Text = "KULLANICI GİRİŞİ";
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(219, 241);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Şifrenizi Giriniz";
            txtPassword.Size = new Size(288, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "1234";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(120, 248);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 3;
            label4.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Teal;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.ForeColor = SystemColors.ButtonHighlight;
            btnGiris.Location = new Point(355, 308);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(152, 50);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtuser
            // 
            txtuser.Cursor = Cursors.IBeam;
            txtuser.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.Location = new Point(219, 175);
            txtuser.MaxLength = 150;
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "Kullanıcı Adını Giriniz";
            txtuser.Size = new Size(288, 27);
            txtuser.TabIndex = 0;
            txtuser.Text = "cansuplt@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(74, 182);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonHighlight;
            tabPage2.BackgroundImage = Properties.Resources.formbg;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(yntcpassword);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(yntcusername);
            tabPage2.Controls.Add(label6);
            tabPage2.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 31);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(634, 519);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Yönetici Girişi";
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(508, 7);
            button3.Name = "button3";
            button3.Size = new Size(108, 33);
            button3.TabIndex = 13;
            button3.Text = "ÇIKIŞ X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Blinker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(347, 59);
            label7.Name = "label7";
            label7.Size = new Size(170, 29);
            label7.TabIndex = 9;
            label7.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // yntcpassword
            // 
            yntcpassword.Cursor = Cursors.IBeam;
            yntcpassword.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yntcpassword.Location = new Point(219, 241);
            yntcpassword.MaxLength = 100;
            yntcpassword.Name = "yntcpassword";
            yntcpassword.PasswordChar = '*';
            yntcpassword.PlaceholderText = "Şifrenizi Giriniz";
            yntcpassword.Size = new Size(288, 27);
            yntcpassword.TabIndex = 4;
            yntcpassword.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(120, 248);
            label5.Name = "label5";
            label5.Size = new Size(43, 19);
            label5.TabIndex = 8;
            label5.Text = "Şifre:";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(355, 308);
            button1.Name = "button1";
            button1.Size = new Size(152, 50);
            button1.TabIndex = 5;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yntcusername
            // 
            yntcusername.Cursor = Cursors.IBeam;
            yntcusername.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yntcusername.Location = new Point(219, 175);
            yntcusername.MaxLength = 150;
            yntcusername.Name = "yntcusername";
            yntcusername.PlaceholderText = "Kullanıcı Adını Giriniz";
            yntcusername.Size = new Size(288, 27);
            yntcusername.TabIndex = 4;
            yntcusername.Text = "elif@gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(74, 181);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 5;
            label6.Text = "Kullanıcı Adı:";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 549);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Kullanıcı Girişi   | Yönetici Girişi";
            Load += loginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPassword;
        private Label label4;
        private Button btnGiris;
        private TextBox txtuser;
        private Label label3;
        private Label label8;
        private Label label7;
        private TextBox yntcpassword;
        private Label label5;
        private Button button1;
        private TextBox yntcusername;
        private Label label6;
        private LinkLabel lblUyelik;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}