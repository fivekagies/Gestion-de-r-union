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
namespace ProjetDotnet
{
    public partial class aide : Form
    {

        public aide()
        {
            InitializeComponent();
            //textBox2.PasswordChar = true;
            label5.Hide(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            label5.Text = "*Un chef peut créer un compte ou s'authentifie \ns'il est déjà s'inscrie \n" +
                "*un chef peut créer une Réeunin  \n" +
                "*un chef peut attacher un compte rendu \n à une Réunion \n "+
                "*un chef peut inviter des membre , \n afficher les participants dans une Réunion\n" +
                "*un chef Reserve des materiaux \n et salle pour une Réunion ";
            label5.Show(); 

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label5.Text = "* un Membre peut créer un compte \n ou s'authentifie s'il est déjà s'inscrie \n" +
                
                "* Un Membre peut afficher ses Réunions   " +
                " \n peut accépter ou refuser une réunion \n " +
                "* un Membre peut attacher un compte rendu \n à une Reunion "
               ;
            label5.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label5.Text = "* cette tache de configuration est affectée \n à une Secritaire  \n" +

               "qui peut ajouter des matériaux , des salles\n  ou des équipes   " +
               " \n cette Secritaire peut afficher l'ensemble \n des réunions crée ou effectué \n ";
              
            label5.Show();

        }
    }
}

