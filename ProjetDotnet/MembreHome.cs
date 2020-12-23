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

namespace ProjetDotnet
{
    public partial class MembreHome : Form
    {
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int idUser;
        public MembreHome()
        {
            InitializeComponent();
            this.connection= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True"); 
            getNom();
            affichePhoto();

        }

        public MembreHome(int idUser)
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            this.idUser = idUser;
            getNom();
            affichePhoto();
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

            if (ReunionExist())
            {

                pictureBox2.Image = Image.FromFile(@"" + startupPath + "\\icons\\BellOn.PNG");
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@"" + startupPath + "\\icons\\BellOff.png");
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
        private void HomeMember_Load(object sender, EventArgs e)
        {

        }

        private void getNom()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Membre where N_M='" + idUser + " '";
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                label2.Text = "," + dr.GetString(1) + " " + dr.GetString(2);

            }
            connection.Close();
        }
        private void affichePhoto()
        {
            connection.Open();
            string photoName;
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Membre where N_M='" + idUser + "' ";
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                photoName = (string)dr["photo"];

            }
            connection.Close();



            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

            pictureBox1.Image = Image.FromFile(@"" + startupPath + "\\ImagesMembres\\" + photoName);


        }

        public bool ReunionExist()
        {
            bool result = false;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select COUNT(*) as nbr from Participant as P , Reunion as R where R.id_R like P.id_R  and etat IS NULL and P.N_M like '" + idUser + "'";

            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    label3.Text = "Vous avez répondu a toutes les invitation aux réunions";

                    if (int.Parse(dr["nbr"].ToString()) != 0)
                    {
                        label3.Text = "Vous avez " + dr["nbr"].ToString() + " reunion à ACCEPTER OU REFUSER ! ";
                        result = true;
                    }
                }

            }



            connection.Close();
            return result;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChoixduMembre cf = new ChoixduMembre(idUser);
            panel1.Hide(); 
            this.Font = null;
            cf.Show();
            openchildForm(cf);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void corps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            openchildForm(new AuthMembre());
            panel1.Hide(); 
        }

        private void corps_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
