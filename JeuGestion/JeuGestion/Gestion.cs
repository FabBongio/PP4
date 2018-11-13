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
    public partial class Gestion : Form
    {
        MySqlConnection connection;
        int idAccount;
        Boolean admin;

        //Initialisation
        public Gestion(MySqlConnection connection, int idAccount, Boolean admin)
        {
            InitializeComponent();
            this.connection = connection;
            this.idAccount = idAccount;
            this.UpdateListP();
            this.admin = admin;
        }

        //Dès qu'un form se ferme ça quitte tout 
        private void Gestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!admin)
            {
                Application.Exit();
            }
        }

        //Boutton pour créer un nouveau perso
        private void button_NewP_Click(object sender, EventArgs e)
        {
            if (listViewP.Items.Count < 5)
            {
                label_Name.Visible = true;
                label_Classe.Visible = true;
                textBox_Name.Visible = true;
                comboBox_Classe.Visible = true;
                button_CreateP.Visible = true;
            }
            else
            {
                MessageBox.Show("Vous ne pouvez plus créer de personnage");
            }
        }

        //Boutton pour valider la création du perso
        private void button_CreateP_Click(object sender, EventArgs e)
        {
            string classe = comboBox_Classe.Text;
            string name = textBox_Name.Text;
            int atk = -1;
            int dex = -1;
            int hp = -1;
            Boolean canCreate = false;

            switch (classe)
            {
                case "Guerrier":
                    hp = 120;
                    atk = 20;
                    dex = 7;
                    canCreate = true;
                    break;
                case "Archer":
                    hp = 80;
                    atk = 10;
                    dex = 15;
                    canCreate = true;
                    break;
                default:
                    MessageBox.Show("Vous devez choisir un nom et une classe");
                    break;
            }
            if (canCreate)
            {
                try
                {
                    MySqlCommand cmdCreateP = new MySqlCommand("INSERT INTO characters (name, classe, hp, atk, dex, idAccount) VALUES ('" + name + "', '" + classe + "', " + hp + ", " + atk + ", " + dex + ", " + idAccount + ")", connection);
                    cmdCreateP.ExecuteNonQuery();
                    this.UpdateListP();
                    MessageBox.Show("Personnage créé");
                    label_Name.Visible = false;
                    label_Classe.Visible = false;
                    textBox_Name.Visible = false;
                    comboBox_Classe.Visible = false;
                    button_CreateP.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Fonction pour update la liste des persos
        private void UpdateListP()
        {
            listViewP.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM characters where idAccount="+idAccount, connection);
            using (MySqlDataReader Lire = cmd.ExecuteReader())
            {
                while (Lire.Read())
                {
                    string nom = Lire["name"].ToString();
                    string classe = Lire["classe"].ToString();
                    string niveau = Lire["level"].ToString();
                    string hp = Lire["hp"].ToString();
                    string atk = Lire["atk"].ToString();
                    string dex = Lire["dex"].ToString();
                    listViewP.Items.Add(new ListViewItem(new[] { nom, classe, niveau, hp, atk, dex }));
                }
                Lire.Close();
            }
        }

        //Monter de 1 niveau le perso sélectionné dans la liste
        private void button_Level_Click(object sender, EventArgs e)
        {

            if (listViewP.SelectedItems.Count > 0)
            {
                int item = listViewP.Items.IndexOf(listViewP.SelectedItems[0]);
                ListViewItem element = listViewP.SelectedItems[0];
                string nom = element.SubItems[0].Text;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM characters WHERE name=@nom", connection);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.ExecuteNonQuery();
                //Récupérer le niveau, les hp, l'attaque et la dextérité et l'augmenter
                using (MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    Lire.Read();
                    int level = Int32.Parse(Lire["level"].ToString());
                    int hp = Int32.Parse(Lire["hp"].ToString());
                    int atk = Int32.Parse(Lire["atk"].ToString());
                    int dex = Int32.Parse(Lire["dex"].ToString());

                    level++;
                    hp += 10;
                    atk += 4;
                    dex += 2;

                    Lire.Dispose();
                    MySqlCommand cmdUpdate = new MySqlCommand("UPDATE characters SET level=" + level + ", hp=" + hp + ", atk=" + atk + ", dex=" + dex + "  WHERE name like '" + nom + "' and idAccount=" + idAccount, connection);
                    cmdUpdate.ExecuteNonQuery();

                }

                this.UpdateListP();
                //selectionner l'item
                
            }
        }

        //Boutton pour supprimer le perso sélectionné dans la liste
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listViewP.SelectedItems.Count > 0)
            {
                ListViewItem element = listViewP.SelectedItems[0];
                string name = element.SubItems[0].Text;
                MySqlCommand cmd = new MySqlCommand("DELETE FROM characters where name like @name", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();

            }
            this.UpdateListP();
        }
    }
}
