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
    public partial class Administrateur : Form
    {
        MySqlConnection connection;

        public Administrateur(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.UpdateListeAdmin();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listViewAdmin_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem element = listViewAdmin.SelectedItems[0];
            int id = Int32.Parse(element.SubItems[0].Text);
            Gestion gestion = new Gestion(connection, id, true);
            gestion.Show();
        }

        private void UpdateListeAdmin()
        {
            listViewAdmin.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM account", connection);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string id = Lire["id"].ToString();
                    string user = Lire["user"].ToString();
                    string email = Lire["email"].ToString();
                    string banned = Lire["banned"].ToString();
                    string nbMonde = "0/5";
                    string nbPerso = "0/5";
                    listViewAdmin.Items.Add(new ListViewItem(new[] { id, user, email, nbPerso, nbMonde, banned }));
                }
                Lire.Close();
            }
        }
    }
}
