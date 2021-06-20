
namespace Devoir
{
    partial class OfrmFactoriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfrmFactoriel));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 53);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factoriel";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 131);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TxtN
            // 
            this.TxtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN.Location = new System.Drawing.Point(29, 128);
            this.TxtN.Multiline = true;
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(186, 23);
            this.TxtN.TabIndex = 6;
            this.TxtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalc.Image")));
            this.BtnCalc.Location = new System.Drawing.Point(234, 107);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(117, 45);
            this.BtnCalc.TabIndex = 7;
            this.BtnCalc.Text = " Calculer";
            this.BtnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblRes
            // 
            this.LblRes.AllowDrop = true;
            this.LblRes.AutoEllipsis = true;
            this.LblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRes.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.LblRes.Location = new System.Drawing.Point(30, 172);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(321, 22);
            this.LblRes.TabIndex = 9;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(10, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(362, 60);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(31, 230);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(144, 39);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = " Retour";
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.Location = new System.Drawing.Point(207, 230);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(144, 39);
            this.BtnQuitter.TabIndex = 12;
            this.BtnQuitter.Text = " Quitter";
            this.BtnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Donner un entier positif :";
            // 
            // OfrmFactoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "OfrmFactoriel";
            this.Text = "Calcul factoriel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label label3;
    }
}