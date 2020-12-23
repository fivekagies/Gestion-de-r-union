namespace ProjetDotnet
{
    partial class signupM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupM));
            this.corps = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Entete = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.inscrire = new System.Windows.Forms.Button();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.equipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseGestionReunionDataSet6 = new ProjetDotnet.DatabaseGestionReunionDataSet6();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ConfirmerPass = new System.Windows.Forms.TextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.NM = new System.Windows.Forms.TextBox();
            this.equipeTableAdapter = new ProjetDotnet.DatabaseGestionReunionDataSet6TableAdapters.EquipeTableAdapter();
            this.corps.SuspendLayout();
            this.Entete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.Snow;
            this.corps.Controls.Add(this.checkBox1);
            this.corps.Controls.Add(this.panel2);
            this.corps.Controls.Add(this.Entete);
            this.corps.Controls.Add(this.inscrire);
            this.corps.Controls.Add(this.metroComboBox1);
            this.corps.Controls.Add(this.checkHide);
            this.corps.Controls.Add(this.label10);
            this.corps.Controls.Add(this.label9);
            this.corps.Controls.Add(this.ConfirmerPass);
            this.corps.Controls.Add(this.Photo);
            this.corps.Controls.Add(this.label8);
            this.corps.Controls.Add(this.label7);
            this.corps.Controls.Add(this.label5);
            this.corps.Controls.Add(this.label4);
            this.corps.Controls.Add(this.label3);
            this.corps.Controls.Add(this.label1);
            this.corps.Controls.Add(this.label2);
            this.corps.Controls.Add(this.Password);
            this.corps.Controls.Add(this.Tel);
            this.corps.Controls.Add(this.Mail);
            this.corps.Controls.Add(this.Prenom);
            this.corps.Controls.Add(this.Nom);
            this.corps.Controls.Add(this.NM);
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 0;
            this.corps.Paint += new System.Windows.Forms.PaintEventHandler(this.corps_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(365, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 23);
            this.checkBox1.TabIndex = 128;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(436, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 443);
            this.panel2.TabIndex = 127;
            // 
            // Entete
            // 
            this.Entete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Entete.Controls.Add(this.panel10);
            this.Entete.Controls.Add(this.label6);
            this.Entete.Controls.Add(this.bunifuImageButton1);
            this.Entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entete.Location = new System.Drawing.Point(0, 0);
            this.Entete.Name = "Entete";
            this.Entete.Size = new System.Drawing.Size(673, 59);
            this.Entete.TabIndex = 126;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel10.Location = new System.Drawing.Point(9, 42);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(64, 1);
            this.panel10.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Acceuil";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(436, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(234, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // inscrire
            // 
            this.inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.inscrire.FlatAppearance.BorderSize = 0;
            this.inscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscrire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscrire.ForeColor = System.Drawing.Color.White;
            this.inscrire.Location = new System.Drawing.Point(210, 439);
            this.inscrire.Margin = new System.Windows.Forms.Padding(2);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(130, 30);
            this.inscrire.TabIndex = 105;
            this.inscrire.Text = "S\'inscrire";
            this.inscrire.UseVisualStyleBackColor = false;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.equipeBindingSource;
            this.metroComboBox1.DisplayMember = "Id_equipe";
            this.metroComboBox1.DropDownHeight = 50;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.IntegralHeight = false;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(184, 320);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
            this.metroComboBox1.TabIndex = 124;
            this.metroComboBox1.UseSelectable = true;
            // 
            // equipeBindingSource
            // 
            this.equipeBindingSource.DataMember = "Equipe";
            this.equipeBindingSource.DataSource = this.databaseGestionReunionDataSet6;
            // 
            // databaseGestionReunionDataSet6
            // 
            this.databaseGestionReunionDataSet6.DataSetName = "DatabaseGestionReunionDataSet6";
            this.databaseGestionReunionDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkHide
            // 
            this.checkHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.checkHide.Image = ((System.Drawing.Image)(resources.GetObject("checkHide.Image")));
            this.checkHide.Location = new System.Drawing.Point(365, 247);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(29, 23);
            this.checkHide.TabIndex = 123;
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 122;
            this.label10.Text = "Equipe: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 42);
            this.label9.TabIndex = 121;
            this.label9.Text = "confirmer \r\nle mot de passe:\r\n";
            // 
            // ConfirmerPass
            // 
            this.ConfirmerPass.HideSelection = false;
            this.ConfirmerPass.Location = new System.Drawing.Point(184, 288);
            this.ConfirmerPass.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerPass.Name = "ConfirmerPass";
            this.ConfirmerPass.Size = new System.Drawing.Size(176, 27);
            this.ConfirmerPass.TabIndex = 120;
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.White;
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo.Location = new System.Drawing.Point(230, 353);
            this.Photo.Margin = new System.Windows.Forms.Padding(2);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(97, 63);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 118;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 119;
            this.label8.Text = "Photo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 117;
            this.label7.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 116;
            this.label5.Text = "Téléphone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 115;
            this.label4.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 114;
            this.label3.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 112;
            this.label2.Text = "N_Membre:";
            // 
            // Password
            // 
            this.Password.HideSelection = false;
            this.Password.Location = new System.Drawing.Point(184, 243);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(176, 27);
            this.Password.TabIndex = 111;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(184, 205);
            this.Tel.Margin = new System.Windows.Forms.Padding(2);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(176, 27);
            this.Tel.TabIndex = 110;
            this.Tel.TextChanged += new System.EventHandler(this.Tel_TextChanged);
            this.Tel.Leave += new System.EventHandler(this.Tel_Leave);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(184, 171);
            this.Mail.Margin = new System.Windows.Forms.Padding(2);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(176, 27);
            this.Mail.TabIndex = 109;
            this.Mail.Leave += new System.EventHandler(this.Mail_Leave);
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(184, 138);
            this.Prenom.Margin = new System.Windows.Forms.Padding(2);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(176, 27);
            this.Prenom.TabIndex = 108;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(184, 107);
            this.Nom.Margin = new System.Windows.Forms.Padding(2);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(176, 27);
            this.Nom.TabIndex = 107;
            // 
            // NM
            // 
            this.NM.Location = new System.Drawing.Point(184, 72);
            this.NM.Margin = new System.Windows.Forms.Padding(2);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(176, 27);
            this.NM.TabIndex = 106;
            // 
            // equipeTableAdapter
            // 
            this.equipeTableAdapter.ClearBeforeFill = true;
            // 
            // signupM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthChef";
            this.Load += new System.EventHandler(this.signupM_Load);
            this.corps.ResumeLayout(false);
            this.corps.PerformLayout();
            this.Entete.ResumeLayout(false);
            this.Entete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel corps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Entete;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button inscrire;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ConfirmerPass;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox NM;
        private DatabaseGestionReunionDataSet6 databaseGestionReunionDataSet6;
        private System.Windows.Forms.BindingSource equipeBindingSource;
        private DatabaseGestionReunionDataSet6TableAdapters.EquipeTableAdapter equipeTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

