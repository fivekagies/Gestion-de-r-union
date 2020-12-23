using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace ProjetDotnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // customizeDisign();
            timer1.Start();
            label4.Hide();
            panel10.Hide(); 
        }
      /*  private void customizeDisign()
        {
            panelchef.Visible = false;
            panelMembre.Visible = false;
            paneladmin.Visible = false;

        }
        private void hideSubMenu()
        {
            if(panelchef.Visible == true)
                panelchef.Visible = false;
            if(panelMembre.Visible == true)
                panelMembre.Visible = false;
            if (paneladmin.Visible == true)
                paneladmin.Visible = false; 
           


        }*/

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                //hideSubMenu();
                //subMenu.Visible = true; 
            }
            else
            {
                subMenu.Visible = false; 
            }

        }
        private  Form activeForm = null; 
        public  void openchildForm(Form childForm)
        { 
            if(activeForm!=null)
            
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //hideSubMenu(); 
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           // hideSubMenu(); 
        }

        private void chef_Click(object sender, EventArgs e)
        {
            Entete.Hide();
            openchildForm(new AuthChef());
            label4.Show();
            panel10.Show();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Entete.Hide();
            openchildForm(new AuthMembre());
            label4.Show();
            panel10.Show();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
          //  showSubMenu(paneladmin);
        }

      

        private void metroButton1_Click(object sender, EventArgs e)
        {
           // hideSubMenu(); 
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logo.Hide();
            Thread.Sleep(200);
            logo.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click_1(object sender, EventArgs e)
        {
            Entete.Hide();
            openchildForm(new SecritaireAuth());
            label4.Show();
            panel10.Show();
        }

        private void panel6_Paint_2(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)

        {
            //corps.Hide(); 
           
            //hideSubMenu(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Entete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entete.Hide();

            openchildForm(new choixChef());
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            openchildForm(new aide()); 
        }
    }
}
