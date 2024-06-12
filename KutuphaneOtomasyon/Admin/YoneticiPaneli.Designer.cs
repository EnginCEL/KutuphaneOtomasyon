namespace KutuphaneOtomasyon.Admin
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            tabControl1 = new TabControl();
            tabKullanicilar = new TabPage();
            button3 = new Button();
            button1 = new Button();
            txtara = new TextBox();
            lblara = new Label();
            userList = new ListView();
            tabEkle = new TabPage();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtsifre2 = new TextBox();
            lblsifre2 = new Label();
            txtsifre1 = new TextBox();
            label1 = new Label();
            txtposta = new TextBox();
            lbleposta = new Label();
            txttelefon = new TextBox();
            lbltelefon = new Label();
            txttckn = new TextBox();
            lbltckn = new Label();
            txtsoyadi = new TextBox();
            lblsoyad = new Label();
            groupBox1 = new GroupBox();
            btnkadin = new RadioButton();
            btnerkek = new RadioButton();
            btnkaydet = new Button();
            txtadi = new TextBox();
            txtad = new Label();
            tabSil = new TabPage();
            button4 = new Button();
            btnKullaniciSil = new Button();
            button2 = new Button();
            txtaraSil = new TextBox();
            label10 = new Label();
            lstKullaniciSil = new ListView();
            tabGuncelle = new TabPage();
            button6 = new Button();
            txtMailGuncelle = new TextBox();
            label11 = new Label();
            txtParolaGuncelle = new TextBox();
            lblParolaGuncelle = new Label();
            grpCinsiyetGuncelle = new GroupBox();
            rdErkekGuncelle = new RadioButton();
            rdKadinGuncelle = new RadioButton();
            grpIsAdminGuncelle = new GroupBox();
            rdIsadminHayirGuncelle = new RadioButton();
            rdIsadminEvetGuncelle = new RadioButton();
            grpIsActiveGuncelle = new GroupBox();
            rdPasifGuncelle = new RadioButton();
            rdAktifGuncelle = new RadioButton();
            txtguncelleTCKN = new TextBox();
            lblguncellTckn = new Label();
            txtGuncelleGsm = new TextBox();
            lblGuncelleGsm = new Label();
            txtGuncelleSoyad = new TextBox();
            lblguncelleSoyad = new Label();
            lstGuncelleAll = new ListView();
            button5 = new Button();
            txtGuncelleAd = new TextBox();
            lblguncelleAd = new Label();
            tabOdunc = new TabPage();
            button11 = new Button();
            lblodunckitapara = new Label();
            txtOduncKitapAra = new TextBox();
            lstyoneticiOducKitap = new ListView();
            tabKaynaklar = new TabPage();
            button7 = new Button();
            button8 = new Button();
            txtKaynakAra = new TextBox();
            label12 = new Label();
            lstTumKaynaklar = new ListView();
            tabkynkEkle = new TabPage();
            numSourcePage = new NumericUpDown();
            dpcPublicationDate = new DateTimePicker();
            lblpublication = new Label();
            label15 = new Label();
            txtSourceWriter = new TextBox();
            lblKaynakWriter = new Label();
            btnsourceKaydet = new Button();
            txtKaynakName = new TextBox();
            lblsourceName = new Label();
            tabkynkSil = new TabPage();
            btnKaynakYenile = new Button();
            btnKaynakSil = new Button();
            btnSourceExit = new Button();
            txtKaynakAraSil = new TextBox();
            lblKaynakAra = new Label();
            lstKaynakSil = new ListView();
            tabkynkGuncelle = new TabPage();
            dtpSourceGuncelle = new DateTimePicker();
            numSourceGuncelle = new NumericUpDown();
            lblguncelleYayinTarihi = new Label();
            txtKaynakGuncelYazar = new TextBox();
            lblKaynakGuncelleYazar = new Label();
            lblSayfaGuncelle = new Label();
            txtKaynakGuncelAd = new TextBox();
            lblKaynakGuncelleAd = new Label();
            button9 = new Button();
            lstKaynakGuncelle = new ListView();
            button10 = new Button();
            tabControl1.SuspendLayout();
            tabKullanicilar.SuspendLayout();
            tabEkle.SuspendLayout();
            groupBox1.SuspendLayout();
            tabSil.SuspendLayout();
            tabGuncelle.SuspendLayout();
            grpCinsiyetGuncelle.SuspendLayout();
            grpIsAdminGuncelle.SuspendLayout();
            grpIsActiveGuncelle.SuspendLayout();
            tabOdunc.SuspendLayout();
            tabKaynaklar.SuspendLayout();
            tabkynkEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSourcePage).BeginInit();
            tabkynkSil.SuspendLayout();
            tabkynkGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSourceGuncelle).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabKullanicilar);
            tabControl1.Controls.Add(tabEkle);
            tabControl1.Controls.Add(tabSil);
            tabControl1.Controls.Add(tabGuncelle);
            tabControl1.Controls.Add(tabOdunc);
            tabControl1.Controls.Add(tabKaynaklar);
            tabControl1.Controls.Add(tabkynkEkle);
            tabControl1.Controls.Add(tabkynkSil);
            tabControl1.Controls.Add(tabkynkGuncelle);
            tabControl1.Location = new Point(1, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(969, 584);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabKullanicilar
            // 
            tabKullanicilar.BackColor = SystemColors.ButtonHighlight;
            tabKullanicilar.Controls.Add(button3);
            tabKullanicilar.Controls.Add(button1);
            tabKullanicilar.Controls.Add(txtara);
            tabKullanicilar.Controls.Add(lblara);
            tabKullanicilar.Controls.Add(userList);
            tabKullanicilar.ForeColor = SystemColors.ButtonFace;
            tabKullanicilar.Location = new Point(4, 31);
            tabKullanicilar.Name = "tabKullanicilar";
            tabKullanicilar.Padding = new Padding(3);
            tabKullanicilar.Size = new Size(961, 549);
            tabKullanicilar.TabIndex = 0;
            tabKullanicilar.Text = "Kullanıcılar";
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(673, 14);
            button3.Name = "button3";
            button3.Size = new Size(108, 33);
            button3.TabIndex = 4;
            button3.Text = "YENİLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(814, 14);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 3;
            button1.Text = "ÇIKIŞ X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtara
            // 
            txtara.Location = new Point(153, 15);
            txtara.Name = "txtara";
            txtara.Size = new Size(238, 27);
            txtara.TabIndex = 2;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.BackColor = SystemColors.ButtonHighlight;
            lblara.ForeColor = SystemColors.ActiveCaptionText;
            lblara.Location = new Point(31, 18);
            lblara.Name = "lblara";
            lblara.Size = new Size(93, 19);
            lblara.TabIndex = 1;
            lblara.Text = "Kullanıcı Ara:";
            // 
            // userList
            // 
            userList.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userList.Location = new Point(31, 53);
            userList.MultiSelect = false;
            userList.Name = "userList";
            userList.ShowItemToolTips = true;
            userList.Size = new Size(891, 423);
            userList.TabIndex = 0;
            userList.UseCompatibleStateImageBehavior = false;
            // 
            // tabEkle
            // 
            tabEkle.BackColor = SystemColors.ButtonHighlight;
            tabEkle.Controls.Add(label9);
            tabEkle.Controls.Add(label8);
            tabEkle.Controls.Add(label7);
            tabEkle.Controls.Add(label6);
            tabEkle.Controls.Add(label5);
            tabEkle.Controls.Add(label4);
            tabEkle.Controls.Add(label3);
            tabEkle.Controls.Add(label2);
            tabEkle.Controls.Add(txtsifre2);
            tabEkle.Controls.Add(lblsifre2);
            tabEkle.Controls.Add(txtsifre1);
            tabEkle.Controls.Add(label1);
            tabEkle.Controls.Add(txtposta);
            tabEkle.Controls.Add(lbleposta);
            tabEkle.Controls.Add(txttelefon);
            tabEkle.Controls.Add(lbltelefon);
            tabEkle.Controls.Add(txttckn);
            tabEkle.Controls.Add(lbltckn);
            tabEkle.Controls.Add(txtsoyadi);
            tabEkle.Controls.Add(lblsoyad);
            tabEkle.Controls.Add(groupBox1);
            tabEkle.Controls.Add(btnkaydet);
            tabEkle.Controls.Add(txtadi);
            tabEkle.Controls.Add(txtad);
            tabEkle.Location = new Point(4, 31);
            tabEkle.Name = "tabEkle";
            tabEkle.Padding = new Padding(3);
            tabEkle.Size = new Size(961, 549);
            tabEkle.TabIndex = 1;
            tabEkle.Text = "Ekle";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(586, 394);
            label9.Name = "label9";
            label9.Size = new Size(17, 23);
            label9.TabIndex = 24;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(621, 316);
            label8.Name = "label8";
            label8.Size = new Size(17, 23);
            label8.TabIndex = 23;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(621, 270);
            label7.Name = "label7";
            label7.Size = new Size(17, 23);
            label7.TabIndex = 22;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(621, 221);
            label6.Name = "label6";
            label6.Size = new Size(17, 23);
            label6.TabIndex = 21;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(621, 183);
            label5.Name = "label5";
            label5.Size = new Size(17, 23);
            label5.TabIndex = 20;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(621, 147);
            label4.Name = "label4";
            label4.Size = new Size(17, 23);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(621, 112);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(621, 72);
            label2.Name = "label2";
            label2.Size = new Size(17, 23);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // txtsifre2
            // 
            txtsifre2.Location = new Point(394, 312);
            txtsifre2.Name = "txtsifre2";
            txtsifre2.Size = new Size(221, 27);
            txtsifre2.TabIndex = 6;
            // 
            // lblsifre2
            // 
            lblsifre2.AutoSize = true;
            lblsifre2.Location = new Point(266, 314);
            lblsifre2.Name = "lblsifre2";
            lblsifre2.Size = new Size(93, 19);
            lblsifre2.TabIndex = 15;
            lblsifre2.Text = "Şifre Tekrarı:";
            // 
            // txtsifre1
            // 
            txtsifre1.Location = new Point(394, 268);
            txtsifre1.Name = "txtsifre1";
            txtsifre1.Size = new Size(221, 27);
            txtsifre1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 270);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 13;
            label1.Text = "Şifre:";
            // 
            // txtposta
            // 
            txtposta.Location = new Point(394, 223);
            txtposta.Name = "txtposta";
            txtposta.Size = new Size(221, 27);
            txtposta.TabIndex = 4;
            // 
            // lbleposta
            // 
            lbleposta.AutoSize = true;
            lbleposta.Location = new Point(266, 225);
            lbleposta.Name = "lbleposta";
            lbleposta.Size = new Size(66, 19);
            lbleposta.TabIndex = 11;
            lbleposta.Text = "e-Posta:";
            // 
            // txttelefon
            // 
            txttelefon.Location = new Point(394, 180);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(221, 27);
            txttelefon.TabIndex = 3;
            // 
            // lbltelefon
            // 
            lbltelefon.AutoSize = true;
            lbltelefon.Location = new Point(266, 183);
            lbltelefon.Name = "lbltelefon";
            lbltelefon.Size = new Size(63, 19);
            lbltelefon.TabIndex = 9;
            lbltelefon.Text = "Telefon:";
            // 
            // txttckn
            // 
            txttckn.Location = new Point(394, 142);
            txttckn.Name = "txttckn";
            txttckn.Size = new Size(221, 27);
            txttckn.TabIndex = 2;
            // 
            // lbltckn
            // 
            lbltckn.AutoSize = true;
            lbltckn.Location = new Point(277, 150);
            lbltckn.Name = "lbltckn";
            lbltckn.Size = new Size(46, 19);
            lbltckn.TabIndex = 7;
            lbltckn.Text = "TCKN";
            // 
            // txtsoyadi
            // 
            txtsoyadi.Location = new Point(394, 106);
            txtsoyadi.Name = "txtsoyadi";
            txtsoyadi.Size = new Size(221, 27);
            txtsoyadi.TabIndex = 1;
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(266, 114);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(57, 19);
            lblsoyad.TabIndex = 5;
            lblsoyad.Text = "Soyadı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnkadin);
            groupBox1.Controls.Add(btnerkek);
            groupBox1.Location = new Point(375, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 81);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // btnkadin
            // 
            btnkadin.AutoSize = true;
            btnkadin.Location = new Point(21, 55);
            btnkadin.Name = "btnkadin";
            btnkadin.Size = new Size(71, 23);
            btnkadin.TabIndex = 8;
            btnkadin.TabStop = true;
            btnkadin.Text = "KADIN";
            btnkadin.UseVisualStyleBackColor = true;
            // 
            // btnerkek
            // 
            btnerkek.AutoSize = true;
            btnerkek.Location = new Point(21, 26);
            btnerkek.Name = "btnerkek";
            btnerkek.Size = new Size(70, 23);
            btnerkek.TabIndex = 7;
            btnerkek.TabStop = true;
            btnerkek.Text = "ERKEK";
            btnerkek.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.SteelBlue;
            btnkaydet.FlatStyle = FlatStyle.Flat;
            btnkaydet.ForeColor = SystemColors.ButtonHighlight;
            btnkaydet.Location = new Point(399, 461);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(153, 47);
            btnkaydet.TabIndex = 9;
            btnkaydet.Text = "KAYDET";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtadi
            // 
            txtadi.Location = new Point(394, 66);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(221, 27);
            txtadi.TabIndex = 0;
            // 
            // txtad
            // 
            txtad.AutoSize = true;
            txtad.Location = new Point(289, 74);
            txtad.Name = "txtad";
            txtad.Size = new Size(34, 19);
            txtad.TabIndex = 0;
            txtad.Text = "Adı:";
            // 
            // tabSil
            // 
            tabSil.BackColor = SystemColors.ButtonHighlight;
            tabSil.Controls.Add(button4);
            tabSil.Controls.Add(btnKullaniciSil);
            tabSil.Controls.Add(button2);
            tabSil.Controls.Add(txtaraSil);
            tabSil.Controls.Add(label10);
            tabSil.Controls.Add(lstKullaniciSil);
            tabSil.Location = new Point(4, 31);
            tabSil.Name = "tabSil";
            tabSil.Padding = new Padding(3);
            tabSil.Size = new Size(961, 549);
            tabSil.TabIndex = 2;
            tabSil.Text = "Sil";
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(650, 21);
            button4.Name = "button4";
            button4.Size = new Size(108, 33);
            button4.TabIndex = 9;
            button4.Text = "YENİLE";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.BackColor = Color.IndianRed;
            btnKullaniciSil.FlatStyle = FlatStyle.Flat;
            btnKullaniciSil.ForeColor = SystemColors.ButtonFace;
            btnKullaniciSil.Location = new Point(419, 20);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(204, 33);
            btnKullaniciSil.TabIndex = 8;
            btnKullaniciSil.Text = "Seçilen Kullanıcıyı Sil";
            btnKullaniciSil.UseVisualStyleBackColor = false;
            btnKullaniciSil.Click += btnKullaniciSil_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(841, 6);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 7;
            button2.Text = "ÇIKIŞ X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtaraSil
            // 
            txtaraSil.Location = new Point(148, 24);
            txtaraSil.Name = "txtaraSil";
            txtaraSil.Size = new Size(238, 27);
            txtaraSil.TabIndex = 6;
            txtaraSil.TextChanged += txtaraSil_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(26, 27);
            label10.Name = "label10";
            label10.Size = new Size(93, 19);
            label10.TabIndex = 5;
            label10.Text = "Kullanıcı Ara:";
            // 
            // lstKullaniciSil
            // 
            lstKullaniciSil.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstKullaniciSil.Location = new Point(26, 62);
            lstKullaniciSil.MultiSelect = false;
            lstKullaniciSil.Name = "lstKullaniciSil";
            lstKullaniciSil.ShowItemToolTips = true;
            lstKullaniciSil.Size = new Size(891, 423);
            lstKullaniciSil.TabIndex = 4;
            lstKullaniciSil.UseCompatibleStateImageBehavior = false;
            // 
            // tabGuncelle
            // 
            tabGuncelle.BackColor = SystemColors.ButtonHighlight;
            tabGuncelle.Controls.Add(button6);
            tabGuncelle.Controls.Add(txtMailGuncelle);
            tabGuncelle.Controls.Add(label11);
            tabGuncelle.Controls.Add(txtParolaGuncelle);
            tabGuncelle.Controls.Add(lblParolaGuncelle);
            tabGuncelle.Controls.Add(grpCinsiyetGuncelle);
            tabGuncelle.Controls.Add(grpIsAdminGuncelle);
            tabGuncelle.Controls.Add(grpIsActiveGuncelle);
            tabGuncelle.Controls.Add(txtguncelleTCKN);
            tabGuncelle.Controls.Add(lblguncellTckn);
            tabGuncelle.Controls.Add(txtGuncelleGsm);
            tabGuncelle.Controls.Add(lblGuncelleGsm);
            tabGuncelle.Controls.Add(txtGuncelleSoyad);
            tabGuncelle.Controls.Add(lblguncelleSoyad);
            tabGuncelle.Controls.Add(lstGuncelleAll);
            tabGuncelle.Controls.Add(button5);
            tabGuncelle.Controls.Add(txtGuncelleAd);
            tabGuncelle.Controls.Add(lblguncelleAd);
            tabGuncelle.Location = new Point(4, 31);
            tabGuncelle.Name = "tabGuncelle";
            tabGuncelle.Padding = new Padding(3);
            tabGuncelle.Size = new Size(961, 549);
            tabGuncelle.TabIndex = 3;
            tabGuncelle.Text = "Güncelle";
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(835, 6);
            button6.Name = "button6";
            button6.Size = new Size(108, 33);
            button6.TabIndex = 15;
            button6.Text = "YENİLE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txtMailGuncelle
            // 
            txtMailGuncelle.Location = new Point(417, 324);
            txtMailGuncelle.Name = "txtMailGuncelle";
            txtMailGuncelle.Size = new Size(196, 27);
            txtMailGuncelle.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(330, 327);
            label11.Name = "label11";
            label11.Size = new Size(53, 19);
            label11.TabIndex = 14;
            label11.Text = "e-Mail:";
            // 
            // txtParolaGuncelle
            // 
            txtParolaGuncelle.Location = new Point(736, 321);
            txtParolaGuncelle.Name = "txtParolaGuncelle";
            txtParolaGuncelle.Size = new Size(196, 27);
            txtParolaGuncelle.TabIndex = 4;
            // 
            // lblParolaGuncelle
            // 
            lblParolaGuncelle.AutoSize = true;
            lblParolaGuncelle.Location = new Point(649, 324);
            lblParolaGuncelle.Name = "lblParolaGuncelle";
            lblParolaGuncelle.Size = new Size(55, 19);
            lblParolaGuncelle.TabIndex = 12;
            lblParolaGuncelle.Text = "Parola:";
            // 
            // grpCinsiyetGuncelle
            // 
            grpCinsiyetGuncelle.Controls.Add(rdErkekGuncelle);
            grpCinsiyetGuncelle.Controls.Add(rdKadinGuncelle);
            grpCinsiyetGuncelle.Location = new Point(27, 383);
            grpCinsiyetGuncelle.Name = "grpCinsiyetGuncelle";
            grpCinsiyetGuncelle.Size = new Size(252, 55);
            grpCinsiyetGuncelle.TabIndex = 0;
            grpCinsiyetGuncelle.TabStop = false;
            grpCinsiyetGuncelle.Text = "Cinsiyet:";
            // 
            // rdErkekGuncelle
            // 
            rdErkekGuncelle.AutoSize = true;
            rdErkekGuncelle.Location = new Point(143, 23);
            rdErkekGuncelle.Name = "rdErkekGuncelle";
            rdErkekGuncelle.Size = new Size(65, 23);
            rdErkekGuncelle.TabIndex = 6;
            rdErkekGuncelle.TabStop = true;
            rdErkekGuncelle.Text = "Erkek";
            rdErkekGuncelle.UseVisualStyleBackColor = true;
            // 
            // rdKadinGuncelle
            // 
            rdKadinGuncelle.AutoSize = true;
            rdKadinGuncelle.Location = new Point(54, 22);
            rdKadinGuncelle.Name = "rdKadinGuncelle";
            rdKadinGuncelle.Size = new Size(65, 23);
            rdKadinGuncelle.TabIndex = 5;
            rdKadinGuncelle.TabStop = true;
            rdKadinGuncelle.Text = "Kadın";
            rdKadinGuncelle.UseVisualStyleBackColor = true;
            // 
            // grpIsAdminGuncelle
            // 
            grpIsAdminGuncelle.Controls.Add(rdIsadminHayirGuncelle);
            grpIsAdminGuncelle.Controls.Add(rdIsadminEvetGuncelle);
            grpIsAdminGuncelle.Location = new Point(361, 388);
            grpIsAdminGuncelle.Name = "grpIsAdminGuncelle";
            grpIsAdminGuncelle.Size = new Size(252, 48);
            grpIsAdminGuncelle.TabIndex = 0;
            grpIsAdminGuncelle.TabStop = false;
            grpIsAdminGuncelle.Text = "Admin";
            // 
            // rdIsadminHayirGuncelle
            // 
            rdIsadminHayirGuncelle.AutoSize = true;
            rdIsadminHayirGuncelle.Location = new Point(143, 19);
            rdIsadminHayirGuncelle.Name = "rdIsadminHayirGuncelle";
            rdIsadminHayirGuncelle.Size = new Size(62, 23);
            rdIsadminHayirGuncelle.TabIndex = 8;
            rdIsadminHayirGuncelle.TabStop = true;
            rdIsadminHayirGuncelle.Text = "Hayır";
            rdIsadminHayirGuncelle.UseVisualStyleBackColor = true;
            // 
            // rdIsadminEvetGuncelle
            // 
            rdIsadminEvetGuncelle.AutoSize = true;
            rdIsadminEvetGuncelle.Location = new Point(54, 18);
            rdIsadminEvetGuncelle.Name = "rdIsadminEvetGuncelle";
            rdIsadminEvetGuncelle.Size = new Size(57, 23);
            rdIsadminEvetGuncelle.TabIndex = 7;
            rdIsadminEvetGuncelle.TabStop = true;
            rdIsadminEvetGuncelle.Text = "Evet";
            rdIsadminEvetGuncelle.UseVisualStyleBackColor = true;
            // 
            // grpIsActiveGuncelle
            // 
            grpIsActiveGuncelle.Controls.Add(rdPasifGuncelle);
            grpIsActiveGuncelle.Controls.Add(rdAktifGuncelle);
            grpIsActiveGuncelle.Location = new Point(680, 389);
            grpIsActiveGuncelle.Name = "grpIsActiveGuncelle";
            grpIsActiveGuncelle.Size = new Size(252, 50);
            grpIsActiveGuncelle.TabIndex = 10;
            grpIsActiveGuncelle.TabStop = false;
            grpIsActiveGuncelle.Text = "Aktif / Pasif";
            // 
            // rdPasifGuncelle
            // 
            rdPasifGuncelle.AutoSize = true;
            rdPasifGuncelle.Location = new Point(143, 21);
            rdPasifGuncelle.Name = "rdPasifGuncelle";
            rdPasifGuncelle.Size = new Size(60, 23);
            rdPasifGuncelle.TabIndex = 10;
            rdPasifGuncelle.TabStop = true;
            rdPasifGuncelle.Text = "Pasif";
            rdPasifGuncelle.UseVisualStyleBackColor = true;
            // 
            // rdAktifGuncelle
            // 
            rdAktifGuncelle.AutoSize = true;
            rdAktifGuncelle.Location = new Point(54, 20);
            rdAktifGuncelle.Name = "rdAktifGuncelle";
            rdAktifGuncelle.Size = new Size(60, 23);
            rdAktifGuncelle.TabIndex = 9;
            rdAktifGuncelle.TabStop = true;
            rdAktifGuncelle.Text = "Aktif";
            rdAktifGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtguncelleTCKN
            // 
            txtguncelleTCKN.Location = new Point(94, 321);
            txtguncelleTCKN.Name = "txtguncelleTCKN";
            txtguncelleTCKN.Size = new Size(196, 27);
            txtguncelleTCKN.TabIndex = 3;
            // 
            // lblguncellTckn
            // 
            lblguncellTckn.AutoSize = true;
            lblguncellTckn.Location = new Point(17, 321);
            lblguncellTckn.Name = "lblguncellTckn";
            lblguncellTckn.Size = new Size(49, 19);
            lblguncellTckn.TabIndex = 8;
            lblguncellTckn.Text = "TCKN:";
            // 
            // txtGuncelleGsm
            // 
            txtGuncelleGsm.Location = new Point(736, 263);
            txtGuncelleGsm.Name = "txtGuncelleGsm";
            txtGuncelleGsm.Size = new Size(196, 27);
            txtGuncelleGsm.TabIndex = 2;
            // 
            // lblGuncelleGsm
            // 
            lblGuncelleGsm.AutoSize = true;
            lblGuncelleGsm.Location = new Point(649, 266);
            lblGuncelleGsm.Name = "lblGuncelleGsm";
            lblGuncelleGsm.Size = new Size(42, 19);
            lblGuncelleGsm.TabIndex = 6;
            lblGuncelleGsm.Text = "GSM:";
            // 
            // txtGuncelleSoyad
            // 
            txtGuncelleSoyad.Location = new Point(417, 263);
            txtGuncelleSoyad.Name = "txtGuncelleSoyad";
            txtGuncelleSoyad.Size = new Size(196, 27);
            txtGuncelleSoyad.TabIndex = 1;
            // 
            // lblguncelleSoyad
            // 
            lblguncelleSoyad.AutoSize = true;
            lblguncelleSoyad.Location = new Point(335, 271);
            lblguncelleSoyad.Name = "lblguncelleSoyad";
            lblguncelleSoyad.Size = new Size(54, 19);
            lblguncelleSoyad.TabIndex = 4;
            lblguncelleSoyad.Text = "Soyad:";
            // 
            // lstGuncelleAll
            // 
            lstGuncelleAll.Location = new Point(6, 46);
            lstGuncelleAll.Name = "lstGuncelleAll";
            lstGuncelleAll.Size = new Size(940, 205);
            lstGuncelleAll.TabIndex = 3;
            lstGuncelleAll.UseCompatibleStateImageBehavior = false;
            lstGuncelleAll.SelectedIndexChanged += lstGuncelleAll_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(384, 498);
            button5.Name = "button5";
            button5.Size = new Size(151, 36);
            button5.TabIndex = 11;
            button5.Text = "GÜNCELLE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtGuncelleAd
            // 
            txtGuncelleAd.Location = new Point(94, 268);
            txtGuncelleAd.Name = "txtGuncelleAd";
            txtGuncelleAd.Size = new Size(196, 27);
            txtGuncelleAd.TabIndex = 0;
            // 
            // lblguncelleAd
            // 
            lblguncelleAd.AutoSize = true;
            lblguncelleAd.Location = new Point(17, 271);
            lblguncelleAd.Name = "lblguncelleAd";
            lblguncelleAd.Size = new Size(31, 19);
            lblguncelleAd.TabIndex = 0;
            lblguncelleAd.Text = "Ad:";
            // 
            // tabOdunc
            // 
            tabOdunc.BackColor = SystemColors.ButtonHighlight;
            tabOdunc.Controls.Add(button11);
            tabOdunc.Controls.Add(lblodunckitapara);
            tabOdunc.Controls.Add(txtOduncKitapAra);
            tabOdunc.Controls.Add(lstyoneticiOducKitap);
            tabOdunc.Location = new Point(4, 31);
            tabOdunc.Name = "tabOdunc";
            tabOdunc.Padding = new Padding(3);
            tabOdunc.Size = new Size(961, 549);
            tabOdunc.TabIndex = 4;
            tabOdunc.Text = "Ödünç Kitap";
            // 
            // button11
            // 
            button11.BackColor = Color.OliveDrab;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.ButtonFace;
            button11.Location = new Point(831, 30);
            button11.Name = "button11";
            button11.Size = new Size(108, 33);
            button11.TabIndex = 16;
            button11.Text = "YENİLE";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // lblodunckitapara
            // 
            lblodunckitapara.AutoSize = true;
            lblodunckitapara.Location = new Point(17, 36);
            lblodunckitapara.Name = "lblodunckitapara";
            lblodunckitapara.Size = new Size(155, 19);
            lblodunckitapara.TabIndex = 2;
            lblodunckitapara.Text = "Ödünç Kitaplarda Ara:";
            // 
            // txtOduncKitapAra
            // 
            txtOduncKitapAra.Location = new Point(211, 28);
            txtOduncKitapAra.Name = "txtOduncKitapAra";
            txtOduncKitapAra.Size = new Size(240, 27);
            txtOduncKitapAra.TabIndex = 1;
            txtOduncKitapAra.TextChanged += txtOduncKitapAra_TextChanged;
            // 
            // lstyoneticiOducKitap
            // 
            lstyoneticiOducKitap.Location = new Point(18, 75);
            lstyoneticiOducKitap.Name = "lstyoneticiOducKitap";
            lstyoneticiOducKitap.Size = new Size(922, 451);
            lstyoneticiOducKitap.TabIndex = 0;
            lstyoneticiOducKitap.UseCompatibleStateImageBehavior = false;
            // 
            // tabKaynaklar
            // 
            tabKaynaklar.BackColor = SystemColors.ButtonHighlight;
            tabKaynaklar.Controls.Add(button7);
            tabKaynaklar.Controls.Add(button8);
            tabKaynaklar.Controls.Add(txtKaynakAra);
            tabKaynaklar.Controls.Add(label12);
            tabKaynaklar.Controls.Add(lstTumKaynaklar);
            tabKaynaklar.Location = new Point(4, 31);
            tabKaynaklar.Name = "tabKaynaklar";
            tabKaynaklar.Padding = new Padding(3);
            tabKaynaklar.Size = new Size(961, 549);
            tabKaynaklar.TabIndex = 5;
            tabKaynaklar.Text = "Kaynaklar";
            // 
            // button7
            // 
            button7.BackColor = Color.OliveDrab;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(677, 25);
            button7.Name = "button7";
            button7.Size = new Size(108, 33);
            button7.TabIndex = 9;
            button7.Text = "YENİLE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(818, 25);
            button8.Name = "button8";
            button8.Size = new Size(108, 33);
            button8.TabIndex = 8;
            button8.Text = "ÇIKIŞ X";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // txtKaynakAra
            // 
            txtKaynakAra.Location = new Point(157, 26);
            txtKaynakAra.Name = "txtKaynakAra";
            txtKaynakAra.Size = new Size(238, 27);
            txtKaynakAra.TabIndex = 7;
            txtKaynakAra.TextChanged += txtKaynakAra_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(35, 29);
            label12.Name = "label12";
            label12.Size = new Size(89, 19);
            label12.TabIndex = 6;
            label12.Text = "Kaynak Ara:";
            // 
            // lstTumKaynaklar
            // 
            lstTumKaynaklar.Font = new Font("Blinker", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lstTumKaynaklar.Location = new Point(35, 78);
            lstTumKaynaklar.MultiSelect = false;
            lstTumKaynaklar.Name = "lstTumKaynaklar";
            lstTumKaynaklar.ShowItemToolTips = true;
            lstTumKaynaklar.Size = new Size(891, 427);
            lstTumKaynaklar.TabIndex = 5;
            lstTumKaynaklar.UseCompatibleStateImageBehavior = false;
            // 
            // tabkynkEkle
            // 
            tabkynkEkle.BackColor = SystemColors.ButtonHighlight;
            tabkynkEkle.Controls.Add(numSourcePage);
            tabkynkEkle.Controls.Add(dpcPublicationDate);
            tabkynkEkle.Controls.Add(lblpublication);
            tabkynkEkle.Controls.Add(label15);
            tabkynkEkle.Controls.Add(txtSourceWriter);
            tabkynkEkle.Controls.Add(lblKaynakWriter);
            tabkynkEkle.Controls.Add(btnsourceKaydet);
            tabkynkEkle.Controls.Add(txtKaynakName);
            tabkynkEkle.Controls.Add(lblsourceName);
            tabkynkEkle.Location = new Point(4, 27);
            tabkynkEkle.Name = "tabkynkEkle";
            tabkynkEkle.Padding = new Padding(3);
            tabkynkEkle.Size = new Size(961, 553);
            tabkynkEkle.TabIndex = 6;
            tabkynkEkle.Text = "Ekle";
            // 
            // numSourcePage
            // 
            numSourcePage.Location = new Point(405, 219);
            numSourcePage.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSourcePage.Name = "numSourcePage";
            numSourcePage.Size = new Size(257, 27);
            numSourcePage.TabIndex = 9;
            // 
            // dpcPublicationDate
            // 
            dpcPublicationDate.Location = new Point(405, 258);
            dpcPublicationDate.Name = "dpcPublicationDate";
            dpcPublicationDate.Size = new Size(257, 27);
            dpcPublicationDate.TabIndex = 8;
            // 
            // lblpublication
            // 
            lblpublication.AutoSize = true;
            lblpublication.Location = new Point(225, 262);
            lblpublication.Name = "lblpublication";
            lblpublication.Size = new Size(129, 19);
            lblpublication.TabIndex = 7;
            lblpublication.Text = "Yayınlanma Tarihi:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(236, 221);
            label15.Name = "label15";
            label15.Size = new Size(118, 19);
            label15.TabIndex = 5;
            label15.Text = "Sayfa Numarası:";
            // 
            // txtSourceWriter
            // 
            txtSourceWriter.Location = new Point(405, 173);
            txtSourceWriter.Name = "txtSourceWriter";
            txtSourceWriter.Size = new Size(257, 27);
            txtSourceWriter.TabIndex = 4;
            // 
            // lblKaynakWriter
            // 
            lblKaynakWriter.AutoSize = true;
            lblKaynakWriter.Location = new Point(301, 176);
            lblKaynakWriter.Name = "lblKaynakWriter";
            lblKaynakWriter.Size = new Size(49, 19);
            lblKaynakWriter.TabIndex = 3;
            lblKaynakWriter.Text = "Yazar:";
            // 
            // btnsourceKaydet
            // 
            btnsourceKaydet.BackColor = Color.SteelBlue;
            btnsourceKaydet.FlatStyle = FlatStyle.Flat;
            btnsourceKaydet.ForeColor = SystemColors.ButtonHighlight;
            btnsourceKaydet.Location = new Point(502, 340);
            btnsourceKaydet.Name = "btnsourceKaydet";
            btnsourceKaydet.Size = new Size(160, 41);
            btnsourceKaydet.TabIndex = 2;
            btnsourceKaydet.Text = "KAYDET";
            btnsourceKaydet.UseVisualStyleBackColor = false;
            btnsourceKaydet.Click += btnsourceKaydet_Click;
            // 
            // txtKaynakName
            // 
            txtKaynakName.Location = new Point(405, 125);
            txtKaynakName.Name = "txtKaynakName";
            txtKaynakName.Size = new Size(257, 27);
            txtKaynakName.TabIndex = 1;
            // 
            // lblsourceName
            // 
            lblsourceName.AutoSize = true;
            lblsourceName.Location = new Point(266, 128);
            lblsourceName.Name = "lblsourceName";
            lblsourceName.Size = new Size(87, 19);
            lblsourceName.TabIndex = 0;
            lblsourceName.Text = "Kaynak Adı:";
            // 
            // tabkynkSil
            // 
            tabkynkSil.BackColor = SystemColors.ButtonHighlight;
            tabkynkSil.Controls.Add(btnKaynakYenile);
            tabkynkSil.Controls.Add(btnKaynakSil);
            tabkynkSil.Controls.Add(btnSourceExit);
            tabkynkSil.Controls.Add(txtKaynakAraSil);
            tabkynkSil.Controls.Add(lblKaynakAra);
            tabkynkSil.Controls.Add(lstKaynakSil);
            tabkynkSil.Location = new Point(4, 31);
            tabkynkSil.Name = "tabkynkSil";
            tabkynkSil.Padding = new Padding(3);
            tabkynkSil.Size = new Size(961, 549);
            tabkynkSil.TabIndex = 7;
            tabkynkSil.Text = "Sil";
            // 
            // btnKaynakYenile
            // 
            btnKaynakYenile.BackColor = Color.OliveDrab;
            btnKaynakYenile.FlatStyle = FlatStyle.Flat;
            btnKaynakYenile.ForeColor = SystemColors.ButtonFace;
            btnKaynakYenile.Location = new Point(649, 31);
            btnKaynakYenile.Name = "btnKaynakYenile";
            btnKaynakYenile.Size = new Size(108, 33);
            btnKaynakYenile.TabIndex = 15;
            btnKaynakYenile.Text = "YENİLE";
            btnKaynakYenile.UseVisualStyleBackColor = false;
            btnKaynakYenile.Click += btnKaynakYenile_Click;
            // 
            // btnKaynakSil
            // 
            btnKaynakSil.BackColor = Color.IndianRed;
            btnKaynakSil.FlatStyle = FlatStyle.Flat;
            btnKaynakSil.ForeColor = SystemColors.ButtonFace;
            btnKaynakSil.Location = new Point(418, 30);
            btnKaynakSil.Name = "btnKaynakSil";
            btnKaynakSil.Size = new Size(204, 33);
            btnKaynakSil.TabIndex = 14;
            btnKaynakSil.Text = "Seçilen Kaynağı Sil";
            btnKaynakSil.UseVisualStyleBackColor = false;
            btnKaynakSil.Click += btnKaynakSil_Click;
            // 
            // btnSourceExit
            // 
            btnSourceExit.BackColor = Color.IndianRed;
            btnSourceExit.FlatStyle = FlatStyle.Flat;
            btnSourceExit.ForeColor = SystemColors.ButtonFace;
            btnSourceExit.Location = new Point(850, 6);
            btnSourceExit.Name = "btnSourceExit";
            btnSourceExit.Size = new Size(108, 33);
            btnSourceExit.TabIndex = 13;
            btnSourceExit.Text = "ÇIKIŞ X";
            btnSourceExit.UseVisualStyleBackColor = false;
            btnSourceExit.Click += btnSourceExit_Click;
            // 
            // txtKaynakAraSil
            // 
            txtKaynakAraSil.Location = new Point(143, 31);
            txtKaynakAraSil.Name = "txtKaynakAraSil";
            txtKaynakAraSil.Size = new Size(238, 27);
            txtKaynakAraSil.TabIndex = 12;
            txtKaynakAraSil.TextChanged += txtKaynakAraSil_TextChanged;
            // 
            // lblKaynakAra
            // 
            lblKaynakAra.AutoSize = true;
            lblKaynakAra.BackColor = SystemColors.ButtonHighlight;
            lblKaynakAra.ForeColor = SystemColors.ActiveCaptionText;
            lblKaynakAra.Location = new Point(21, 34);
            lblKaynakAra.Name = "lblKaynakAra";
            lblKaynakAra.Size = new Size(89, 19);
            lblKaynakAra.TabIndex = 11;
            lblKaynakAra.Text = "Kaynak Ara:";
            // 
            // lstKaynakSil
            // 
            lstKaynakSil.Font = new Font("Blinker", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstKaynakSil.Location = new Point(21, 80);
            lstKaynakSil.MultiSelect = false;
            lstKaynakSil.Name = "lstKaynakSil";
            lstKaynakSil.ShowItemToolTips = true;
            lstKaynakSil.Size = new Size(923, 445);
            lstKaynakSil.TabIndex = 10;
            lstKaynakSil.UseCompatibleStateImageBehavior = false;
            // 
            // tabkynkGuncelle
            // 
            tabkynkGuncelle.BackColor = SystemColors.ButtonHighlight;
            tabkynkGuncelle.Controls.Add(dtpSourceGuncelle);
            tabkynkGuncelle.Controls.Add(numSourceGuncelle);
            tabkynkGuncelle.Controls.Add(lblguncelleYayinTarihi);
            tabkynkGuncelle.Controls.Add(txtKaynakGuncelYazar);
            tabkynkGuncelle.Controls.Add(lblKaynakGuncelleYazar);
            tabkynkGuncelle.Controls.Add(lblSayfaGuncelle);
            tabkynkGuncelle.Controls.Add(txtKaynakGuncelAd);
            tabkynkGuncelle.Controls.Add(lblKaynakGuncelleAd);
            tabkynkGuncelle.Controls.Add(button9);
            tabkynkGuncelle.Controls.Add(lstKaynakGuncelle);
            tabkynkGuncelle.Controls.Add(button10);
            tabkynkGuncelle.Location = new Point(4, 31);
            tabkynkGuncelle.Name = "tabkynkGuncelle";
            tabkynkGuncelle.Padding = new Padding(3);
            tabkynkGuncelle.Size = new Size(961, 549);
            tabkynkGuncelle.TabIndex = 8;
            tabkynkGuncelle.Text = "Güncelle";
            // 
            // dtpSourceGuncelle
            // 
            dtpSourceGuncelle.Location = new Point(707, 351);
            dtpSourceGuncelle.Name = "dtpSourceGuncelle";
            dtpSourceGuncelle.Size = new Size(204, 27);
            dtpSourceGuncelle.TabIndex = 28;
            // 
            // numSourceGuncelle
            // 
            numSourceGuncelle.Location = new Point(707, 302);
            numSourceGuncelle.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSourceGuncelle.Name = "numSourceGuncelle";
            numSourceGuncelle.Size = new Size(204, 27);
            numSourceGuncelle.TabIndex = 27;
            // 
            // lblguncelleYayinTarihi
            // 
            lblguncelleYayinTarihi.AutoSize = true;
            lblguncelleYayinTarihi.Location = new Point(511, 351);
            lblguncelleYayinTarihi.Name = "lblguncelleYayinTarihi";
            lblguncelleYayinTarihi.Size = new Size(129, 19);
            lblguncelleYayinTarihi.TabIndex = 26;
            lblguncelleYayinTarihi.Text = "Yayınlanma Tarihi:";
            // 
            // txtKaynakGuncelYazar
            // 
            txtKaynakGuncelYazar.Location = new Point(207, 348);
            txtKaynakGuncelYazar.Name = "txtKaynakGuncelYazar";
            txtKaynakGuncelYazar.Size = new Size(227, 27);
            txtKaynakGuncelYazar.TabIndex = 23;
            // 
            // lblKaynakGuncelleYazar
            // 
            lblKaynakGuncelleYazar.AutoSize = true;
            lblKaynakGuncelleYazar.Location = new Point(97, 351);
            lblKaynakGuncelleYazar.Name = "lblKaynakGuncelleYazar";
            lblKaynakGuncelleYazar.Size = new Size(49, 19);
            lblKaynakGuncelleYazar.TabIndex = 24;
            lblKaynakGuncelleYazar.Text = "Yazar:";
            // 
            // lblSayfaGuncelle
            // 
            lblSayfaGuncelle.AutoSize = true;
            lblSayfaGuncelle.Location = new Point(511, 310);
            lblSayfaGuncelle.Name = "lblSayfaGuncelle";
            lblSayfaGuncelle.Size = new Size(50, 19);
            lblSayfaGuncelle.TabIndex = 22;
            lblSayfaGuncelle.Text = "Sayfa:";
            // 
            // txtKaynakGuncelAd
            // 
            txtKaynakGuncelAd.Location = new Point(207, 304);
            txtKaynakGuncelAd.Name = "txtKaynakGuncelAd";
            txtKaynakGuncelAd.Size = new Size(227, 27);
            txtKaynakGuncelAd.TabIndex = 19;
            // 
            // lblKaynakGuncelleAd
            // 
            lblKaynakGuncelleAd.AutoSize = true;
            lblKaynakGuncelleAd.Location = new Point(97, 307);
            lblKaynakGuncelleAd.Name = "lblKaynakGuncelleAd";
            lblKaynakGuncelleAd.Size = new Size(87, 19);
            lblKaynakGuncelleAd.TabIndex = 20;
            lblKaynakGuncelleAd.Text = "Kaynak Adı:";
            // 
            // button9
            // 
            button9.BackColor = Color.OliveDrab;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(839, 10);
            button9.Name = "button9";
            button9.Size = new Size(108, 33);
            button9.TabIndex = 18;
            button9.Text = "YENİLE";
            button9.UseVisualStyleBackColor = false;
            // 
            // lstKaynakGuncelle
            // 
            lstKaynakGuncelle.Location = new Point(6, 49);
            lstKaynakGuncelle.Name = "lstKaynakGuncelle";
            lstKaynakGuncelle.Size = new Size(940, 221);
            lstKaynakGuncelle.TabIndex = 16;
            lstKaynakGuncelle.UseCompatibleStateImageBehavior = false;
            lstKaynakGuncelle.SelectedIndexChanged += lstKaynakGuncelle_SelectedIndexChanged;
            // 
            // button10
            // 
            button10.BackColor = Color.SteelBlue;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.WhiteSmoke;
            button10.Location = new Point(398, 439);
            button10.Name = "button10";
            button10.Size = new Size(151, 36);
            button10.TabIndex = 17;
            button10.Text = "GÜNCELLE";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // YoneticiPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(966, 589);
            Controls.Add(tabControl1);
            Font = new Font("Blinker", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "YoneticiPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Yönetici Paneli";
            Load += YoneticiPaneli_Load;
            tabControl1.ResumeLayout(false);
            tabKullanicilar.ResumeLayout(false);
            tabKullanicilar.PerformLayout();
            tabEkle.ResumeLayout(false);
            tabEkle.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabSil.ResumeLayout(false);
            tabSil.PerformLayout();
            tabGuncelle.ResumeLayout(false);
            tabGuncelle.PerformLayout();
            grpCinsiyetGuncelle.ResumeLayout(false);
            grpCinsiyetGuncelle.PerformLayout();
            grpIsAdminGuncelle.ResumeLayout(false);
            grpIsAdminGuncelle.PerformLayout();
            grpIsActiveGuncelle.ResumeLayout(false);
            grpIsActiveGuncelle.PerformLayout();
            tabOdunc.ResumeLayout(false);
            tabOdunc.PerformLayout();
            tabKaynaklar.ResumeLayout(false);
            tabKaynaklar.PerformLayout();
            tabkynkEkle.ResumeLayout(false);
            tabkynkEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSourcePage).EndInit();
            tabkynkSil.ResumeLayout(false);
            tabkynkSil.PerformLayout();
            tabkynkGuncelle.ResumeLayout(false);
            tabkynkGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSourceGuncelle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabKullanicilar;
        private TabPage tabEkle;
        private TabPage tabSil;
        private TabPage tabGuncelle;
        private TabPage tabOdunc;
        private TabPage tabKaynaklar;
        private TabPage tabkynkEkle;
        private TabPage tabkynkSil;
        private TabPage tabkynkGuncelle;
        private ListView userList;
        private TextBox txtara;
        private Label lblara;
        private Button button1;
        private TextBox txtposta;
        private Label lbleposta;
        private TextBox txttelefon;
        private Label lbltelefon;
        private TextBox txttckn;
        private Label lbltckn;
        private TextBox txtsoyadi;
        private Label lblsoyad;
        private GroupBox groupBox1;
        private RadioButton btnkadin;
        private RadioButton btnerkek;
        private Button btnkaydet;
        private TextBox txtadi;
        private Label txtad;
        private TextBox txtsifre2;
        private Label lblsifre2;
        private TextBox txtsifre1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnKullaniciSil;
        private Button button2;
        private TextBox txtaraSil;
        private Label label10;
        private ListView lstKullaniciSil;
        private Button button3;
        private Button button4;
        private TextBox txtguncelleTCKN;
        private Label lblguncellTckn;
        private TextBox txtGuncelleGsm;
        private Label lblGuncelleGsm;
        private TextBox txtGuncelleSoyad;
        private Label lblguncelleSoyad;
        private ListView lstGuncelleAll;
        private Button button5;
        private TextBox txtGuncelleAd;
        private Label lblguncelleAd;
        private GroupBox grpCinsiyetGuncelle;
        private RadioButton rdErkekGuncelle;
        private RadioButton rdKadinGuncelle;
        private GroupBox grpIsAdminGuncelle;
        private RadioButton rdIsadminHayirGuncelle;
        private RadioButton rdIsadminEvetGuncelle;
        private GroupBox grpIsActiveGuncelle;
        private RadioButton rdPasifGuncelle;
        private RadioButton rdAktifGuncelle;
        private TextBox txtParolaGuncelle;
        private Label lblParolaGuncelle;
        private TextBox txtMailGuncelle;
        private Label label11;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox txtKaynakAra;
        private Label label12;
        private ListView lstTumKaynaklar;
        private NumericUpDown numSourcePage;
        private DateTimePicker dpcPublicationDate;
        private Label lblpublication;
        private Label label15;
        private TextBox txtSourceWriter;
        private Label lblKaynakWriter;
        private Button btnsourceKaydet;
        private TextBox txtKaynakName;
        private Label lblsourceName;
        private Button btnKaynakYenile;
        private Button btnKaynakSil;
        private Button btnSourceExit;
        private TextBox txtKaynakAraSil;
        private Label lblKaynakAra;
        private ListView lstKaynakSil;
        private DateTimePicker dtpSourceGuncelle;
        private NumericUpDown numSourceGuncelle;
        private Label lblguncelleYayinTarihi;
        private TextBox txtKaynakGuncelYazar;
        private Label lblKaynakGuncelleYazar;
        private Label lblSayfaGuncelle;
        private TextBox txtKaynakGuncelAd;
        private Label lblKaynakGuncelleAd;
        private Button button9;
        private ListView lstKaynakGuncelle;
        private Button button10;
        private ListView lstyoneticiOducKitap;
        private Label lblodunckitapara;
        private TextBox txtOduncKitapAra;
        private Button button11;
    }
}