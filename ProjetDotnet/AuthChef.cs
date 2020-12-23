using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework; 
using System.Data.SqlClient;
using System.IO;

namespace ProjetDotnet
{
    public partial class AuthChef : Form
    {
       
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v3\ProjetDotnetProblem\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        //private int idUser = -1;
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        public AuthChef()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "" && nom.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Boolean test = false;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*from chef";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (nom.Text == dr.GetInt32(0).ToString() && password.Text == dr.GetString(5))
                        {
                            choixChef cf= new choixChef(dr.GetInt32(0));
                            Entete.Hide();
                            panel4.Hide();
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
                    password.Text = "";
                    nom.Text = "";
                }
            }
        }
       /*private Form activeForm = null;
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
            pictureBox2.Hide(); 
           }*/

        private void checkHide_CheckedChanged_1(object sender, EventArgs e)
        {

        
        }

        private void corps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Entete.Hide();
            this.Font = null;
            openchildForm(new Signup());

        }

        private void checkHide_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

