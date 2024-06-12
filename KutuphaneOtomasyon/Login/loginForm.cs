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
using KutuphaneOtomasyon.Admin;
using KutuphaneOtomasyon.Login;
using KutuphaneOtomasyon.SignUp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyon.User
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = yntcusername.Text;
            string password = yntcpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve/veya Şifre Boş Olmamalı!!!");
                return;
            }


            string connectionString = globaldegiskenler.connectionString;
            var selectQuery = "SELECT * FROM TBL_USERS WHERE EMAIL=@p1 and PASSWORD=@p2 and ISADMIN=1";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataReader dr;
                    command.Parameters.AddWithValue("@p1", username);
                    command.Parameters.AddWithValue("@p2", password);

                    connection.Open();
                    dr = command.ExecuteReader();


                    if (dr.HasRows)
                    {
                        dr.Read();
                        globaldegiskenler.LoginTCKN = dr[4].ToString();
                        globaldegiskenler.UserID = dr[0].ToString();
                        YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                        this.Hide();
                        yoneticiPaneli.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve/veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);

            }

        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve/veya Şifre Boş Olmamalı!!!");
                return;
            }


            string connectionString = globaldegiskenler.connectionString;
            var selectQuery = "SELECT * FROM TBL_USERS WHERE EMAIL=@p1 and PASSWORD=@p2";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    SqlDataReader dr;
                    command.Parameters.AddWithValue("@p1", username);
                    command.Parameters.AddWithValue("@p2", password);

                    connection.Open();
                    dr = command.ExecuteReader();


                    if (dr.HasRows)
                    {
                        dr.Read();
                        globaldegiskenler.LoginTCKN = dr[4].ToString();
                        globaldegiskenler.UserID = dr[0].ToString();
                        frmKullanici frmKullanici = new frmKullanici();
                        this.Hide();
                        frmKullanici.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve/veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }



        private void lblUyelik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmUyeOl frmUyeOl= new frmUyeOl();
            this.Hide();
            frmUyeOl.Show();

        }
    }
}
