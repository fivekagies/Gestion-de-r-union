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
using System.IO;

namespace ProjetDotnet
{
    public partial class ChoixduMembre : Form
    {

        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gate\Desktop\projet\ProjetDotnet\ProjetDotnet\DatabaseGestionReunion.mdf;Integrated Security=True");
        string startupPath1 = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");

        SqlConnection connection;
        private int membre;
        private int rowNbr = -1;
        public ChoixduMembre()
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            //textBox2.PasswordChar = true;
        }
        public ChoixduMembre(int m)
        {
            InitializeComponent();
            this.connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + startupPath1 + "\\ProjetDotnet\\DatabaseGestionReunion.mdf;Integrated Security=True");

            this.membre = m;
            //textBox2.PasswordChar = true;
            label2.Hide();
            button1.Hide();
            richTextBox1.Hide();
            seeMembersBtn.Show();
            remplirDATA();
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
        static string addSlashes(string Input)
        {
           return System.Text.RegularExpressions.Regex.Replace(Input, @"[\000\010\011\012\015\032\042\047\134\140]", "\\$0");
        }

        private void remplirDATA()
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Participant as P , Reunion as R where R.id_R like P.id_R and P.N_M like '"+membre+"'";

            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                   
                    metroGrid1.Rows.Add(dr["id_R"].ToString(),(string)dr["sujet"], dr["date_debut"], (string)dr["heure"], (int)dr["N_chef"], (int)dr["N_salle"],dr["etat"].ToString(),dr["message"].ToString(), dr["compteRendu"].ToString());

                }
            
            }

            connection.Close();

        }
      
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    if (nbrReunion() > 0)
                    {
                        int selectedIndex = -1;
                        selectedIndex = metroGrid1.SelectedRows[0].Index;
                        int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Participant SET etat='accept' where id_R=" + idReunion + " and N_M=" + membre + " ";
                        /*ShowMember sm = new ShowMember(idUser, idReunion);
                        sm.Show();
                        Entete.Hide();
                        openchildForm(sm);*/
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        metroGrid1.Rows.Clear();
                        remplirDATA();

                        MessageBox.Show("vous avez accepter l'invitation à la reunion .", "participer à la reunion", MessageBoxButtons.OK);

                      
                    }
                    else
                    {
                        MessageBox.Show("aucune Reunion trouvee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refuseBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    if (nbrReunion() > 0)
                    {
                        int selectedIndex = -1;
                        selectedIndex = metroGrid1.SelectedRows[0].Index;
                        rowNbr = selectedIndex;
                        int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Participant SET etat='refuse' where id_R=" + idReunion + "and N_M=" + membre + " ";
                        /*ShowMember sm = new ShowMember(idUser, idReunion);
                        sm.Show();
                        Entete.Hide();
                        openchildForm(sm);*/
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        metroGrid1.Rows.Clear();
                        remplirDATA();

                        MessageBox.Show("vous avez refuser l'invitation à la reunion\nPensez à envoyer un message explicatif au chef.", "refuser à la reunion", MessageBoxButtons.OK);
                        label2.Show();
                        button1.Show();
                        richTextBox1.Show();
                    }
                    else
                    {
                        MessageBox.Show("aucune Reunion trouvee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rowNbr!=-1) metroGrid1.Rows[rowNbr].Selected = true;
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedIndex = -1;
                    selectedIndex = metroGrid1.SelectedRows[0].Index;
                    int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                    string reponse = metroGrid1.Rows[selectedIndex].Cells["Reponse"].Value.ToString();
                    string message = metroGrid1.Rows[selectedIndex].Cells["Message"].Value.ToString();
                    if ( String.IsNullOrEmpty(message))
                    {
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Participant SET message='"+richTextBox1.Text.Replace("'", @"\'") +"' where id_R=" + idReunion + " and N_M=" + membre + " ";
                        /*ShowMember sm = new ShowMember(idUser, idReunion);
                        sm.Show();
                        Entete.Hide();
                        openchildForm(sm);*/
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        metroGrid1.Rows.Clear();
                        remplirDATA();
                        MessageBox.Show("vous avez envoyer un message au chef.", "Envoie d'un message", MessageBoxButtons.OK);
                        label2.Hide();
                        button1.Hide();
                        richTextBox1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Un Message est deja envoyer au chef.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedIndex = -1;
                selectedIndex = metroGrid1.SelectedRows[0].Index;
                int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                string reponse = metroGrid1.Rows[selectedIndex].Cells["Reponse"].Value.ToString();
                string message = metroGrid1.Rows[selectedIndex].Cells["Message"].Value.ToString();
                if (reponse == "refuse")
                {
                    if (String.IsNullOrEmpty(message))
                    {
                        label2.Show();
                        button1.Show();
                        richTextBox1.Show();
                    }
                }
                else
                {
                    label2.Hide();
                    button1.Hide();
                    richTextBox1.Hide();
                }
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Pas de données Selectionné !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        
        private void seeMembersBtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    //if (metroGrid1.Rows.Count > 1)
                    if (nbrReunion()>0)
                    {
                        int selectedIndex = -1;
                        selectedIndex = metroGrid1.SelectedRows[0].Index;
                        int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                        this.Font = null;
                        AfficherParticipant sm = new AfficherParticipant(membre, idReunion);
                        openchildForm(sm);
                    }
                    else
                    {
                        MessageBox.Show("aucune Reunion trouvee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(this, "séléctionner une ligne!  ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("aucune Reunion selectionnee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int nbrReunion()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select COUNT(*) as nbr from Participant as P , Reunion as R where R.id_R like P.id_R and P.N_M like '" + membre + "'";
            int result=-1;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    
                       result = int.Parse(dr["nbr"].ToString());
                    
                }

            }



            connection.Close();
            return result;
        }

        

        private void precedentButton4_Click(object sender, EventArgs e)
        {
            openchildForm(new MembreHome(membre)); 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                int selectedIndex = -1;
                selectedIndex = metroGrid1.SelectedRows[0].Index;
                int idReunion = int.Parse(metroGrid1.Rows[selectedIndex].Cells["Id_R"].Value.ToString());
                string compteRendu = metroGrid1.Rows[selectedIndex].Cells["compteRendu"].Value.ToString();
                string sujetR = metroGrid1.Rows[selectedIndex].Cells["Sujet"].Value.ToString();
                if (String.IsNullOrEmpty(compteRendu))
                {
                    OpenFileDialog opf = new OpenFileDialog();
                    opf.Filter = "Choose File(*.pdf;*.docs;*.xls)|*.pdf;*.docs;*.xls ";
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        string strfile = opf.FileName;
                        //MessageBox.Show(strfile);
                        string extension = strfile.Substring(strfile.IndexOf("."));
                        string newName = sujetR + "_" + idReunion + "-" + membre + "" + extension;
                        string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "ProjetDotnet");
                        string newPathAndName = "" + startupPath + "\\files\\" + newName;
                        System.IO.File.Copy(strfile, newPathAndName);
                        //System.IO.IOException :ce file existe deja 
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        string localPath = @"files\" + newName;
                        cmd.CommandText = "UPDATE Reunion SET compteRendu='" + localPath + "' where Id_R=" + idReunion + " ";
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        metroGrid1.Rows.Clear();
                        remplirDATA();
                        MessageBox.Show("le compte rendu est ajoute avec succes .", "Ajouter compte rendu", MessageBoxButtons.OK);
                      //


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

        private void button3_Click(object sender, EventArgs e)
        {

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
                    System.Diagnostics.Process.Start(startupPath1 + "\\" + compteRendu);
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

