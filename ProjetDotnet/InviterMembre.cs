using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MetroFramework;
namespace ProjetDotnet
{
    public partial class InviterMembre : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v3\ProjetDotnetProblem\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int N_chef;
        private int id_R;
        private string date;
        public InviterMembre(int N_chef, int id_R,string date="")

        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            remplirDATA();
            this.N_chef = N_chef;
            this.id_R = id_R;
            this.date = date;
            inviter.Hide();
            cancel.Hide();
            label2.Hide();
            // pictureBox2.Hide(); 

        }
        public InviterMembre()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");
            label2.Hide();
            remplirDATA();
           
        }
        private void remplirDATA()
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Membre";
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    string nomPhoto = dr["photo"].ToString();
                    Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                    dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);

                }
            }



            connection.Close();

        }

   
        private Boolean isparticipant(int N_m)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Participant where id_R like '"+id_R+"'";
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    if ((int)dr["N_M"] == N_m)
                    {
                        connection.Close();
                        return true;

                    }

                }
                connection.Close();
                return false;
            }
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
            this.Font = null;
            Entete.Hide();
            openchildForm(cf);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox2.Show(); 
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[SelectedRow];



                    MemoryStream ms = new MemoryStream();
                    Bitmap img = (Bitmap)row.Cells["photo"].Value;
                    img.Save(ms, ImageFormat.Jpeg);
                    pictureBox2.Image = Image.FromStream(ms);

                  
                    int nbr = int.Parse(row.Cells["N_Matricule"].Value.ToString());
                    if (!verifyMemberAvailability(N_chef,nbr, date))
                    {
                        label2.Hide();
                        if (isparticipant(nbr))
                        {
                            cancel.Show();
                            inviter.Hide();
                        }

                        else
                        {
                            inviter.Show();
                            cancel.Hide();
                        }
                    }
                    else
                    {
                        cancel.Hide();
                        inviter.Hide();
                        label2.Show();
                    }
                        




                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, " pas de donnée! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
           
            cancel.Hide();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int Nbr_M = int.Parse(dataGridView1.Rows[selectedIndex].Cells["N_Matricule"].Value.ToString());
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from [Participant] where id_R like '"+id_R+"' and  N_M like '"+Nbr_M+"'" ;
                    cmd.ExecuteNonQuery();
                    inviter.Show();
                    connection.Close();


                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Aucun Membre Sélectionné ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void inviter_Click(object sender, EventArgs e)
        {
            inviter.Hide();
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int Nbr_M = int.Parse(dataGridView1.Rows[selectedIndex].Cells["N_Matricule"].Value.ToString());
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Participant] (id_R,N_M) values ('" + id_R + "','" + Nbr_M + "')";
                    cmd.ExecuteNonQuery();
                    cancel.Show();
                    connection.Close(); 


                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Aucun Membre Sélectionné ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verifyMemberAvailability(int N_chef,int Nbr_M,string date)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Reunion as R,Participant as P where R.Id_R=P.Id_R and P.N_M="+Nbr_M+" and R.date_debut='"+date+"' and R.N_chef <>"+N_chef+" ";
            bool result = false;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    result = true;
                    break;
                }
            }



            connection.Close();
            return result;
        }
        private void corps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox1_Validated(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (metroComboBox1.Text == "Nom")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Membre] where Nom like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }
                connection.Close();
            }
            if (metroComboBox1.Text == "Prénom")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Membre] where Prenom like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }
                connection.Close();
            }
            if (metroComboBox1.Text == "Email")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Membre] where mail like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }
                connection.Close();
            }

            if (metroComboBox1.Text == "Téléphone")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Membre] where tel like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }//Nom Equipe
                connection.Close();
            }

            if (metroComboBox1.Text == "Nom Equipe")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select M.N_M,M.Nom,M.Prenom,M.mail,M.tel,M.photo,E.Nom from Equipe as E ,Membre as M WHERE " +
   "E.Id_equipe=M.id_equipe and E.Nom like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }
                connection.Close();
            }
            if (metroComboBox1.Text == "N_Matricule")
            {

                dataGridView1.Rows.Clear();
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Membre] where N_M like'" + metroTextBox1.Text + "%'";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                    while (dr.Read())
                    {
                        string nomPhoto = (string)dr["photo"];
                        Image img = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nomPhoto);
                        dataGridView1.Rows.Add((string)dr["Nom"], img, dr["N_M"], (string)dr["mail"], (string)dr["tel"], (string)dr["Prenom"]);
                    }
                }
                connection.Close();
            }



        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
