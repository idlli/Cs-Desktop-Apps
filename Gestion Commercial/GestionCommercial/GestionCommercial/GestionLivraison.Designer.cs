namespace GestionCommercial
{
    partial class GestionLivraison
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
            this.NCommande = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NLivraison = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLivraison = new System.Windows.Forms.DateTimePicker();
            this.Livreur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MyGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NCommande
            // 
            this.NCommande.Enabled = false;
            this.NCommande.Location = new System.Drawing.Point(133, 29);
            this.NCommande.Name = "NCommande";
            this.NCommande.Size = new System.Drawing.Size(163, 20);
            this.NCommande.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N Commande :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "N Livraison :";
            // 
            // NLivraison
            // 
            this.NLivraison.Location = new System.Drawing.Point(34, 104);
            this.NLivraison.Name = "NLivraison";
            this.NLivraison.Size = new System.Drawing.Size(127, 20);
            this.NLivraison.TabIndex = 22;
            this.NLivraison.TextChanged += new System.EventHandler(this.NLivraison_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date Livraison :";
            // 
            // DateLivraison
            // 
            this.DateLivraison.Location = new System.Drawing.Point(189, 104);
            this.DateLivraison.Name = "DateLivraison";
            this.DateLivraison.Size = new System.Drawing.Size(200, 20);
            this.DateLivraison.TabIndex = 24;
            // 
            // Livreur
            // 
            this.Livreur.Location = new System.Drawing.Point(419, 104);
            this.Livreur.Name = "Livreur";
            this.Livreur.Size = new System.Drawing.Size(127, 20);
            this.Livreur.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Livreur :";
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
            this.MyGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.MyGridView.Location = new System.Drawing.Point(34, 148);
            this.MyGridView.MultiSelect = false;
            this.MyGridView.Name = "MyGridView";
            this.MyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGridView.Size = new System.Drawing.Size(512, 150);
            this.MyGridView.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Article";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PU";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Q";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QL";
            this.Column5.Name = "Column5";
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(34, 320);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(246, 23);
            this.Enregistrer.TabIndex = 28;
            this.Enregistrer.Text = "Enregistrer la Livraison";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(300, 320);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(246, 23);
            this.Valider.TabIndex = 29;
            this.Valider.Text = "Valider la Livraison";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionCommercial.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(517, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Bon de Livraison";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.MyGridView);
            this.Controls.Add(this.Livreur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateLivraison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NLivraison);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NCommande);
            this.Controls.Add(this.label1);
            this.Name = "GestionLivraison";
            this.Text = "GestionLivraison";
            this.Load += new System.EventHandler(this.GestionLivraison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NLivraison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateLivraison;
        private System.Windows.Forms.TextBox Livreur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}