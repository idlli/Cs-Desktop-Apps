namespace GestionCommercial
{
    partial class GestionCommandes
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
            this.label1 = new System.Windows.Forms.Label();
            this.NCommande = new System.Windows.Forms.TextBox();
            this.CodeCl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateCommande = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomC = new System.Windows.Forms.TextBox();
            this.VilleC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodeA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Desi = new System.Windows.Forms.TextBox();
            this.PU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MyGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Saisir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.QC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N Commande :";
            // 
            // NCommande
            // 
            this.NCommande.Location = new System.Drawing.Point(127, 27);
            this.NCommande.Name = "NCommande";
            this.NCommande.Size = new System.Drawing.Size(200, 20);
            this.NCommande.TabIndex = 1;
            this.NCommande.TextChanged += new System.EventHandler(this.NCommande_TextChanged);
            // 
            // CodeCl
            // 
            this.CodeCl.FormattingEnabled = true;
            this.CodeCl.Location = new System.Drawing.Point(447, 27);
            this.CodeCl.Name = "CodeCl";
            this.CodeCl.Size = new System.Drawing.Size(125, 21);
            this.CodeCl.TabIndex = 2;
            this.CodeCl.SelectedIndexChanged += new System.EventHandler(this.CodeCl_SelectedIndexChanged);
            this.CodeCl.TextChanged += new System.EventHandler(this.CodeCl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Commande :";
            // 
            // DateCommande
            // 
            this.DateCommande.Location = new System.Drawing.Point(127, 70);
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.Size = new System.Drawing.Size(200, 20);
            this.DateCommande.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code Client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom :";
            // 
            // NomC
            // 
            this.NomC.Enabled = false;
            this.NomC.Location = new System.Drawing.Point(447, 73);
            this.NomC.Name = "NomC";
            this.NomC.Size = new System.Drawing.Size(125, 20);
            this.NomC.TabIndex = 7;
            // 
            // VilleC
            // 
            this.VilleC.Enabled = false;
            this.VilleC.Location = new System.Drawing.Point(447, 122);
            this.VilleC.Name = "VilleC";
            this.VilleC.Size = new System.Drawing.Size(125, 20);
            this.VilleC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ville :";
            // 
            // CodeA
            // 
            this.CodeA.FormattingEnabled = true;
            this.CodeA.Location = new System.Drawing.Point(28, 185);
            this.CodeA.Name = "CodeA";
            this.CodeA.Size = new System.Drawing.Size(121, 21);
            this.CodeA.TabIndex = 10;
            this.CodeA.SelectedIndexChanged += new System.EventHandler(this.CodeA_SelectedIndexChanged);
            this.CodeA.TextChanged += new System.EventHandler(this.CodeA_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Code Article :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Designation :";
            // 
            // Desi
            // 
            this.Desi.Enabled = false;
            this.Desi.Location = new System.Drawing.Point(169, 186);
            this.Desi.Name = "Desi";
            this.Desi.Size = new System.Drawing.Size(121, 20);
            this.Desi.TabIndex = 13;
            // 
            // PU
            // 
            this.PU.Enabled = false;
            this.PU.Location = new System.Drawing.Point(311, 186);
            this.PU.Name = "PU";
            this.PU.Size = new System.Drawing.Size(74, 20);
            this.PU.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pu :";
            // 
            // QD
            // 
            this.QD.Enabled = false;
            this.QD.Location = new System.Drawing.Point(405, 185);
            this.QD.Name = "QD";
            this.QD.Size = new System.Drawing.Size(74, 20);
            this.QD.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "QD :";
            // 
            // MyGridView
            // 
            this.MyGridView.AllowUserToAddRows = false;
            this.MyGridView.AllowUserToDeleteRows = false;
            this.MyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.MyGridView.Location = new System.Drawing.Point(28, 229);
            this.MyGridView.MultiSelect = false;
            this.MyGridView.Name = "MyGridView";
            this.MyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGridView.Size = new System.Drawing.Size(404, 150);
            this.MyGridView.TabIndex = 18;
            this.MyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Article";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PU";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Montant";
            this.Column5.Name = "Column5";
            // 
            // Ajouter
            // 
            this.Ajouter.Enabled = false;
            this.Ajouter.Location = new System.Drawing.Point(451, 229);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(121, 23);
            this.Ajouter.TabIndex = 19;
            this.Ajouter.Text = "Ajouter Ligne";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Enabled = false;
            this.Supprimer.Location = new System.Drawing.Point(451, 267);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(121, 23);
            this.Supprimer.TabIndex = 20;
            this.Supprimer.Text = "Supprimer Ligne";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(28, 397);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(189, 23);
            this.Enregistrer.TabIndex = 21;
            this.Enregistrer.Text = "Enregistrer la Commande";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(236, 397);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(196, 23);
            this.Valider.TabIndex = 22;
            this.Valider.Text = "Valider la Commande";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Saisir
            // 
            this.Saisir.Location = new System.Drawing.Point(451, 378);
            this.Saisir.Name = "Saisir";
            this.Saisir.Size = new System.Drawing.Size(121, 42);
            this.Saisir.TabIndex = 23;
            this.Saisir.Text = "Saisir un Bon Livraison";
            this.Saisir.UseVisualStyleBackColor = true;
            this.Saisir.Click += new System.EventHandler(this.Saisir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(451, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 56);
            this.panel1.TabIndex = 24;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(41, 33);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Total :";
            // 
            // QC
            // 
            this.QC.Location = new System.Drawing.Point(498, 185);
            this.QC.Name = "QC";
            this.QC.Size = new System.Drawing.Size(74, 20);
            this.QC.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "QC :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Bon de Commande";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Saisir);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.MyGridView);
            this.Controls.Add(this.QD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Desi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CodeA);
            this.Controls.Add(this.VilleC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeCl);
            this.Controls.Add(this.NCommande);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCommandes";
            this.Text = "Gestion des Commandes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NCommande;
        private System.Windows.Forms.ComboBox CodeCl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomC;
        private System.Windows.Forms.TextBox VilleC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CodeA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Desi;
        private System.Windows.Forms.TextBox PU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView MyGridView;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Saisir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox QC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}

