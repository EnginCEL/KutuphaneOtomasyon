namespace KutuphaneOtomasyon.Login
{
    partial class frmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanici));
            tabControl1 = new TabControl();
            s = new TabPage();
            profilePhoto = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            txtcinsiyet = new TextBox();
            lblcinsiyet = new Label();
            txtemail = new TextBox();
            lblmail = new Label();
            txtGsm = new TextBox();
            lblgsm = new Label();
            txttckn = new TextBox();
            lblTckn = new Label();
            txtSoyad = new TextBox();
            lblsoyad = new Label();
            txtAd = new TextBox();
            lblAd = new Label();
            taboduncKitap = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpIadeTarihi = new DateTimePicker();
            dtpAlisTarihi = new DateTimePicker();
            btnOduncKaydet = new Button();
            label3 = new Label();
            ktpListCombo = new ComboBox();
            tabKitapIade = new TabPage();
            label8 = new Label();
            button2 = new Button();
            cmbKitapIadeList = new ComboBox();
            label7 = new Label();
            tabOkunanKitaplar = new TabPage();
            button11 = new Button();
            txtOkunanKitapAra = new TextBox();
            label2 = new Label();
            userOkunanKitaplarList = new ListView();
            tabControl1.SuspendLayout();
            s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).BeginInit();
            taboduncKitap.SuspendLayout();
            tabKitapIade.SuspendLayout();
            tabOkunanKitaplar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(s);
            tabControl1.Controls.Add(taboduncKitap);
            tabControl1.Controls.Add(tabKitapIade);
            tabControl1.Controls.Add(tabOkunanKitaplar);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 555);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // s
            // 
            s.BackColor = SystemColors.ButtonHighlight;
            s.Controls.Add(profilePhoto);
            s.Controls.Add(button1);
            s.Controls.Add(label1);
            s.Controls.Add(txtcinsiyet);
            s.Controls.Add(lblcinsiyet);
            s.Controls.Add(txtemail);
            s.Controls.Add(lblmail);
            s.Controls.Add(txtGsm);
            s.Controls.Add(lblgsm);
            s.Controls.Add(txttckn);
            s.Controls.Add(lblTckn);
            s.Controls.Add(txtSoyad);
            s.Controls.Add(lblsoyad);
            s.Controls.Add(txtAd);
            s.Controls.Add(lblAd);
            s.Location = new Point(4, 31);
            s.Name = "s";
            s.Padding = new Padding(3);
            s.Size = new Size(950, 520);
            s.TabIndex = 0;
            s.Text = "Profil";
            s.ToolTipText = "Profil";
            // 
            // profilePhoto
            // 
            profilePhoto.Image = Properties.Resources.ppdefault;
            profilePhoto.Location = new Point(785, 101);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.Size = new Size(132, 149);
            profilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            profilePhoto.TabIndex = 14;
            profilePhoto.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(827, 6);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 13;
            button1.Text = "ÇIKIŞ X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Blinker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(358, 57);
            label1.Name = "label1";
            label1.Size = new Size(201, 29);
            label1.TabIndex = 12;
            label1.Text = "KULLANICI PROFİLİ";
            // 
            // txtcinsiyet
            // 
            txtcinsiyet.Location = new Point(358, 361);
            txtcinsiyet.Name = "txtcinsiyet";
            txtcinsiyet.Size = new Size(241, 27);
            txtcinsiyet.TabIndex = 11;
            // 
            // lblcinsiyet
            // 
            lblcinsiyet.AutoSize = true;
            lblcinsiyet.ForeColor = Color.DarkSlateGray;
            lblcinsiyet.Location = new Point(191, 364);
            lblcinsiyet.Name = "lblcinsiyet";
            lblcinsiyet.Size = new Size(64, 19);
            lblcinsiyet.TabIndex = 10;
            lblcinsiyet.Text = "Cinsiyet:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(358, 317);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(241, 27);
            txtemail.TabIndex = 9;
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.ForeColor = Color.DarkSlateGray;
            lblmail.Location = new Point(191, 320);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(53, 19);
            lblmail.TabIndex = 8;
            lblmail.Text = "E-Mail:";
            // 
            // txtGsm
            // 
            txtGsm.Location = new Point(358, 271);
            txtGsm.Name = "txtGsm";
            txtGsm.Size = new Size(241, 27);
            txtGsm.TabIndex = 7;
            // 
            // lblgsm
            // 
            lblgsm.AutoSize = true;
            lblgsm.ForeColor = Color.DarkSlateGray;
            lblgsm.Location = new Point(191, 274);
            lblgsm.Name = "lblgsm";
            lblgsm.Size = new Size(42, 19);
            lblgsm.TabIndex = 6;
            lblgsm.Text = "GSM:";
            // 
            // txttckn
            // 
            txttckn.Location = new Point(358, 228);
            txttckn.Name = "txttckn";
            txttckn.Size = new Size(241, 27);
            txttckn.TabIndex = 5;
            // 
            // lblTckn
            // 
            lblTckn.AutoSize = true;
            lblTckn.ForeColor = Color.DarkSlateGray;
            lblTckn.Location = new Point(189, 231);
            lblTckn.Name = "lblTckn";
            lblTckn.Size = new Size(144, 19);
            lblTckn.TabIndex = 4;
            lblTckn.Text = "T.C. Kimlik Numarası:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(358, 181);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(241, 27);
            txtSoyad.TabIndex = 3;
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.ForeColor = Color.DarkSlateGray;
            lblsoyad.Location = new Point(191, 184);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(57, 19);
            lblsoyad.TabIndex = 2;
            lblsoyad.Text = "Soyadı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(358, 134);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(241, 27);
            txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.ForeColor = Color.DarkSlateGray;
            lblAd.Location = new Point(191, 142);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(34, 19);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adı:";
            // 
            // taboduncKitap
            // 
            taboduncKitap.BackColor = SystemColors.ButtonHighlight;
            taboduncKitap.Controls.Add(label6);
            taboduncKitap.Controls.Add(label5);
            taboduncKitap.Controls.Add(label4);
            taboduncKitap.Controls.Add(dtpIadeTarihi);
            taboduncKitap.Controls.Add(dtpAlisTarihi);
            taboduncKitap.Controls.Add(btnOduncKaydet);
            taboduncKitap.Controls.Add(label3);
            taboduncKitap.Controls.Add(ktpListCombo);
            taboduncKitap.Location = new Point(4, 27);
            taboduncKitap.Name = "taboduncKitap";
            taboduncKitap.Padding = new Padding(3);
            taboduncKitap.Size = new Size(950, 524);
            taboduncKitap.TabIndex = 1;
            taboduncKitap.Text = "Ödünç Kitap";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(199, 255);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 15;
            label6.Text = "İade Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(199, 210);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 14;
            label5.Text = "Teslim Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Blinker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(381, 56);
            label4.Name = "label4";
            label4.Size = new Size(178, 29);
            label4.TabIndex = 13;
            label4.Text = "KİTAP ÖDÜNÇ AL";
            // 
            // dtpIadeTarihi
            // 
            dtpIadeTarihi.Location = new Point(364, 255);
            dtpIadeTarihi.Name = "dtpIadeTarihi";
            dtpIadeTarihi.Size = new Size(266, 27);
            dtpIadeTarihi.TabIndex = 2;
            // 
            // dtpAlisTarihi
            // 
            dtpAlisTarihi.Location = new Point(364, 206);
            dtpAlisTarihi.Name = "dtpAlisTarihi";
            dtpAlisTarihi.Size = new Size(266, 27);
            dtpAlisTarihi.TabIndex = 1;
            // 
            // btnOduncKaydet
            // 
            btnOduncKaydet.BackColor = Color.SteelBlue;
            btnOduncKaydet.FlatStyle = FlatStyle.Flat;
            btnOduncKaydet.ForeColor = Color.White;
            btnOduncKaydet.Location = new Point(394, 357);
            btnOduncKaydet.Name = "btnOduncKaydet";
            btnOduncKaydet.Size = new Size(165, 49);
            btnOduncKaydet.TabIndex = 3;
            btnOduncKaydet.Text = "KAYDET";
            btnOduncKaydet.UseVisualStyleBackColor = false;
            btnOduncKaydet.Click += btnOduncKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(199, 153);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 1;
            label3.Text = "Kitap Seçiniz:";
            // 
            // ktpListCombo
            // 
            ktpListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ktpListCombo.FormattingEnabled = true;
            ktpListCombo.Location = new Point(364, 149);
            ktpListCombo.Name = "ktpListCombo";
            ktpListCombo.Size = new Size(266, 27);
            ktpListCombo.TabIndex = 0;
            ktpListCombo.SelectedIndexChanged += ktpListCombo_SelectedIndexChanged;
            // 
            // tabKitapIade
            // 
            tabKitapIade.BackColor = SystemColors.ButtonHighlight;
            tabKitapIade.BackgroundImage = Properties.Resources.bookbgdef2;
            tabKitapIade.BackgroundImageLayout = ImageLayout.Stretch;
            tabKitapIade.Controls.Add(label8);
            tabKitapIade.Controls.Add(button2);
            tabKitapIade.Controls.Add(cmbKitapIadeList);
            tabKitapIade.Controls.Add(label7);
            tabKitapIade.Location = new Point(4, 31);
            tabKitapIade.Name = "tabKitapIade";
            tabKitapIade.Padding = new Padding(3);
            tabKitapIade.Size = new Size(950, 520);
            tabKitapIade.TabIndex = 2;
            tabKitapIade.Text = "Kitap İade";

            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Blinker", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(413, 55);
            label8.Name = "label8";
            label8.Size = new Size(124, 29);
            label8.TabIndex = 14;
            label8.Text = "KİTAP İADE";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(494, 246);
            button2.Name = "button2";
            button2.Size = new Size(151, 41);
            button2.TabIndex = 2;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cmbKitapIadeList
            // 
            cmbKitapIadeList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKitapIadeList.FormattingEnabled = true;
            cmbKitapIadeList.Location = new Point(413, 154);
            cmbKitapIadeList.Name = "cmbKitapIadeList";
            cmbKitapIadeList.Size = new Size(232, 27);
            cmbKitapIadeList.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(190, 157);
            label7.Name = "label7";
            label7.Size = new Size(184, 19);
            label7.TabIndex = 0;
            label7.Text = "İade Edilecek Kitap Seçiniz:";
            // 
            // tabOkunanKitaplar
            // 
            tabOkunanKitaplar.BackColor = SystemColors.ButtonHighlight;
            tabOkunanKitaplar.Controls.Add(button11);
            tabOkunanKitaplar.Controls.Add(txtOkunanKitapAra);
            tabOkunanKitaplar.Controls.Add(label2);
            tabOkunanKitaplar.Controls.Add(userOkunanKitaplarList);
            tabOkunanKitaplar.Location = new Point(4, 27);
            tabOkunanKitaplar.Name = "tabOkunanKitaplar";
            tabOkunanKitaplar.Padding = new Padding(3);
            tabOkunanKitaplar.Size = new Size(950, 524);
            tabOkunanKitaplar.TabIndex = 3;
            tabOkunanKitaplar.Text = "Okunan Kitaplar";
            // 
            // button11
            // 
            button11.BackColor = Color.OliveDrab;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.ButtonFace;
            button11.Location = new Point(817, 21);
            button11.Name = "button11";
            button11.Size = new Size(108, 33);
            button11.TabIndex = 17;
            button11.Text = "YENİLE";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // txtOkunanKitapAra
            // 
            txtOkunanKitapAra.Location = new Point(164, 18);
            txtOkunanKitapAra.Name = "txtOkunanKitapAra";
            txtOkunanKitapAra.Size = new Size(218, 27);
            txtOkunanKitapAra.TabIndex = 2;
            txtOkunanKitapAra.TextChanged += txtOkunanKitapAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 21);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 1;
            label2.Text = "Ara:";
            // 
            // userOkunanKitaplarList
            // 
            userOkunanKitaplarList.Location = new Point(20, 64);
            userOkunanKitaplarList.Name = "userOkunanKitaplarList";
            userOkunanKitaplarList.Size = new Size(906, 416);
            userOkunanKitaplarList.TabIndex = 0;
            userOkunanKitaplarList.UseCompatibleStateImageBehavior = false;
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(955, 553);
            Controls.Add(tabControl1);
            Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Kullanıcı Formu";
            Load += frmKullanici_Load;
            tabControl1.ResumeLayout(false);
            s.ResumeLayout(false);
            s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePhoto).EndInit();
            taboduncKitap.ResumeLayout(false);
            taboduncKitap.PerformLayout();
            tabKitapIade.ResumeLayout(false);
            tabKitapIade.PerformLayout();
            tabOkunanKitaplar.ResumeLayout(false);
            tabOkunanKitaplar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage s;
        private TabPage taboduncKitap;
        private TabPage tabKitapIade;
        private TabPage tabOkunanKitaplar;
        private TextBox txtcinsiyet;
        private Label lblcinsiyet;
        private TextBox txtemail;
        private Label lblmail;
        private TextBox txtGsm;
        private Label lblgsm;
        private TextBox txttckn;
        private Label lblTckn;
        private TextBox txtSoyad;
        private Label lblsoyad;
        private TextBox txtAd;
        private Label lblAd;
        private Label label1;
        private Button button1;
        private ListView userOkunanKitaplarList;
        private TextBox txtOkunanKitapAra;
        private Label label2;
        private Button button11;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpIadeTarihi;
        private DateTimePicker dtpAlisTarihi;
        private Button btnOduncKaydet;
        private Label label3;
        private ComboBox ktpListCombo;
        private PictureBox profilePhoto;
        private Button button2;
        private ComboBox cmbKitapIadeList;
        private Label label7;
        private Label label8;
    }
}