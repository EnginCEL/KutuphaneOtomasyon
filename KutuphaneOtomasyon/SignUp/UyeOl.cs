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

namespace KutuphaneOtomasyon.SignUp
{
    public partial class frmUyeOl : Form
    {
        public frmUyeOl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            loginForm loginForm = new loginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnUyeOlKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUyeOlAd.Text) && !string.IsNullOrEmpty(txtUyeOlSoyad.Text) && !string.IsNullOrEmpty(txtUyeOlPassword.Text) && !string.IsNullOrEmpty(txtUyeOlPassword2.Text) && !string.IsNullOrEmpty(txtUyeOlTCKN.Text) && !string.IsNullOrEmpty(txtUyeOlGsm.Text) && !string.IsNullOrEmpty(txtUyeOlEmail.Text) && (rdErkekEkle.Checked || rdKadinEkle.Checked) && (rdIsadminEvetEkle.Checked || rdIsadminHayirEkle.Checked) && (rdAktifEkle.Checked || rdPasifEkle.Checked))
            {
                if (txtUyeOlPassword.Text != txtUyeOlPassword2.Text)
                {
                    MessageBox.Show("Şifre ve Şifre Tekrarı Aynı Olmalı!");
                }
                else
                {
                    string connectionString = globaldegiskenler.connectionString;
                    SqlConnection connection = new SqlConnection(connectionString);

                    string selectQuery = "INSERT INTO  TBL_USERS (NAME,SURNAME,TCKN,GSM,SEX,ISADMIN,ISACTIVE,PASSWORD,EMAIL) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@p2", txtUyeOlAd.Text);
                    command.Parameters.AddWithValue("@p1", txtUyeOlSoyad.Text);
                    command.Parameters.AddWithValue("@p8", txtUyeOlPassword.Text);
                    command.Parameters.AddWithValue("@p9", txtUyeOlEmail.Text);
                    command.Parameters.AddWithValue("@p4", txtUyeOlTCKN.Text);
                    command.Parameters.AddWithValue("@p3", txtUyeOlGsm.Text);
                    command.Parameters.AddWithValue("@p7", 1);

                    if (rdKadinEkle.Checked)
                    {
                        command.Parameters.AddWithValue("@p5", 1);
                    }
                    else if (rdErkekEkle.Checked)
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
                        MessageBox.Show(txtUyeOlAd.Text + " " + txtUyeOlSoyad.Text + "  " + "Başarıyla Eklendi.");

                        txtUyeOlAd.Text = "";
                        txtUyeOlSoyad.Text = "";
                        txtUyeOlEmail.Text = "";
                        txtUyeOlPassword.Text = "";
                        txtUyeOlPassword2.Text = "";
                        txtUyeOlTCKN.Text = "";
                        txtUyeOlGsm.Text = "";
                        rdErkekEkle.Checked = false;
                        rdKadinEkle.Checked = false;
                        rdIsadminEvetEkle.Checked = false;
                        rdIsadminHayirEkle.Checked = false;
                        rdAktifEkle.Checked = false;
                        rdPasifEkle.Checked = false;
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
    }
}

