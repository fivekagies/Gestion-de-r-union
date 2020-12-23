namespace ProjetDotnet
{
    partial class AuthChef
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthChef));
            this.corps = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Entete = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.corps.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Entete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.White;
            this.corps.Controls.Add(this.panel4);
            this.corps.Controls.Add(this.Entete);
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.checkHide);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.nom);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 443);
            this.panel4.TabIndex = 64;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(475, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 443);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // checkHide
            // 
            this.checkHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.checkHide.Image = ((System.Drawing.Image)(resources.GetObject("checkHide.Image")));
            this.checkHide.Location = new System.Drawing.Point(395, 159);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(31, 27);
            this.checkHide.TabIndex = 26;
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged_2);
            this.checkHide.Click += new System.EventHandler(this.checkHide_CheckedChanged_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(187, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 34);
            this.button4.TabIndex = 25;
            this.button4.Text = "Valider";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(156, 159);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 27);
            this.password.TabIndex = 23;
            this.password.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.label10.Location = new System.Drawing.Point(284, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "S\'inscrire";
            this.label10.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Vous avez pas un compte ?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mot de passe";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(156, 100);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(233, 27);
            this.nom.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(40, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "N_chef";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(93, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(334, 41);
            this.label14.TabIndex = 22;
            this.label14.Text = "Authentification ";
            // 
            // Entete
            // 
            this.Entete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Entete.Controls.Add(this.panel10);
            this.Entete.Controls.Add(this.label4);
            this.Entete.Controls.Add(this.bunifuImageButton1);
            this.Entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entete.Location = new System.Drawing.Point(0, 0);
            this.Entete.Name = "Entete";
            this.Entete.Size = new System.Drawing.Size(673, 59);
            this.Entete.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel10.Location = new System.Drawing.Point(9, 42);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(64, 1);
            this.panel10.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Acceuil";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(436, -3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(234, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // AuthChef
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthChef";
            this.corps.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Entete.ResumeLayout(false);
            this.Entete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel corps;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel Entete;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

