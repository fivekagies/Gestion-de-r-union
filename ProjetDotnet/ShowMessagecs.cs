using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDotnet
{
    public partial class ShowMessagecs : Form
    {
        string nom;
        string prenom;
        string message;
        public ShowMessagecs()
        {
            InitializeComponent();
        }

        public ShowMessagecs(string nom, string prenom, string message)
        {
            InitializeComponent();
            this.nom = nom;
            this.prenom = prenom;
            this.message = message;

        }

        private void ShowMessagecs_Load(object sender, EventArgs e)
        {
            label1.Text = "Voila le message du " + nom + " " + prenom;
            label2.Text = message;
        }
    }
}
