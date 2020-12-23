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
    public partial class AuthMembre : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gate\Desktop\projet\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        public AuthMembre()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
            password.UseSystemPasswordChar = true;
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
                if (password.Text == "" && N_Membre.Text == "")
                {
                    MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Boolean test = false;
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select*from Membre";
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (N_Membre.Text == dr.GetInt32(0).ToString() && password.Text == dr.GetString(5))
                            {

                            //ChoixduMembre cf = new ChoixduMembre(dr.GetInt32(0));
                            MembreHome cf = new MembreHome(dr.GetInt32(0));
                               // Entete.Hide();
                               // panel4.Hide();
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
                        N_Membre.Text = "";
                    }
                }
            }

        private void label3_Click_1(object sender, EventArgs e)
        {
            //Entete.Hide();
            this.Font = null;
            openchildForm(new signupM());

        }

        private void label3_Click(object sender, EventArgs e)
        {

            //Entete.Hide();
            this.Font = null;
            openchildForm(new signupM());


        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
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
    }
    }


