using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetDotnet
{
    public partial class AfficherParticipant : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gate\Desktop\projet\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int idUser = 2000;
        private int idReunion = -1;
        public AfficherParticipant()
        {

            
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");
            fillGrid();
        }

        public AfficherParticipant(int idUser, int idReunion)
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            fillGrid();
            this.idUser = idUser;
            this.idReunion = idReunion;
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

     



        private void fillGrid()
        {
            connection.Open();


            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
         
            cmd1.CommandText = "select M.N_M,M.Nom,M.Prenom,M.mail,M.tel,M.photo from Membre as M,Participant as P WHERE " +
                " P.N_M=M.N_M and P.id_R='" + idReunion + "'";
            cmd1.ExecuteNonQuery();

            DataTable table = new DataTable();

            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                table.Columns.Add("Numero Membre");
                table.Columns.Add("Nom");
                table.Columns.Add("Prenom");

                table.Columns.Add("Mail");
                table.Columns.Add("Tel");



             

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                metroGrid1.Columns.Add(img);

                string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

                img.ImageLayout = DataGridViewImageCellLayout.Zoom;

                List<string> nameImages = new List<string>();





                Image image = null;



                while (reader.Read())
                {



                    DataRow row = table.NewRow();
                    row["Numero Membre"] = reader["N_M"].ToString();
                    row["Nom"] = reader["Nom"];
                    //textBox1.Text= reader["devisN"].ToString();
                    row["Prenom"] = reader["Prenom"];

                    row["Mail"] = reader["mail"];

                    row["Tel"] = reader["tel"];


                  
                    string nameImage = reader["photo"].ToString();
                    nameImages.Add(nameImage);



                    table.Rows.Add(row);


                }
                img.HeaderText = "Photo";
                img.Name = "Photo";


                metroGrid1.DataSource = table;
                int i;
                for (i = 0; i < nameImages.Count; i++)
                {
                    image = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + nameImages[i]);
                    metroGrid1.Rows[i].Cells["Photo"].Value = image;
                }
               metroGrid1.Rows[i].Cells["Photo"].Value = null;
                

            }
            connection.Close();
        }
        private void precedentButton4_Click(object sender, EventArgs e)
        {
            ChoixduMembre cf = new ChoixduMembre(idUser);
            cf.Show();
            //Entete.Hide();
            openchildForm(cf);
        }

        private void ShowParticipant_Load_1(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void precedentButton4_Click_1(object sender, EventArgs e)
        {
            ChoixduMembre cf = new ChoixduMembre(idUser);
            cf.Show();
            //Entete.Hide();
            openchildForm(cf);
        }

        private void AfficherParticipant_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
