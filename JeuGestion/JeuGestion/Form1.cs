using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JeuGestion
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        int idAccount;

        public Form1()
        {
            InitializeComponent();
            this.connection = new MySqlConnection("DATABASE=jeu; SERVER=127.0.0.1; UID=root; PASSWORD=JGVCC4;");
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connecté.");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void Connexion(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Connected")
            {// WHERE user='" + textBoxUser.Text + "' AND password='" + textBoxPassword.Text + "'"
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM account WHERE user='" + textBoxUser.Text + "' AND password='" + textBoxPassword.Text + "'", this.connection);
                cmd.ExecuteNonQuery();
                using (MySqlDataReader accountRead = cmd.ExecuteReader())
                {
                    string user = "";
                    string password = "";
                    Boolean admin = false;
                    Boolean banned = false;
                    accountRead.Read();

                    idAccount = Int32.Parse(accountRead["id"].ToString());
                    user = accountRead["user"].ToString();
                    password = accountRead["password"].ToString();
                    admin = Boolean.Parse(accountRead["hyperAdmin"].ToString());
                    banned = Boolean.Parse(accountRead["banned"].ToString());

                    accountRead.Close();
                    if (user == textBoxUser.Text && password == textBoxPassword.Text)
                    {
                        if (admin)
                        {
                            Administrateur gestionAdmin = new Administrateur(connection);
                            gestionAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            Gestion gestion = new Gestion(connection, idAccount, admin);
                            gestion.Show();
                            this.Hide();


                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur et/ou mot de passe faux");
                    }

                }
            }
            else if (btnSubmit.Text == "Create Account")
            {
                if (textBoxUser.Text == "" || textBoxPassword.Text == "" || textBoxEmail.Text == "")
                {
                    MessageBox.Show("Veuillez tout compléter");
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO account (user,password,email) VALUES ('" + textBoxUser.Text + "','" + textBoxPassword.Text + "','" + textBoxEmail.Text + "')", this.connection);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                }
            }
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            if (btnCreateAccount.Text == "Create account")
            {
                label4.Visible = true;
                textBoxEmail.Visible = true;
                btnSubmit.Text = "Create Account";
                labelTitre.Text = "Create Account";
                btnCreateAccount.Text = "Connexion";
            }
            else if (btnCreateAccount.Text == "Connexion")
            {
                label4.Visible = false;
                textBoxEmail.Visible = false;
                btnSubmit.Text = "Connected";
                labelTitre.Text = "Connexion";
                btnCreateAccount.Text = "Create account";
            }
        }

        
    }
}
