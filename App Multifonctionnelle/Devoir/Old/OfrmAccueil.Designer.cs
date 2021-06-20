
namespace Devoir
{
    partial class OfrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfrmAccueil));
            this.BtnFactoriel = new System.Windows.Forms.Button();
            this.BtnTab = new System.Windows.Forms.Button();
            this.BtnJouer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFactoriel
            // 
            this.BtnFactoriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactoriel.Image = ((System.Drawing.Image)(resources.GetObject("BtnFactoriel.Image")));
            this.BtnFactoriel.Location = new System.Drawing.Point(91, 44);
            this.BtnFactoriel.Name = "BtnFactoriel";
            this.BtnFactoriel.Size = new System.Drawing.Size(189, 44);
            this.BtnFactoriel.TabIndex = 0;
            this.BtnFactoriel.Text = "Calcul Factoriel";
            this.BtnFactoriel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFactoriel.UseVisualStyleBackColor = true;
            this.BtnFactoriel.Click += new System.EventHandler(this.BtnFactoriel_Click);
            // 
            // BtnTab
            // 
            this.BtnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTab.Image = ((System.Drawing.Image)(resources.GetObject("BtnTab.Image")));
            this.BtnTab.Location = new System.Drawing.Point(91, 101);
            this.BtnTab.Name = "BtnTab";
            this.BtnTab.Size = new System.Drawing.Size(189, 44);
            this.BtnTab.TabIndex = 1;
            this.BtnTab.Text = "  Les tableaux";
            this.BtnTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTab.UseVisualStyleBackColor = true;
            this.BtnTab.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnJouer
            // 
            this.BtnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJouer.Image = ((System.Drawing.Image)(resources.GetObject("BtnJouer.Image")));
            this.BtnJouer.Location = new System.Drawing.Point(91, 159);
            this.BtnJouer.Name = "BtnJouer";
            this.BtnJouer.Size = new System.Drawing.Size(189, 44);
            this.BtnJouer.TabIndex = 2;
            this.BtnJouer.Text = "  Jouer";
            this.BtnJouer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJouer.UseVisualStyleBackColor = true;
            this.BtnJouer.Click += new System.EventHandler(this.BtnJouer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.Location = new System.Drawing.Point(91, 218);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(189, 44);
            this.BtnQuitter.TabIndex = 3;
            this.BtnQuitter.Text = "       Quitter";
            this.BtnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // OfrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 303);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnJouer);
            this.Controls.Add(this.BtnTab);
            this.Controls.Add(this.BtnFactoriel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfrmAccueil";
            this.Text = "TP 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFactoriel;
        private System.Windows.Forms.Button BtnTab;
        private System.Windows.Forms.Button BtnJouer;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

