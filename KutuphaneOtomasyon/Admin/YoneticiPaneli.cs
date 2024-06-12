using KutuphaneOtomasyon.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyon.Admin
{
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                lstGuncelleAll.Clear();
                this.TumKullanicilariGetir();
            }

        }
        private List<ListViewItem> allUsers = new List<ListViewItem>();
        private List<ListViewItem> allKitapOdunc = new List<ListViewItem>();
        private List<ListViewItem> allUsersdelete = new List<ListViewItem>();
        private List<ListViewItem> allUsersGuncelle = new List<ListViewItem>();
        private List<ListViewItem> allSources = new List<ListViewItem>();
        private List<ListViewItem> allSourcesDelete = new List<ListViewItem>();
        private List<ListViewItem> allSourcesGuncelle = new List<ListViewItem>();

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            this.TumKullanicilariGetir();
            this.TumKaynaklariGetir();
            this.TumOducKitaplar();
        }

        public void TumKullanicilariGetir()
        {
            lstGuncelleAll.Clear();
            userList.Clear();
            lstKullaniciSil.Clear();

            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT NAME,SURNAME,GSM,TCKN,EMAIL,PASSWORD,SEX,ISADMIN,ISACTIVE FROM TBL_USERS WHERE ISACTIVE=1";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            userList.View = View.Details;
            userList.FullRowSelect = true;
            userList.GridLines = true;
            userList.Columns.Add("NAME", 170);
            userList.Columns.Add("SURNAME", 170);
            userList.Columns.Add("GSM", 150);
            userList.Columns.Add("TCKN", 150);
            userList.Columns.Add("EMAIL", 150);


            lstKullaniciSil.View = View.Details;
            lstKullaniciSil.FullRowSelect = true;
            lstKullaniciSil.GridLines = true;
            lstKullaniciSil.Columns.Add("NAME", 170);
            lstKullaniciSil.Columns.Add("SURNAME", 170);
            lstKullaniciSil.Columns.Add("GSM", 150);
            lstKullaniciSil.Columns.Add("TCKN", 150);
            lstKullaniciSil.Columns.Add("EMAIL", 150);


            lstGuncelleAll.View = View.Details;
            lstGuncelleAll.FullRowSelect = true;
            lstGuncelleAll.GridLines = true;
            lstGuncelleAll.Columns.Add("NAME", 170);
            lstGuncelleAll.Columns.Add("SURNAME", 170);
            lstGuncelleAll.Columns.Add("GSM", 150);
            lstGuncelleAll.Columns.Add("TCKN", 150);
            lstGuncelleAll.Columns.Add("PASSWORD", 150);
            lstGuncelleAll.Columns.Add("EMAIL", 150);



            allUsers.Clear();
            allUsersdelete.Clear();
            allUsersGuncelle.Clear();
            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr[1].ToString());
                item.SubItems.Add(dr[0].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                userList.Items.Add(item);

                allUsers.Add(item);

                ListViewItem item2 = new ListViewItem(dr[1].ToString());
                item2.SubItems.Add(dr[0].ToString());
                item2.SubItems.Add(dr[2].ToString());
                item2.SubItems.Add(dr[3].ToString());
                item2.SubItems.Add(dr[4].ToString());
                lstKullaniciSil.Items.Add(item2);


                allUsersdelete.Add(item);

                ListViewItem item3 = new ListViewItem(dr[1].ToString());
                item3.SubItems.Add(dr[0].ToString());
                item3.SubItems.Add(dr[2].ToString());
                item3.SubItems.Add(dr[3].ToString());
                item3.SubItems.Add(dr[5].ToString());
                item3.SubItems.Add(dr[4].ToString());
                item3.SubItems.Add(dr[6].ToString());
                item3.SubItems.Add(dr[7].ToString());
                item3.SubItems.Add(dr[8].ToString());
                lstGuncelleAll.Items.Add(item3);


                allUsersGuncelle.Add(item);

            }
            connection.Close();
        }

        public void TumOducKitaplar()
        {

            lstyoneticiOducKitap.Clear();

            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT su.RECEIVINGDATE,su.GIVINGBACKDATE, su.STATUS, u.NAME,u.SURNAME, u.TCKN, u.GSM, u.EMAIL, s.WRITER,s.NAME FROM SOURCE_USERS as su INNER JOIN TBL_USERS as u on su.USERID=u.ID INNER JOIN tbl_sources as s on s.ID=su.SOURCEID ORDER BY su.RECEIVINGDATE DESC";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            lstyoneticiOducKitap.View = View.Details;
            lstyoneticiOducKitap.FullRowSelect = true;
            lstyoneticiOducKitap.GridLines = true;
            lstyoneticiOducKitap.Columns.Add("KULLANICI", 120);
            lstyoneticiOducKitap.Columns.Add("E-MAIL", 150);
            //lstyoneticiOducKitap.Columns.Add("GSM", 170);
            lstyoneticiOducKitap.Columns.Add("KİTAP", 150);
            lstyoneticiOducKitap.Columns.Add("YAZAR", 150);
            lstyoneticiOducKitap.Columns.Add("ALIŞ TARİHİ", 100);
            lstyoneticiOducKitap.Columns.Add("İADE TARİHİ", 100);
            lstyoneticiOducKitap.Columns.Add("DURUMU", 130);

            allKitapOdunc.Clear();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr[4].ToString() + " " + dr[3].ToString());
                item.SubItems.Add(dr[7].ToString());
                //item.SubItems.Add(dr[6].ToString());
                item.SubItems.Add(dr[9].ToString());
                item.SubItems.Add(dr[8].ToString());
                DateTime tarihalis = (DateTime)dr[0];
                DateTime tarihiade = (DateTime)dr[1];

                item.SubItems.Add(tarihalis.ToString("dd/MM/yyyy"));
                item.SubItems.Add(tarihiade.ToString("dd/MM/yyyy"));

                if (dr[2].ToString() == "0")
                {
                    item.SubItems.Add("OKUNUYOR...");
                }
                else if (dr[2].ToString() == "1")
                {
                    item.SubItems.Add("TESLİM EDİLDİ...");

                }
                else
                {
                    item.SubItems.Add("BİLİNMİYOR...");
                }



                lstyoneticiOducKitap.Items.Add(item);

                allKitapOdunc.Add(item);
            }

            connection.Close();
        }

        //TODO
        //0 DEVAM EDİYOR
        //- 1 TESLİM EDİLDİ
        public void TumKaynaklariGetir()
        {
            lstKaynakGuncelle.Clear();
            lstTumKaynaklar.Clear();
            lstKaynakSil.Clear();
            lstGuncelleAll.Clear();
            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT ID,NAME,WRITER,NUMBEROFPAGES,TOTHEPUBLICATION FROM TBL_SOURCES ORDER BY NAME DESC";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            lstTumKaynaklar.View = View.Details;
            lstTumKaynaklar.FullRowSelect = true;
            lstTumKaynaklar.GridLines = true;
            lstTumKaynaklar.Columns.Add("ID", 50);
            lstTumKaynaklar.Columns.Add("NAME", 170);
            lstTumKaynaklar.Columns.Add("WRITER", 170);
            lstTumKaynaklar.Columns.Add("NUMBEROFPAGE", 150);
            lstTumKaynaklar.Columns.Add("TOTHEPUBLICATION", 150);

            allSources.Clear();

            lstKaynakSil.View = View.Details;
            lstKaynakSil.FullRowSelect = true;
            lstKaynakSil.GridLines = true;
            lstKaynakSil.Columns.Add("ID", 50);
            lstKaynakSil.Columns.Add("NAME", 170);
            lstKaynakSil.Columns.Add("WRITER", 170);
            lstKaynakSil.Columns.Add("NUMBEROFPAGE", 150);
            lstKaynakSil.Columns.Add("TOTHEPUBLICATION", 150);

            allSourcesDelete.Clear();


            lstKaynakGuncelle.View = View.Details;
            lstKaynakGuncelle.FullRowSelect = true;
            lstKaynakGuncelle.GridLines = true;
            lstKaynakGuncelle.Columns.Add("ID", 50);
            lstKaynakGuncelle.Columns.Add("NAME", 170);
            lstKaynakGuncelle.Columns.Add("WRITER", 170);
            lstKaynakGuncelle.Columns.Add("NUMBEROFPAGE", 150);
            lstKaynakGuncelle.Columns.Add("TOTHEPUBLICATION", 150);

            allSourcesGuncelle.Clear();



            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());

                lstTumKaynaklar.Items.Add(item);

                allSources.Add(item);

                ListViewItem item2 = new ListViewItem(dr[0].ToString());
                item2.SubItems.Add(dr[1].ToString());
                item2.SubItems.Add(dr[2].ToString());
                item2.SubItems.Add(dr[3].ToString());
                item2.SubItems.Add(dr[4].ToString());

                lstKaynakSil.Items.Add(item2);

                allSourcesDelete.Add(item2);


                ListViewItem item3 = new ListViewItem(dr[0].ToString());
                item3.SubItems.Add(dr[1].ToString());
                item3.SubItems.Add(dr[2].ToString());
                item3.SubItems.Add(dr[3].ToString());
                item3.SubItems.Add(dr[4].ToString());

                lstKaynakGuncelle.Items.Add(item3);
                allSourcesGuncelle.Add(item3);

            }
            connection.Close();
        }
        private void txtara_TextChanged(object sender, EventArgs e)
        {
 
            string searchText = txtara.Text.ToLower();
            userList.Items.Clear();

            foreach (ListViewItem item in allUsers)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    userList.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtadi.Text) && !string.IsNullOrEmpty(txtsoyadi.Text) && !string.IsNullOrEmpty(txtsifre1.Text) && !string.IsNullOrEmpty(txtsifre2.Text) && !string.IsNullOrEmpty(txttckn.Text) && !string.IsNullOrEmpty(txttelefon.Text) && !string.IsNullOrEmpty(txtposta.Text) && (btnerkek.Checked || btnkadin.Checked))
            {
                if (txtsifre1.Text != txtsifre2.Text)
                {
                    MessageBox.Show("Şifre ve Şifre Tekrarı Aynı Olmalı!");
                }
                else
                {
                    string connectionString = globaldegiskenler.connectionString;
                    SqlConnection connection = new SqlConnection(connectionString);

                    string selectQuery = "INSERT INTO  TBL_USERS (NAME,SURNAME,TCKN,GSM,SEX,ISADMIN,ISACTIVE,PASSWORD,EMAIL) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@p2", txtadi.Text);
                    command.Parameters.AddWithValue("@p1", txtsoyadi.Text);
                    command.Parameters.AddWithValue("@p8", txtsifre1.Text);
                    command.Parameters.AddWithValue("@p9", txtposta.Text);
                    command.Parameters.AddWithValue("@p4", txttckn.Text);
                    command.Parameters.AddWithValue("@p3", txttelefon.Text);
                    command.Parameters.AddWithValue("@p7", 1);

                    if (btnkadin.Checked)
                    {
                        command.Parameters.AddWithValue("@p5", 1);
                    }
                    else if (btnerkek.Checked)
                    {
                        command.Parameters.AddWithValue("@p5", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p5", -1);
                    }


                    command.Parameters.AddWithValue("@p6", 0);

                    connection.Open();
                    int sonuc = command.ExecuteNonQuery();
                    connection.Close();
                    if (sonuc > 0)
                    {
                        MessageBox.Show(txtadi.Text + " " + txtsoyadi.Text + "  " + "Başarıyla Eklendi.");
                        this.TumKullanicilariGetir();
                        txtadi.Text = "";
                        txtsoyadi.Text = "";
                        txtposta.Text = "";
                        txtsifre1.Text = "";
                        txtsifre2.Text = "";
                        txttckn.Text = "";
                        txttelefon.Text = "";
                        btnerkek.Checked = false;
                        btnkadin.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Oluşturulamadı. Tekrar Deneyiniz...");
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (lstKullaniciSil.SelectedItems.Count > 0)
            {

                string connectionString = globaldegiskenler.connectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                string deleteQuery = "DELETE TBL_USERS WHERE TCKN=@p1";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@p1", lstKullaniciSil.SelectedItems[0].SubItems[3].Text);

                DialogResult resultdialog = MessageBox.Show("Seçilen Kullanıcı Silmek İstiyor Musunuz?", "Kullanıcı Sil", MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Asterisk);
                if (resultdialog == DialogResult.Cancel)
                {
                    return;
                }
                connection.Open();

                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı Başarıyla Silindi", "SİL", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    this.TumKullanicilariGetir();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Silme Esnasında Bir Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Bir Eleman Seçiniz...");
            }
        }

        private void txtaraSil_TextChanged(object sender, EventArgs e)
        {


            string searchText = txtaraSil.Text.ToLower();
            lstKullaniciSil.Items.Clear();
            foreach (ListViewItem item2 in allUsersdelete)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item2.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    lstKullaniciSil.Items.Add((ListViewItem)item2.Clone());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TumKullanicilariGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if ((!string.IsNullOrEmpty(txtGuncelleAd.Text) && !string.IsNullOrEmpty(txtGuncelleSoyad.Text) && !string.IsNullOrEmpty(txtParolaGuncelle.Text) && !string.IsNullOrEmpty(txtguncelleTCKN.Text) && !string.IsNullOrEmpty(txtGuncelleGsm.Text) && !string.IsNullOrEmpty(txtMailGuncelle.Text) && (rdKadinGuncelle.Checked || rdErkekGuncelle.Checked) && (rdIsadminEvetGuncelle.Checked || rdIsadminHayirGuncelle.Checked) && (rdAktifGuncelle.Checked || rdPasifGuncelle.Checked)))
            {

                if (lstGuncelleAll.SelectedItems.Count > 0)
                {
                    string connectionString = globaldegiskenler.connectionString;
                    SqlConnection connection = new SqlConnection(connectionString);

                    string updateQuery = "UPDATE TBL_USERS SET SURNAME=@P1,NAME=@p2, GSM=@p3, TCKN=@p4, SEX=@p5, ISADMIN=@p6, ISACTIVE=@p7, PASSWORD=@p8, EMAIL=@p9 WHERE TCKN=@tckn";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@tckn", lstGuncelleAll.SelectedItems[0].SubItems[3].Text);
                    command.Parameters.AddWithValue("@p1", txtGuncelleAd.Text);
                    command.Parameters.AddWithValue("@p2", txtGuncelleSoyad.Text);
                    command.Parameters.AddWithValue("@p3", txtGuncelleGsm.Text);
                    command.Parameters.AddWithValue("@p4", txtguncelleTCKN.Text);
                    if (rdKadinGuncelle.Checked)
                    {
                        command.Parameters.AddWithValue("@p5", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p5", 0);
                    }


                    if (rdIsadminEvetGuncelle.Checked)
                    {
                        command.Parameters.AddWithValue("@p6", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p6", 0);
                    }

                    if (rdAktifGuncelle.Checked)
                    {
                        command.Parameters.AddWithValue("@p7", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@p7", 0);
                    }

                    command.Parameters.AddWithValue("@p8", txtParolaGuncelle.Text);
                    command.Parameters.AddWithValue("@p9", txtMailGuncelle.Text);


                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result > 0)
                    {
                        lstGuncelleAll.Clear();
                        this.TumKullanicilariGetir();


                        MessageBox.Show("Kayıt Başarıyla Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Esnasında Bir Hata Oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kullanıcı Seçiniz...");
                }
            }
            else
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz!");
            }
        }

        private void lstGuncelleAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGuncelleAll.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = lstGuncelleAll.SelectedItems[0];

                string ad = selectedItem.SubItems[0].Text;
                string soyad = selectedItem.SubItems[1].Text;
                string gsm = selectedItem.SubItems[2].Text;
                string tckn = selectedItem.SubItems[3].Text;
                string password = selectedItem.SubItems[4].Text;
                string email = selectedItem.SubItems[5].Text;
                string cinsiyet = selectedItem.SubItems[6].Text;
                string isadmin = selectedItem.SubItems[7].Text;
                string isactive = selectedItem.SubItems[8].Text;


                txtGuncelleAd.Text = ad;
                txtGuncelleSoyad.Text = soyad;
                txtguncelleTCKN.Text = tckn;
                txtGuncelleGsm.Text = gsm;
                txtParolaGuncelle.Text = password;
                txtMailGuncelle.Text = email;

                if (cinsiyet == "1")
                {
                    rdKadinGuncelle.Checked = true;
                    rdErkekGuncelle.Checked = false;

                }
                else
                {
                    rdKadinGuncelle.Checked = false;
                    rdErkekGuncelle.Checked = true;
                }

                if (isadmin == "1")
                {
                    rdIsadminEvetGuncelle.Checked = true;
                    rdIsadminHayirGuncelle.Checked = false;

                }
                else
                {
                    rdIsadminEvetGuncelle.Checked = false;
                    rdIsadminHayirGuncelle.Checked = true;
                }


                if (isactive == "1")
                {
                    rdAktifGuncelle.Checked = true;
                    rdPasifGuncelle.Checked = false;

                }
                else
                {
                    rdAktifGuncelle.Checked = false;
                    rdPasifGuncelle.Checked = true;
                }

            }
            if (lstGuncelleAll.SelectedItems.Count == 0)
            {
                txtGuncelleAd.Text = "";
                txtGuncelleSoyad.Text = "";
                txtGuncelleGsm.Text = "";
                txtMailGuncelle.Text = "";
                txtguncelleTCKN.Text = "";
                txtParolaGuncelle.Text = "";
                rdKadinGuncelle.Checked = false;
                rdErkekGuncelle.Checked = false;
                rdIsadminEvetGuncelle.Checked = false;
                rdIsadminHayirGuncelle.Checked = false;
                rdPasifGuncelle.Checked = false;
                rdAktifGuncelle.Checked = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstGuncelleAll.Clear();
            this.TumKullanicilariGetir();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lstTumKaynaklar.Clear();
            this.TumKaynaklariGetir();
        }

        private void txtKaynakAra_TextChanged(object sender, EventArgs e)
        {


            string searchText = txtKaynakAra.Text.ToLower();
            lstTumKaynaklar.Items.Clear();

            foreach (ListViewItem item in allSources)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    lstTumKaynaklar.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsourceKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSourceWriter.Text) && !string.IsNullOrEmpty(txtKaynakName.Text) && numSourcePage.Value > 0 && !string.IsNullOrEmpty(dpcPublicationDate.Text))
            {
                string connectionString = globaldegiskenler.connectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                string selectQuery = "INSERT INTO TBL_SOURCES (NAME,WRITER,NUMBEROFPAGES,TOTHEPUBLICATION) VALUES(@p1,@p2,@p3,@p4)";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@p2", txtSourceWriter.Text);
                command.Parameters.AddWithValue("@p1", txtKaynakName.Text);
                command.Parameters.AddWithValue("@p3", numSourcePage.Value);
                command.Parameters.AddWithValue("@p4", dpcPublicationDate.Value);

                connection.Open();
                int sonuc = command.ExecuteNonQuery();
                connection.Close();
                if (sonuc > 0)
                {
                    MessageBox.Show(txtKaynakName.Text + "  " + "Kaynağı Başarıyla Eklendi.");
                    this.TumKaynaklariGetir();
                    txtSourceWriter.Text = "";
                    txtKaynakName.Text = "";
                    numSourcePage.Value = 0;
                    dpcPublicationDate.Value = DateTime.Now;

                }
                else
                {
                    MessageBox.Show("Kayıt Oluşturulamadı. Tekrar Deneyiniz...");
                }
            }


            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz...");
            }
        }

        private void btnSourceExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaynakYenile_Click(object sender, EventArgs e)
        {
            lstKullaniciSil.Clear();
            this.TumKaynaklariGetir();
        }

        private void txtKaynakAraSil_TextChanged(object sender, EventArgs e)
        {


            string searchText = txtKaynakAraSil.Text.ToLower();
            lstKaynakSil.Items.Clear();

            foreach (ListViewItem item in allSourcesDelete)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    lstKaynakSil.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void btnKaynakSil_Click(object sender, EventArgs e)
        {
            if (lstKaynakSil.SelectedItems.Count > 0)
            {

                string connectionString = globaldegiskenler.connectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                string deleteQuery = "DELETE TBL_SOURCES WHERE ID=@p1";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@p1", lstKaynakSil.SelectedItems[0].SubItems[0].Text);

                DialogResult resultdialog = MessageBox.Show("Seçilen Kaynağı Silmek İstiyor Musunuz?", "Kaynak Sil", MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Asterisk);
                if (resultdialog == DialogResult.Cancel)
                {
                    return;
                }
                connection.Open();

                int result = command.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Kaynak Başarıyla Silindi", "SİL", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

                    this.TumKaynaklariGetir();
                }
                else
                {
                    MessageBox.Show("Kaynak Silme Esnasında Bir Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Bir Eleman Seçiniz...");
            }
        }

        private void lstKaynakGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKaynakGuncelle.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = lstKaynakGuncelle.SelectedItems[0];

                string ad = selectedItem.SubItems[1].Text;
                string soyad = selectedItem.SubItems[2].Text;
                string page = selectedItem.SubItems[3].Text;
                string tarih = selectedItem.SubItems[4].Text;



                txtKaynakGuncelAd.Text = ad;
                txtKaynakGuncelYazar.Text = soyad;
                dtpSourceGuncelle.Text = tarih;
                numSourceGuncelle.Value = Convert.ToDecimal(page);
            }

            if (lstKaynakGuncelle.SelectedItems.Count == 0)
            {
                txtKaynakGuncelAd.Text = "";
                txtKaynakGuncelYazar.Text = "";
                numSourceGuncelle.Value = 0;
                dtpSourceGuncelle.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtKaynakGuncelAd.Text) && !string.IsNullOrEmpty(txtKaynakGuncelYazar.Text) && numSourceGuncelle.Value > 0 && !string.IsNullOrEmpty(dtpSourceGuncelle.Text)))
            {

                if (lstKaynakGuncelle.SelectedItems.Count > 0)
                {
                    string connectionString = globaldegiskenler.connectionString;
                    SqlConnection connection = new SqlConnection(connectionString);

                    string updateQuery = "UPDATE TBL_SOURCES SET NAME=@P1,WRITER=@p2, NUMBEROFPAGES=@p3, TOTHEPUBLICATION=@p4 WHERE ID=@ID";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@ID", lstKaynakGuncelle.SelectedItems[0].SubItems[0].Text);
                    command.Parameters.AddWithValue("@p1", txtKaynakGuncelAd.Text);
                    command.Parameters.AddWithValue("@p2", txtKaynakGuncelYazar.Text);
                    command.Parameters.AddWithValue("@p3", numSourceGuncelle.Text);
                    command.Parameters.AddWithValue("@p4", Convert.ToDateTime(dtpSourceGuncelle.Text));

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result > 0)
                    {
                        lstKaynakGuncelle.Clear();
                        this.TumKaynaklariGetir();

                        MessageBox.Show("Kayıt Başarıyla Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Esnasında Bir Hata Oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kullanıcı Seçiniz...");
                }
            }
            else
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lstyoneticiOducKitap.Clear();
            this.TumOducKitaplar();
        }

        private void txtOduncKitapAra_TextChanged(object sender, EventArgs e)
        {

            string searchText = txtOduncKitapAra.Text.ToLower();
            lstyoneticiOducKitap.Items.Clear();

            foreach (ListViewItem item in allKitapOdunc)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                {
                    lstyoneticiOducKitap.Items.Add((ListViewItem)item.Clone());
                }
            }

        }
    }
}


