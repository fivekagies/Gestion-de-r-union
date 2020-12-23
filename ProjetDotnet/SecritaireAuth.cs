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
    public partial class SecritaireAuth : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v2\ProjetDotnet\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        public SecritaireAuth()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
            pass.UseSystemPasswordChar = true;
        }

        private void corps_Paint(object sender, PaintEventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {

            if (pass.Text == "" && ns.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Boolean test = false;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*from Secritaire";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (ns.Text == dr.GetInt32(0).ToString() && pass.Text == dr.GetString(6))
                        {
                            Config cf = new Config();
                            // Entete.Hide();
                            panel1.Hide();
                            this.Font = null;
                            cf.Show();
                            openchildForm(cf);
                            test = true;
                            break;

                        }
                    }
                }
                connection.Close();
                if (!test)
                {
                    MetroMessageBox.Show(this, "mot de passe ou nom erroné ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pass.Text = "";
                    ns.Text = "";
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void ns_Click(object sender, EventArgs e)
        {

        }

      
        private void checkHide_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Font = null;
            panel1.Hide();
            panel2.Hide();
            label3.Hide();
            openchildForm(new SignUpSecretaire());
        }
    }
}

