
namespace Devoir
{
    partial class NfrmFactoriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NfrmFactoriel));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Donner un entier positif";
            this.textBox1.Enter += new System.EventHandler(this.TextEnter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 26);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factoriel (  ) = ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRetour
            // 
            this.BtnRetour.BackColor = System.Drawing.Color.White;
            this.BtnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRetour.FlatAppearance.BorderSize = 0;
            this.BtnRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.ForeColor = System.Drawing.Color.Gray;
            this.BtnRetour.Image = ((System.Drawing.Image)(resources.GetObject("BtnRetour.Image")));
            this.BtnRetour.Location = new System.Drawing.Point(15, 235);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(100, 50);
            this.BtnRetour.TabIndex = 3;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRetour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRetour.UseVisualStyleBackColor = false;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetourClick);
            this.BtnRetour.MouseLeave += new System.EventHandler(this.BtnLeave);
            this.BtnRetour.MouseHover += new System.EventHandler(this.BtnHover);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.Color.White;
            this.BtnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitter.FlatAppearance.BorderSize = 0;
            this.BtnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.Gray;
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.Location = new System.Drawing.Point(185, 235);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(100, 50);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitterClick);
            this.BtnQuitter.MouseLeave += new System.EventHandler(this.BtnLeave);
            this.BtnQuitter.MouseHover += new System.EventHandler(this.BtnHover);
            // 
            // NfrmFactoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NfrmFactoriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul factoriel";
            this.Load += new System.EventHandler(this.NfrmFactoriel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnQuitter;
    }
}