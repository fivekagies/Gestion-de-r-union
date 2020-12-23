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
    public partial class choixChef : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v3\ProjetDotnetProblem\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int idUser;
        public choixChef()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            metroTabControl1.SelectTab(homeTabPage1);

            display_data();
            getNom();
            affichePhoto();
           
           
        }
        public choixChef(int idUser,string page="home")
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");
            
            this.idUser = idUser;
            if(page=="afficher") metroTabControl1.SelectTab(afficherTabPage3);
            else metroTabControl1.SelectTab(homeTabPage1);
            affichePhoto();
            display_data();
            getNom();
          


        }

        private void choixChef_Load(object sender, EventArgs e)
        {


            // TODO: cette ligne de code charge les données dans la table 'databaseGestionReunionDataSet.Reunion'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.reunionTableAdapter.Fill(this.databaseGestionReunionDataSet.Reunion);
            //showMembersBtn.Click -= showMembersBtn_Click;

        }
        private void  getNom()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from chef where N_chef='" + idUser + " '";
            using(SqlDataReader dr= cmd.ExecuteReader())
            {
                dr.Read(); 
                label9.Text = " ," + dr.GetString(1) + " " + dr.GetString(2);

            }
            connection.Close(); 
        }
        private void affichePhoto ()
        {
            connection.Open();
            string photoName; 
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from chef where N_chef='" + idUser + "' ";
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                photoName  = (string)dr["photo"]; 
              
            }
            connection.Close();


         
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

            pictureBox3.Image= Image.FromFile(@"" + startupPath + "\\ImagesChef\\" + photoName);
            

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
        private void showMembersBtn_Click_1(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                    ShowMember sm = new ShowMember(idUser, idReunion);
                    sm.Show();
                    Entete.Hide();
                    openchildForm(sm);
                }
                catch(System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "select * from Livre where etagereId="+id+" ";
            cmd.CommandText = "select * from Reunion where N_chef=" + idUser + " ";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            metroGrid1.DataSource = dta;
            //dataGridView1.DataSource = dta;
            metroGrid1.Show();

            connection.Close();
        }

        private void compteRenduBtn_Click(object sender, EventArgs e)
        {
            if(metroGrid1.SelectedRows.Count > 0)
            {
                int selectedIndex = -1;
                selectedIndex = metroGrid1.SelectedRows[0].Index;
                int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                string compteRendu = metroGrid1.Rows[selectedIndex].Cells["compteRendu"].Value.ToString();
                string sujetR = metroGrid1.Rows[selectedIndex].Cells["sujet"].Value.ToString();
                if (String.IsNullOrEmpty(compteRendu))
                {
                    OpenFileDialog opf = new OpenFileDialog();
                    opf.Filter = "Choose File(*.pdf;*.docs;*.xls)|*.pdf;*.docs;*.xls ";
                    if(opf.ShowDialog()== DialogResult.OK)
                    {
                        string strfile = opf.FileName;
                        //MessageBox.Show(strfile);
                        string extension = strfile.Substring(strfile.IndexOf("."));
                        string newName = sujetR + "_" + idReunion + "-" + idUser + "" + extension;
                        string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                        string newPathAndName = "" + startupPath + "\\files\\" + newName;
                        System.IO.File.Copy(strfile, newPathAndName);
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        string localPath = @"files\" + newName;
                        cmd.CommandText = "UPDATE Reunion SET compteRendu='" + localPath + "' where Id_R=" + idReunion + " ";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        display_data();

                        MessageBox.Show("le compte rendu est ajoute avec succes .", "Ajouter compte rendu", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("compte rendu existe deja pour cette reunion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Entete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

   

      
          
        private void homeTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void inviter_Click(object sender, EventArgs e)
        {
        }

        private void valider_Click_1(object sender, EventArgs e)
        {

            if (sujet.Text == "" || salle.Text == "" ||h.Text==""|| min.Text==""|| second.Text=="")
            {
                MessageBox.Show("Entrer le sujet et numéro de salle et l'heure  de la  Réunion ! ", "Attention ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string heure = h.Text +":"+ min.Text + ":"+second.Text; 
                cmd.CommandText = "insert into [Reunion] (sujet, date_debut,heure,N_chef,N_salle,compteRendu) values ('" + sujet.Text + "','" + debut.Text + "','" + heure  + "','" + idUser + "', '" + int.Parse(salle.Text) + "','"+null+"')";
                cmd.ExecuteNonQuery(); 
                connection.Close();
                MessageBox.Show("Votre Réunion est bien crée ", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            display_data();

        }

        private void choixChef_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'databaseGestionReunionDataSet.salle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.salleTableAdapter.Fill(this.databaseGestionReunionDataSet.salle);

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                    string date = metroGrid1.Rows[selectedIndex].Cells["date_debut"].Value.ToString();
                    InviterMembre sm = new InviterMembre(idUser, idReunion,date);
                    sm.Show();
                    Entete.Hide();
                    this.Font = null;
                    openchildForm(sm);
                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                    ReserverMateriel sm = new ReserverMateriel(idUser, idReunion);
                    sm.Show();
                    
                    Entete.Hide();
                    this.Font = null;
                    openchildForm(sm);
                }
                catch (System.NullReferenceException)
                {
                    MetroMessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void creerTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            display_data();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                int selectedIndex = -1;
                selectedIndex = metroGrid1.SelectedRows[0].Index;
                
                string compteRendu = metroGrid1.Rows[selectedIndex].Cells["compteRendu"].Value.ToString();
                
                if (!String.IsNullOrEmpty(compteRendu))
                {
                    System.Diagnostics.Process.Start(startupPath1+"\\"+compteRendu);
                }
                else
                {
                    MessageBox.Show("aucun compte rendu trouvé pour cette reunion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
       
    

