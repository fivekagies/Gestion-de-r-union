using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using System.IO;

namespace ProjetDotnet
{
    public partial class ReserverMateriel : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v3\ProjetDotnetProblem\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int N_chef;
        private int id_R;
        public ReserverMateriel()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
            config.Hide();
            config2.Hide();
            config2.Hide();
            metroGrid1.Hide();
        }
        public ReserverMateriel(int N_chef, int id_R)
        {
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            this.N_chef = N_chef;
            this.id_R = id_R;
            InitializeComponent();
            //textBox2.PasswordChar = true;
            config.Hide();
            config2.Hide();
            metroGrid1.Hide();
        }





        /* 
          private int nombreMateriel(string Nom)
          {

              int nbr = 0;
              connection.Open();
              SqlCommand cmd = connection.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select * from Materiel where Nom like '" + metroComboBox2.Text + "'";
              using (SqlDataReader dr = cmd.ExecuteReader())
              {
                  while (dr.Read())
                  {
                      nbr += 1;
                  }
            }
              connection.Close();
              return nbr;
          }
          */




        private void ReserverMateriel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'databaseGestionReunionDataSet5.Materiel'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.materielTableAdapter.Fill(this.databaseGestionReunionDataSet5.Materiel);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int M = int.Parse(metroGrid1.Rows[selectedIndex].Cells["code"].Value.ToString());
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into [reserveMateriel] (Id_M,id_R) values ('" + M + "','" + id_R + "')";

                    cmd.ExecuteNonQuery();
                    //Mise à jour 
                    MiseApresReservation();
                    MetroMessageBox.Show(this, "le Matériel est Réservé  ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();


                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Aucun Matériel Sélectionné ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            metroGrid1.Show();
            label3.Text = "La liste des matériaux réservés pour votre Réunion : ";
            metroGrid1.Rows.Clear();
            connection.Open();
            config.Hide();
            config2.Show();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from  Materiel as M ,reserveMateriel as MR  where id_R like '" + id_R + "' and  M.Id_M like MR.Id_M";

            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {

                    metroGrid1.Rows.Add((string)dr["Nom"], dr["Id_M"]);

                }
            }
            connection.Close();
        }
        private void MiseApresReservation()
        {


            metroGrid1.Show();
            label3.Text = "Les matériaux Disponible: ";
            metroGrid1.Rows.Clear();
            config.Show();
            config2.Hide();
           // connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Materiel ";
            List<int> tab = new List<int>();
            tab = materielReserve();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    Boolean test = false;
                    for (int i = 0; i < tab.Count(); i++)
                    {
                        if (tab[i] == (int)dr["Id_M"])
                        {
                            test = true;
                            break;
                        }

                    }
                    if (test == false)
                    {
                        metroGrid1.Rows.Add((string)dr["Nom"], dr["Id_M"]);



                    }

                }
              //  connection.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            metroGrid1.Show();
            label3.Text = "Les matériaux Disponible: ";
            metroGrid1.Rows.Clear();
            config.Show();
            config2.Hide();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Materiel ";
            List<int> tab = new List<int>();
            tab = materielReserve();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    Boolean test = false;
                    for (int i = 0; i < tab.Count(); i++)
                    {
                        if (tab[i] == (int)dr["Id_M"])
                        {
                            test = true;
                            break;
                        }

                    }
                    if (test == false)
                    {
                        metroGrid1.Rows.Add((string)dr["Nom"], dr["Id_M"]);



                    }

                }
                connection.Close();
            }
        }
        private void apresSupprission()
        {
            metroGrid1.Show();
            label3.Text = "La liste des matériaux réservés pour votre Réunion : ";
            metroGrid1.Rows.Clear();
          //  connection.Open();
            config.Hide();
            config2.Show();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from  Materiel as M ,reserveMateriel as MR  where id_R like '" + id_R + "' and  M.Id_M like MR.Id_M";

            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {

                    metroGrid1.Rows.Add((string)dr["Nom"], dr["Id_M"]);

                }
            }
          //  connection.Close();
        }
        private List<int> materielReserve()
        {
            List<int> tab = new List<int>();
            //      connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from reserveMateriel ";
            using (SqlDataReader dr = cmd.ExecuteReader())
            {


                while (dr.Read())
                {
                    tab.Add((int)dr["Id_M"]);

                }



            }

            //connection.Close();

            return tab;

        }
        private Form activeForm = null;
        public void openchildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            corps.Controls.Add(childForm);
            corps.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void precedentButton4_Click(object sender, EventArgs e)
        {
            choixChef cf = new choixChef(N_chef);
            cf.Show();
            Entete.Hide();
            this.Font = null;
            openchildForm(cf);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int M = int.Parse(metroGrid1.Rows[selectedIndex].Cells["code"].Value.ToString());
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from reserveMateriel where Id_M like '" + M + "'";

                    cmd.ExecuteNonQuery();
                    //
                    apresSupprission();
                    MetroMessageBox.Show(this, "vous avez libéré la réservation du matériel  ", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();


                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Aucun Matériel Sélectionné ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void corps_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  
  
}


