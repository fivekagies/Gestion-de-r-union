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
    public partial class Config : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v2\ProjetDotnet\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        public Config()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
            display_data_Equipe();
            display_data_Salle();
            display_data_Materiel();
            display_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Config_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'databaseGestionReunionDataSet7.chef'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chefTableAdapter.Fill(this.databaseGestionReunionDataSet7.chef);
            // TODO: cette ligne de code charge les données dans la table 'databaseGestionReunionDataSet7.chef'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chefTableAdapter.Fill(this.databaseGestionReunionDataSet7.chef);

        }
        private void display_data_Equipe()
        {

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Equipe]";

            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            metroGrid1.DataSource = dta;

            connection.Close();
        }
        private void display_data_Materiel()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Materiel]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            metroGrid3.DataSource = dta;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || nchef.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Equipe (Nom, N_chef) values ('" + name.Text + "', '" + nchef.Text + "') ";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data_Equipe();

            }
        }
        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {

                DataGridViewRow row = metroGrid1.Rows[SelectedRow];

                name.Text = row.Cells["Nom"].Value.ToString();
                nchef.Text = row.Cells["N_chef"].Value.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_equipe"].Value.ToString());

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Equipe] set Nom = '" + name.Text + "', N_chef = '" + nchef.Text + "' where Id_equipe like '" + rowID + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                display_data_Equipe();
                nchef.Text = "";
                name.Text = "";
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aucune equipe selectionné  .", "Error", MessageBoxButtons.OK);

            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid1.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_equipe"].Value.ToString());

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from [Equipe] where Id_equipe like '" + rowID + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                display_data_Equipe();

                nchef.Text = "";
                name.Text = "";
            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("Aucune equipe selectionné  .", "Error", MessageBoxButtons.OK);

            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("cette Equipe est pas vide   .", "Error", MessageBoxButtons.OK);

                connection.Close();
            }

        }
        private void display_data_Salle()
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [salle]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            metroGrid2.DataSource = dta;
            connection.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (metroTextNSalle.Text == "" || metroTextplace.Text == "" || metroTextsurface.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Salle values ('" + int.Parse(metroTextNSalle.Text) + "', '" + int.Parse(metroTextplace.Text) + "','" + metroTextsurface.Text + "') ";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    display_data_Salle();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MetroMessageBox.Show(this, "cette salle existe déjà!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();

                }
            }
        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid2.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid2.Rows[selectedIndex].Cells["N_salle"].Value.ToString());
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [salle] set N_salle = '" + int.Parse(metroTextNSalle.Text) + "', nbr_place = '" + int.Parse(metroTextplace.Text) + "',surface='" + metroTextsurface.Text + "' where N_salle like '" + rowID + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data_Salle();
                metroTextsurface.Text = "";
                metroTextplace.Text = "";
                metroTextNSalle.Text = "";
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aucune salle selectionné  .", "Error", MessageBoxButtons.OK);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid2.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid2.Rows[selectedIndex].Cells["N_salle"].Value.ToString());

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [salle] where N_salle like '" + rowID + "'";
                cmd.ExecuteNonQuery();

                connection.Close();
                display_data_Salle();
                metroTextsurface.Text = "";
                metroTextplace.Text = "";
                metroTextNSalle.Text = "";
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aucune salle selectionné  ", "Error", MessageBoxButtons.OK);


            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show(" cette salle est reservé pour une réunion ! ", "Error", MessageBoxButtons.OK);
                connection.Close();
            }
        }

        private void metroGrid2_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {

                DataGridViewRow row = metroGrid2.Rows[SelectedRow];

                metroTextNSalle.Text = row.Cells["N_salle"].Value.ToString();
                metroTextplace.Text = row.Cells["nbr_place"].Value.ToString();
                metroTextsurface.Text = row.Cells["surface "].Value.ToString();


            }
        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nameM.Text == "" || hz.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Materiel(Nom,frequence) values ('" + nameM.Text + "', '" + hz.Text + "')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    display_data_Materiel();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MetroMessageBox.Show(this, "ce  Matériel existe déjà!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();

                }
            }

        }

        private void metroGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {

                DataGridViewRow row = metroGrid3.Rows[SelectedRow];

                nameM.Text = row.Cells["Nom"].Value.ToString();
                hz.Text = row.Cells["frequence "].Value.ToString();


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid3.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid3.Rows[selectedIndex].Cells["Id_M"].Value.ToString());
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Materiel] set Nom = '" + nameM.Text + "', frequence = '" + hz.Text + "' where Id_M like '" + rowID + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data_Materiel();
                nameM.Text = "";
                hz.Text = "";

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aucun Matériel selectionné ! ", "Error", MessageBoxButtons.OK);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = metroGrid3.SelectedRows[0].Index;
                int rowID = int.Parse(metroGrid3.Rows[selectedIndex].Cells["Id_M"].Value.ToString());
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Materiel] where Id_M like '" + rowID + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                display_data_Materiel();
                nameM.Text = "";
                hz.Text = "";

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Aucun Matériel selectionné ! ", "Error", MessageBoxButtons.OK);

            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ce Matériel est Réservé  ! ", "Error", MessageBoxButtons.OK);
                connection.Close();
            }
        }

        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Reunion]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            grid.DataSource = dta;
            connection.Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Test sur le Nom
            if (search.Text == "Sujet")
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Reunion where sujet like'" + metroTextBox1.Text + "%'";

                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                grid.DataSource = dta;

                connection.Close();
            }
            //N_salle
            //Date
            if (search.Text == "N_chef")
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Reunion where N_chef like'" + metroTextBox1.Text + "%'";

                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                grid.DataSource = dta;

                connection.Close();
            }
            if (search.Text == "N_salle")
            {

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from Reunion where N_salle like'" + metroTextBox1.Text + "%'";

                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                grid.DataSource = dta;

                connection.Close();
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
        private void label6_Click(object sender, EventArgs e)
        {
            Entete.Hide();
            openchildForm(new SecritaireAuth()); 
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


