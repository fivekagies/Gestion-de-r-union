namespace ProjetDotnet
{
    partial class ChoixduMembre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixduMembre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.corps = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.precedentButton4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seeMembersBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.refuseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Id_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compteRendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.corps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.PaleTurquoise;
            this.corps.Controls.Add(this.openFileBtn);
            this.corps.Controls.Add(this.button2);
            this.corps.Controls.Add(this.precedentButton4);
            this.corps.Controls.Add(this.label1);
            this.corps.Controls.Add(this.seeMembersBtn);
            this.corps.Controls.Add(this.label2);
            this.corps.Controls.Add(this.richTextBox1);
            this.corps.Controls.Add(this.refuseBtn);
            this.corps.Controls.Add(this.button1);
            this.corps.Controls.Add(this.acceptBtn);
            this.corps.Controls.Add(this.metroGrid1);
            this.corps.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.ForeColor = System.Drawing.Color.White;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(550, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 61);
            this.button2.TabIndex = 29;
            this.button2.Text = "Affecter un compte rendu ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // precedentButton4
            // 
            this.precedentButton4.FlatAppearance.BorderSize = 0;
            this.precedentButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.precedentButton4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precedentButton4.ForeColor = System.Drawing.Color.Black;
            this.precedentButton4.Image = ((System.Drawing.Image)(resources.GetObject("precedentButton4.Image")));
            this.precedentButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.precedentButton4.Location = new System.Drawing.Point(10, 0);
            this.precedentButton4.Name = "precedentButton4";
            this.precedentButton4.Size = new System.Drawing.Size(140, 61);
            this.precedentButton4.TabIndex = 28;
            this.precedentButton4.Text = "Précédent";
            this.precedentButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.precedentButton4.UseVisualStyleBackColor = true;
            this.precedentButton4.Click += new System.EventHandler(this.precedentButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "\r\nvous êtes invité à participer les réunions suivantes : ";
            // 
            // seeMembersBtn
            // 
            this.seeMembersBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.seeMembersBtn.BackColor = System.Drawing.Color.Transparent;
            this.seeMembersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeMembersBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.seeMembersBtn.FlatAppearance.BorderSize = 0;
            this.seeMembersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeMembersBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeMembersBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.seeMembersBtn.Location = new System.Drawing.Point(553, 162);
            this.seeMembersBtn.Name = "seeMembersBtn";
            this.seeMembersBtn.Size = new System.Drawing.Size(120, 61);
            this.seeMembersBtn.TabIndex = 8;
            this.seeMembersBtn.Text = "Afficher Participants";
            this.seeMembersBtn.UseVisualStyleBackColor = false;
            this.seeMembersBtn.Click += new System.EventHandler(this.seeMembersBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ecrire un message au chef :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 394);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(217, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // refuseBtn
            // 
            this.refuseBtn.BackColor = System.Drawing.Color.Transparent;
            this.refuseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refuseBtn.FlatAppearance.BorderSize = 0;
            this.refuseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refuseBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refuseBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.refuseBtn.Image = ((System.Drawing.Image)(resources.GetObject("refuseBtn.Image")));
            this.refuseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refuseBtn.Location = new System.Drawing.Point(271, 318);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(133, 51);
            this.refuseBtn.TabIndex = 2;
            this.refuseBtn.Text = "Refuser";
            this.refuseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refuseBtn.UseVisualStyleBackColor = false;
            this.refuseBtn.Click += new System.EventHandler(this.refuseBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(495, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Envoyer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.FlatAppearance.BorderSize = 0;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acceptBtn.Location = new System.Drawing.Point(81, 318);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(145, 51);
            this.acceptBtn.TabIndex = 2;
            this.acceptBtn.Text = "Accepter";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
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
            this.Id_R,
            this.Sujet,
            this.Date,
            this.Heure,
            this.Chef,
            this.Salle,
            this.reponse,
            this.Message,
            this.compteRendu});
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
            this.metroGrid1.Location = new System.Drawing.Point(12, 140);
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
            this.metroGrid1.Size = new System.Drawing.Size(525, 150);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // Id_R
            // 
            this.Id_R.HeaderText = "Id_R";
            this.Id_R.Name = "Id_R";
            // 
            // Sujet
            // 
            this.Sujet.HeaderText = "Sujet";
            this.Sujet.Name = "Sujet";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date ";
            this.Date.Name = "Date";
            // 
            // Heure
            // 
            this.Heure.HeaderText = "Heure";
            this.Heure.Name = "Heure";
            // 
            // Chef
            // 
            this.Chef.HeaderText = "Chef";
            this.Chef.Name = "Chef";
            // 
            // Salle
            // 
            this.Salle.HeaderText = "Salle";
            this.Salle.Name = "Salle";
            // 
            // reponse
            // 
            this.reponse.HeaderText = "Reponse";
            this.reponse.Name = "reponse";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // compteRendu
            // 
            this.compteRendu.HeaderText = "compteRendu";
            this.compteRendu.Name = "compteRendu";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(445, 321);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(102, 46);
            this.openFileBtn.TabIndex = 30;
            this.openFileBtn.Text = "voir compte rendu";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // ChoixduMembre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixduMembre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthChef";
            this.corps.ResumeLayout(false);
            this.corps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel corps;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Button refuseBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button seeMembersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button precedentButton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_R;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salle;
        private System.Windows.Forms.DataGridViewTextBoxColumn reponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn compteRendu;
        private System.Windows.Forms.Button openFileBtn;
    }
}

