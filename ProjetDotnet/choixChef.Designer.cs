namespace ProjetDotnet
{
    partial class choixChef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choixChef));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.corps = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.homeTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creerTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.ComboBox();
            this.second = new System.Windows.Forms.ComboBox();
            this.h = new System.Windows.Forms.ComboBox();
            this.valider = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.debut = new System.Windows.Forms.DateTimePicker();
            this.salle = new System.Windows.Forms.ComboBox();
            this.salleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseGestionReunionDataSet = new ProjetDotnet.DatabaseGestionReunionDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.sujet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.afficherTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showMembersBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.compteRenduBtn = new System.Windows.Forms.Button();
            this.Entete = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.salleTableAdapter = new ProjetDotnet.DatabaseGestionReunionDataSetTableAdapters.salleTableAdapter();
            this.corps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.homeTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.creerTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.afficherTabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.Entete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.White;
            this.corps.Controls.Add(this.panel1);
            this.corps.Controls.Add(this.Entete);
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 443);
            this.panel1.TabIndex = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.homeTabPage1);
            this.metroTabControl1.Controls.Add(this.creerTabPage2);
            this.metroTabControl1.Controls.Add(this.afficherTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(673, 443);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // homeTabPage1
            // 
            this.homeTabPage1.Controls.Add(this.pictureBox1);
            this.homeTabPage1.HorizontalScrollbarBarColor = true;
            this.homeTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTabPage1.HorizontalScrollbarSize = 10;
            this.homeTabPage1.Location = new System.Drawing.Point(4, 38);
            this.homeTabPage1.Name = "homeTabPage1";
            this.homeTabPage1.Size = new System.Drawing.Size(665, 401);
            this.homeTabPage1.TabIndex = 0;
            this.homeTabPage1.Text = "Home";
            this.homeTabPage1.VerticalScrollbarBarColor = true;
            this.homeTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.homeTabPage1.VerticalScrollbarSize = 10;
            this.homeTabPage1.Click += new System.EventHandler(this.homeTabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // creerTabPage2
            // 
            this.creerTabPage2.BackColor = System.Drawing.Color.Snow;
            this.creerTabPage2.Controls.Add(this.panel3);
            this.creerTabPage2.Controls.Add(this.pictureBox3);
            this.creerTabPage2.Controls.Add(this.label9);
            this.creerTabPage2.Controls.Add(this.label7);
            this.creerTabPage2.HorizontalScrollbarBarColor = true;
            this.creerTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.creerTabPage2.HorizontalScrollbarSize = 10;
            this.creerTabPage2.Location = new System.Drawing.Point(4, 38);
            this.creerTabPage2.Name = "creerTabPage2";
            this.creerTabPage2.Size = new System.Drawing.Size(665, 401);
            this.creerTabPage2.TabIndex = 1;
            this.creerTabPage2.Text = "Créer Réunion";
            this.creerTabPage2.UseCustomBackColor = true;
            this.creerTabPage2.VerticalScrollbarBarColor = true;
            this.creerTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.creerTabPage2.VerticalScrollbarSize = 10;
            this.creerTabPage2.Click += new System.EventHandler(this.creerTabPage2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.min);
            this.panel3.Controls.Add(this.second);
            this.panel3.Controls.Add(this.h);
            this.panel3.Controls.Add(this.valider);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.debut);
            this.panel3.Controls.Add(this.salle);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sujet);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(98, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 204);
            this.panel3.TabIndex = 62;
            // 
            // min
            // 
            this.min.FormattingEnabled = true;
            this.min.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12 ",
            "13",
            "14 ",
            "15 ",
            "16 ",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "45",
            "46",
            "47",
            "48",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.min.Location = new System.Drawing.Point(275, 97);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(53, 21);
            this.min.TabIndex = 72;
            // 
            // second
            // 
            this.second.FormattingEnabled = true;
            this.second.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12 ",
            "13",
            "14 ",
            "15 ",
            "16 ",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "45",
            "46",
            "47",
            "48",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.second.Location = new System.Drawing.Point(334, 97);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(53, 21);
            this.second.TabIndex = 71;
            // 
            // h
            // 
            this.h.FormattingEnabled = true;
            this.h.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.h.Location = new System.Drawing.Point(212, 97);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(53, 21);
            this.h.TabIndex = 70;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.ForeColor = System.Drawing.Color.White;
            this.valider.Location = new System.Drawing.Point(162, 143);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(142, 44);
            this.valider.TabIndex = 69;
            this.valider.Text = "Valider ";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Date";
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(212, 72);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(200, 20);
            this.debut.TabIndex = 66;
            // 
            // salle
            // 
            this.salle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salle.DataSource = this.salleBindingSource;
            this.salle.DisplayMember = "N_salle";
            this.salle.FormattingEnabled = true;
            this.salle.Location = new System.Drawing.Point(212, 45);
            this.salle.Name = "salle";
            this.salle.Size = new System.Drawing.Size(200, 21);
            this.salle.TabIndex = 68;
            this.salle.ValueMember = "N_salle";
            // 
            // salleBindingSource
            // 
            this.salleBindingSource.DataMember = "salle";
            this.salleBindingSource.DataSource = this.databaseGestionReunionDataSet;
            // 
            // databaseGestionReunionDataSet
            // 
            this.databaseGestionReunionDataSet.DataSetName = "DatabaseGestionReunionDataSet";
            this.databaseGestionReunionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 67;
            this.label5.Text = "Numéro de salle ";
            // 
            // sujet
            // 
            this.sujet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sujet.Location = new System.Drawing.Point(212, 22);
            this.sujet.Name = "sujet";
            this.sujet.Size = new System.Drawing.Size(200, 20);
            this.sujet.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = " Sujet du Réunion ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(268, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(323, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "BONJOUR ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(228, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "BONJOUR ";
            // 
            // afficherTabPage3
            // 
            this.afficherTabPage3.Controls.Add(this.button3);
            this.afficherTabPage3.Controls.Add(this.button2);
            this.afficherTabPage3.Controls.Add(this.label1);
            this.afficherTabPage3.Controls.Add(this.showMembersBtn);
            this.afficherTabPage3.Controls.Add(this.panel2);
            this.afficherTabPage3.Controls.Add(this.label2);
            this.afficherTabPage3.Controls.Add(this.openFileBtn);
            this.afficherTabPage3.Controls.Add(this.compteRenduBtn);
            this.afficherTabPage3.HorizontalScrollbarBarColor = true;
            this.afficherTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.afficherTabPage3.HorizontalScrollbarSize = 10;
            this.afficherTabPage3.Location = new System.Drawing.Point(4, 38);
            this.afficherTabPage3.Name = "afficherTabPage3";
            this.afficherTabPage3.Size = new System.Drawing.Size(665, 401);
            this.afficherTabPage3.TabIndex = 2;
            this.afficherTabPage3.Text = "Afficher Réunion";
            this.afficherTabPage3.VerticalScrollbarBarColor = true;
            this.afficherTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.afficherTabPage3.VerticalScrollbarSize = 10;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(390, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 46);
            this.button3.TabIndex = 64;
            this.button3.Text = "Réserver des matériaux";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(119, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 46);
            this.button2.TabIndex = 40;
            this.button2.Text = "Inviter des Membres";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sélectionner une Réunion pour: \r\n\r\n";
            // 
            // showMembersBtn
            // 
            this.showMembersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showMembersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.showMembersBtn.FlatAppearance.BorderSize = 0;
            this.showMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMembersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMembersBtn.ForeColor = System.Drawing.Color.White;
            this.showMembersBtn.Location = new System.Drawing.Point(254, 335);
            this.showMembersBtn.Name = "showMembersBtn";
            this.showMembersBtn.Size = new System.Drawing.Size(130, 46);
            this.showMembersBtn.TabIndex = 10;
            this.showMembersBtn.Text = "Afficher Participants";
            this.showMembersBtn.UseVisualStyleBackColor = false;
            this.showMembersBtn.Click += new System.EventHandler(this.showMembersBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.metroGrid1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(29, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 262);
            this.panel2.TabIndex = 9;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 48);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(507, 191);
            this.metroGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(482, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 37);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(580, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 49);
            this.label2.TabIndex = 8;
            this.label2.Text = "Attacher  un compte rendu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(531, 335);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(102, 46);
            this.openFileBtn.TabIndex = 7;
            this.openFileBtn.Text = "voir compte rendu";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // compteRenduBtn
            // 
            this.compteRenduBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.compteRenduBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.compteRenduBtn.FlatAppearance.BorderSize = 0;
            this.compteRenduBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compteRenduBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compteRenduBtn.ForeColor = System.Drawing.Color.White;
            this.compteRenduBtn.Location = new System.Drawing.Point(591, 175);
            this.compteRenduBtn.Name = "compteRenduBtn";
            this.compteRenduBtn.Size = new System.Drawing.Size(68, 55);
            this.compteRenduBtn.TabIndex = 7;
            this.compteRenduBtn.Text = "choisir fichier";
            this.compteRenduBtn.UseVisualStyleBackColor = false;
            this.compteRenduBtn.Click += new System.EventHandler(this.compteRenduBtn_Click);
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
            this.Entete.Paint += new System.Windows.Forms.PaintEventHandler(this.Entete_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel10.Location = new System.Drawing.Point(3, 42);
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
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chef";
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
            // salleTableAdapter
            // 
            this.salleTableAdapter.ClearBeforeFill = true;
            // 
            // choixChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choixChef";
            this.Text = "choixChef";
            this.Load += new System.EventHandler(this.choixChef_Load_1);
            this.corps.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.homeTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.creerTabPage2.ResumeLayout(false);
            this.creerTabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.afficherTabPage3.ResumeLayout(false);
            this.afficherTabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.Entete.ResumeLayout(false);
            this.Entete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel corps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Entete;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage homeTabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabPage creerTabPage2;
        private MetroFramework.Controls.MetroTabPage afficherTabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showMembersBtn;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compteRenduBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private DatabaseGestionReunionDataSet databaseGestionReunionDataSet;
        private System.Windows.Forms.BindingSource salleBindingSource;
        private DatabaseGestionReunionDataSetTableAdapters.salleTableAdapter salleTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox min;
        private System.Windows.Forms.ComboBox second;
        private System.Windows.Forms.ComboBox h;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker debut;
        private System.Windows.Forms.ComboBox salle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sujet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openFileBtn;
    }
}