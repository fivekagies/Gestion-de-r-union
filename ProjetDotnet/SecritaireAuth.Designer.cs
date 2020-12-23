namespace ProjetDotnet
{
    partial class SecritaireAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecritaireAuth));
            this.corps = new System.Windows.Forms.Panel();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.ns = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.corps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // corps
            // 
            this.corps.BackColor = System.Drawing.Color.Tomato;
            this.corps.Controls.Add(this.checkHide);
            this.corps.Controls.Add(this.panel4);
            this.corps.Controls.Add(this.panel2);
            this.corps.Controls.Add(this.label3);
            this.corps.Controls.Add(this.panel1);
            this.corps.Controls.Add(this.button1);
            this.corps.Controls.Add(this.label2);
            this.corps.Controls.Add(this.label1);
            this.corps.Controls.Add(this.pass);
            this.corps.Controls.Add(this.ns);
            this.corps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.corps.Location = new System.Drawing.Point(0, 0);
            this.corps.Name = "corps";
            this.corps.Size = new System.Drawing.Size(673, 502);
            this.corps.TabIndex = 0;
            this.corps.Paint += new System.Windows.Forms.PaintEventHandler(this.corps_Paint);
            // 
            // checkHide
            // 
            this.checkHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.checkHide.Image = ((System.Drawing.Image)(resources.GetObject("checkHide.Image")));
            this.checkHide.Location = new System.Drawing.Point(436, 232);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(31, 27);
            this.checkHide.TabIndex = 27;
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(32, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 25);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(32, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 29);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(342, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Authentification ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(473, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 502);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(126, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 52);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(219, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "N_Secritaire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass
            // 
            // 
            // 
            // 
            this.pass.CustomButton.Image = null;
            this.pass.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.pass.CustomButton.Name = "";
            this.pass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass.CustomButton.TabIndex = 1;
            this.pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass.CustomButton.UseSelectable = true;
            this.pass.CustomButton.Visible = false;
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(194, 226);
            this.pass.MaxLength = 32767;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.Size = new System.Drawing.Size(238, 30);
            this.pass.TabIndex = 1;
            this.pass.UseSelectable = true;
            this.pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // ns
            // 
            // 
            // 
            // 
            this.ns.CustomButton.Image = null;
            this.ns.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.ns.CustomButton.Name = "";
            this.ns.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ns.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ns.CustomButton.TabIndex = 1;
            this.ns.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ns.CustomButton.UseSelectable = true;
            this.ns.CustomButton.Visible = false;
            this.ns.Lines = new string[0];
            this.ns.Location = new System.Drawing.Point(194, 180);
            this.ns.MaxLength = 32767;
            this.ns.Name = "ns";
            this.ns.PasswordChar = '\0';
            this.ns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ns.SelectedText = "";
            this.ns.SelectionLength = 0;
            this.ns.SelectionStart = 0;
            this.ns.ShortcutsEnabled = true;
            this.ns.Size = new System.Drawing.Size(238, 30);
            this.ns.TabIndex = 0;
            this.ns.UseSelectable = true;
            this.ns.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ns.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ns.Click += new System.EventHandler(this.ns_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "S\'inscrire";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SecritaireAuth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 502);
            this.Controls.Add(this.corps);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecritaireAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthChef";
            this.corps.ResumeLayout(false);
            this.corps.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel corps;
        private MetroFramework.Controls.MetroTextBox ns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox pass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.Label label4;
    }
}

