namespace ProjetDotnet
{
    partial class ReserverMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserverMateriel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.corps = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.config2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Panel();
            this.reserve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.precedentButton4 = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Matériel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entete = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.databaseGestionReunionDataSet5 = new ProjetDotnet.DatabaseGestionReunionDataSet5();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materielTableAdapter = new ProjetDotnet.DatabaseGestionReunionDataSet5TableAdapters.MaterielTableAdapter();
            this.corps.SuspendLayout();
            this.config2.SuspendLayout();
            this.config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.Entete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.White;
            this.corps.Controls.Add(this.label3);
            this.corps.Controls.Add(this.config2);
            this.corps.Controls.Add(this.config);
            this.corps.Controls.Add(this.button5);
            this.corps.Controls.Add(this.button4);
            this.corps.Controls.Add(this.precedentButton4);
            this.corps.Controls.Add(this.metroGrid1);
            this.corps.Controls.Add(this.Entete);
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 0;
            this.corps.Paint += new System.Windows.Forms.PaintEventHandler(this.corps_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 79;
            // 
            // config2
            // 
            this.config2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.config2.Controls.Add(this.label1);
            this.config2.Controls.Add(this.button2);
            this.config2.Location = new System.Drawing.Point(88, 359);
            this.config2.Name = "config2";
            this.config2.Size = new System.Drawing.Size(348, 101);
            this.config2.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 34);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sélectionner un matériel pour le supprimer \r\nde la liste des matériaux réservés p" +
    "our Votre Réunion ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 68;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.config.Controls.Add(this.reserve);
            this.config.Controls.Add(this.label2);
            this.config.Location = new System.Drawing.Point(366, 219);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(307, 105);
            this.config.TabIndex = 76;
            // 
            // reserve
            // 
            this.reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.reserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserve.ForeColor = System.Drawing.Color.White;
            this.reserve.Location = new System.Drawing.Point(69, 45);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(150, 47);
            this.reserve.TabIndex = 69;
            this.reserve.Text = "Réserver";
            this.reserve.UseVisualStyleBackColor = false;
            this.reserve.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Sélectionner un matériel pour la réservation ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 47);
            this.button5.TabIndex = 74;
            this.button5.Text = "Afficher les matéraiux disponible";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(246, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 47);
            this.button4.TabIndex = 73;
            this.button4.Text = "Afficher les materiaux Réservés pour ma réunion ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // precedentButton4
            // 
            this.precedentButton4.FlatAppearance.BorderSize = 0;
            this.precedentButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.precedentButton4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedentButton4.ForeColor = System.Drawing.Color.Black;
            this.precedentButton4.Image = ((System.Drawing.Image)(resources.GetObject("precedentButton4.Image")));
            this.precedentButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precedentButton4.Location = new System.Drawing.Point(504, 65);
            this.precedentButton4.Name = "precedentButton4";
            this.precedentButton4.Size = new System.Drawing.Size(140, 61);
            this.precedentButton4.TabIndex = 71;
            this.precedentButton4.Text = "Précédent";
            this.precedentButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.precedentButton4.UseVisualStyleBackColor = true;
            this.precedentButton4.Click += new System.EventHandler(this.precedentButton4_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matériel,
            this.Code});
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
            this.metroGrid1.Location = new System.Drawing.Point(103, 169);
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
            this.metroGrid1.Size = new System.Drawing.Size(244, 174);
            this.metroGrid1.TabIndex = 66;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Matériel
            // 
            this.Matériel.HeaderText = "Matériel";
            this.Matériel.Name = "Matériel";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
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
            this.Entete.TabIndex = 10;
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
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Réserver des Matériux";
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
            // databaseGestionReunionDataSet5
            // 
            this.databaseGestionReunionDataSet5.DataSetName = "DatabaseGestionReunionDataSet5";
            this.databaseGestionReunionDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materielBindingSource
            // 
            this.materielBindingSource.DataMember = "Materiel";
            this.materielBindingSource.DataSource = this.databaseGestionReunionDataSet5;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // ReserverMateriel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserverMateriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthChef";
            this.Load += new System.EventHandler(this.ReserverMateriel_Load);
            this.corps.ResumeLayout(false);
            this.corps.PerformLayout();
            this.config2.ResumeLayout(false);
            this.config2.PerformLayout();
            this.config.ResumeLayout(false);
            this.config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.Entete.ResumeLayout(false);
            this.Entete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGestionReunionDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel corps;
        private System.Windows.Forms.Panel Entete;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private DatabaseGestionReunionDataSet5 databaseGestionReunionDataSet5;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private DatabaseGestionReunionDataSet5TableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button precedentButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matériel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel config2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

