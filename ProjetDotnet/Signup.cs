using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Globalization;

namespace ProjetDotnet
{
    public partial class Signup : Form
    {
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ensak\C#\Projet\v3\ProjetDotnetProblem\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        public Signup()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            Password.UseSystemPasswordChar = true;
            textBox1.UseSystemPasswordChar = true; 
        }

        private void inscrire_Click(object sender, EventArgs e)
        {

        }
        private string extension = null;
        private void Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            //openFileDialog1.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.* ";
            openFileDialog1.Filter = "Choose Picture(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Image = Image.FromFile(openFileDialog1.FileName);
                extension = openFileDialog1.FileName.Substring(openFileDialog1.FileName.IndexOf("."));
            }

        }
        private bool IsValidate()
        {

            int tel;
            bool isNumeric = int.TryParse(Tel.Text.Trim(), out tel);

            if (!isNumeric)

            {

                MetroMessageBox.Show(this, "le Numero de Telephone doit être une valeur numerique.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                Tel.Clear();
                Tel.Focus();

                return false;
            }
            return true;
        }

       

     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkHide_CheckedChanged(object sender, EventArgs e)
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

        private void inscrire_Click_1(object sender, EventArgs e)
        {
            if (NChef.Text == "" && Nom.Text == "" && Prenom.Text == "" && Mail.Text == "" && Tel.Text == "" && Password.Text == "" && Photo.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (Password.Text != textBox1.Text)
                {
                    MetroMessageBox.Show(this, "les mots de passe ne sont pas identiques! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {

                    try
                    {

                        connection.Open();
                        //String fname = NChef.Text + ".jpg";
                        String fname = NChef.Text + "" + extension;
                        string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                        String folder = startupPath + "\\ImagesChef\\";
                        String pathstring = System.IO.Path.Combine(folder, fname);
                        Image a = Photo.Image;
                        a.Save(pathstring);
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into [chef] (N_chef,Nom,Prenom,mail,tel,password,photo) values (" + int.Parse(NChef.Text) + ",'" + Nom.Text + "','" + Prenom.Text + "','" + Mail.Text + "','" + Tel.Text + "','" + Password.Text + "','" + fname + "')";

                        cmd.ExecuteNonQuery();
                        // MetroMessageBox.Show(this, "bien ", "succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Entete.Hide();
                        panel2.Hide();
                        connection.Close();
                        openchildForm(new AuthChef());
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MetroMessageBox.Show(this, "N_chef est un numéro qui est unique pour chaque chef ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                    catch (System.NullReferenceException)
                    {
                        MetroMessageBox.Show(this, "Information : Ajouter une  photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }

                }
            }

        }

        private void checkHide_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }

        }

        private void Tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void checkHide_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }

        }
        private bool IsValidatetele()
        {

            int tempnum;
            bool isNumeric = int.TryParse(Tel.Text.Trim(), out tempnum);



            if (!isNumeric)

            {
                MetroMessageBox.Show(this, "le numéro de téléphone est une valeur numérique !", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Tel.Clear();
                Tel.Focus();

                return false;
            }

            return true;
        }
        private void Tel_Leave_1(object sender, EventArgs e)
        {
            if (IsValidatetele())// Tester si Numeric
            {
                // Tester s'il correspond au pattern spécifié: nombre entre 0 et 9 et code (CNE) entre 8 et 10 Chiffres
                Regex pattern = new Regex("[0-9]{10}");
                if (pattern.IsMatch(Tel.Text))
                {
                  //ok
                }
                else
                {
                    MetroMessageBox.Show(this, "le numéro  de téléphone doit etre de 10 chiffre ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tel.Clear();
                    Tel.Focus();
                }
            }

        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

       

        private void Tel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Mail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(Mail.Text))
            {
                MetroMessageBox.Show(this, " la forme de Email est : xxxxx@nom.com ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mail.Clear();
                Mail.Focus();
            }
        }
      
        private void Password_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex( 
                          
             ".{8,}$");
            if (pattern.IsMatch(Password.Text))
                {
                    ////////////////ok
                }
                else
                {
                    MetroMessageBox.Show(this, "Information : le mot de passe doit etre contient au  minimum 8 caractère  ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Password.Clear();
                    Password.Focus();
                }
            }

        private void Tel_MarginChanged(object sender, EventArgs e)
        {

        }
    }
    }


