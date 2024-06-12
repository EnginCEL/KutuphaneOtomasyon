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

namespace KutuphaneOtomasyon.Login
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private List<ListViewItem> userOkuunanKitaplar = new List<ListViewItem>();

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            this.OduncAlinabilecekKitaplar();
            this.KullaniciOkunanTumKitaplar();
            this.KitapIadeList();


            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            var tckn = globaldegiskenler.LoginTCKN;
            string selectQuery = "SELECT NAME,SURNAME,GSM,TCKN,EMAIL,SEX FROM TBL_USERS WHERE TCKN=@p1";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@p1", tckn);
            connection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[0].ToString();
                txttckn.Text = dr[3].ToString();
                txtemail.Text = dr[4].ToString();
                txtGsm.Text = dr[2].ToString();
                if (dr[5].ToString() == "1")
                {
                    txtcinsiyet.Text = "KADIN";
                }
                else if (dr[5].ToString() == "0")
                {
                    txtcinsiyet.Text = "ERKEK";
                }
                else
                {
                    txtcinsiyet.Text = "TANIMSIZ";
                }


            }
            connection.Close();
        }

        public void OduncAlinabilecekKitaplar()
        {
            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            var tckn = globaldegiskenler.LoginTCKN;
            string selectQuery = "SELECT * FROM TBL_SOURCES WHERE ODUNCALINDIMI=0";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            DataTable dt = new DataTable();

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            connection.Close();
            DataRow newRow = dt.NewRow();

            ktpListCombo.DisplayMember = "NAME";
            ktpListCombo.ValueMember = "ID";
            ktpListCombo.DataSource = dt;


        }

        public void KitapIadeList()
        {
            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            var tckn = globaldegiskenler.LoginTCKN;
            string selectQuery = "SELECT * FROM SOURCE_USERS su INNER JOIN  TBL_SOURCES s on su.SOURCEID=s.ID WHERE s.ODUNCALINDIMI=1 and su.STATUS=0 AND USERID=@puserId";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@puserId", globaldegiskenler.UserID);
            DataTable dt = new DataTable();

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            connection.Close();
            DataRow newRow = dt.NewRow();

            cmbKitapIadeList.DisplayMember = "NAME";
            cmbKitapIadeList.ValueMember = "ID";
            cmbKitapIadeList.DataSource = dt;


        }
        string SourceID="";
        public void KullaniciOkunanTumKitaplar()
        {

            userOkunanKitaplarList.Clear();

            string connectionString = globaldegiskenler.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string selectQuery = "SELECT  su.RECEIVINGDATE, su.GIVINGBACKDATE,su.STATUS, u.NAME, u.SURNAME, s.NAME,s.WRITER,u.GSM,s.ID FROM SOURCE_USERS su INNER JOIN TBL_USERS u on su.USERID=u.ID INNER JOIN TBL_SOURCES s on su.SOURCEID=s.ID ORDER BY su.RECEIVINGDATE DESC";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            connection.Open();
            SqlDataReader dr = command.ExecuteReader();
            userOkunanKitaplarList.View = View.Details;
            userOkunanKitaplarList.FullRowSelect = true;
            userOkunanKitaplarList.GridLines = true;
            userOkunanKitaplarList.Columns.Add("KULLANICI", 120);
            userOkunanKitaplarList.Columns.Add("KITAP", 120);
            userOkunanKitaplarList.Columns.Add("YAZAR", 120);
            userOkunanKitaplarList.Columns.Add("GSM", 120);
            userOkunanKitaplarList.Columns.Add("ALIŞ TARİHİ", 120);
            userOkunanKitaplarList.Columns.Add("İADE TARİHİ", 120);
            userOkunanKitaplarList.Columns.Add("DURUM", 120);


            userOkuunanKitaplar.Clear();

            while (dr.Read())
            {

                ListViewItem item = new ListViewItem(dr[4].ToString() + " " + dr[3].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                item.SubItems.Add(dr[7].ToString());
                DateTime tarihalis = (DateTime)dr[0];
                DateTime tarihiade = (DateTime)dr[1];
                SourceID = dr[8].ToString();
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

                userOkunanKitaplarList.Items.Add(item);

                userOkuunanKitaplar.Add(item);
            }

            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtOkunanKitapAra_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtOkunanKitapAra.Text.ToLower();
            userOkunanKitaplarList.Items.Clear();

            foreach (ListViewItem item in userOkuunanKitaplar)
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
                    userOkunanKitaplarList.Items.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userOkunanKitaplarList.Clear();
            this.KullaniciOkunanTumKitaplar();
        }

        private void ktpListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ktpListCombo.SelectedItem != null)
            {


            }
        }

        private void btnOduncKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpAlisTarihi.Text) && !string.IsNullOrEmpty(dtpIadeTarihi.Text) && ktpListCombo.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string connectionString = globaldegiskenler.connectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                string selectQuery = "INSERT INTO SOURCE_USERS (USERID,SOURCEID,RECEIVINGDATE,GIVINGBACKDATE,STATUS) VALUES(@p1,@p2,@p3,@p4,@p5)";
                string updateQuery = "UPDATE TBL_SOURCES SET ODUNCALINDIMI=1 WHERE ID=@p1";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlCommand command_upd = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@p1", globaldegiskenler.UserID);
                command.Parameters.AddWithValue("@p2", ktpListCombo.SelectedValue);
                command.Parameters.AddWithValue("@p3", dtpAlisTarihi.Value);
                command.Parameters.AddWithValue("@p4", dtpIadeTarihi.Value);
                command.Parameters.AddWithValue("@p5", 0);
                command_upd.Parameters.AddWithValue("@p1", ktpListCombo.SelectedValue);
                connection.Open();
                int result = command.ExecuteNonQuery();
                int result_upd = command_upd.ExecuteNonQuery();
                connection.Close();
                if (result > 0 && result_upd > 0)
                {
                    MessageBox.Show("Kitap Ödünç İşlemi Başarıyla Yapılmıştır.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpIadeTarihi.Text = "";
                    dtpAlisTarihi.Text = "";
                    this.OduncAlinabilecekKitaplar();
                    this.KitapIadeList();
                    userOkunanKitaplarList.Clear();
                    this.KullaniciOkunanTumKitaplar();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbKitapIadeList.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string connectionString = globaldegiskenler.connectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                string updateQuery1 = "UPDATE TBL_SOURCES SET ODUNCALINDIMI=0 WHERE ID=@p1";
                string updateQuery2 = "UPDATE SOURCE_USERS SET STATUS=1 WHERE ID=@p2";


                SqlCommand command1 = new SqlCommand(updateQuery1, connection);
                SqlCommand command2 = new SqlCommand(updateQuery2, connection);
                command1.Parameters.AddWithValue("@p1", SourceID);
                command2.Parameters.AddWithValue("@p2", cmbKitapIadeList.SelectedValue);

                connection.Open();
                int result1 = command1.ExecuteNonQuery();
                int result2 = command2.ExecuteNonQuery();
                connection.Close();
                if (result1 > 0 && result2 > 0)
                {

                    MessageBox.Show("İşlem Başarıyla Yapılmıştır.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.KitapIadeList();
                    userOkunanKitaplarList.Clear();
                    this.KullaniciOkunanTumKitaplar();
                    this.OduncAlinabilecekKitaplar();

                }

            }
        }


    }
}

