
namespace Devoir
{
    partial class OfrmTableau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfrmTableau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblT = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnEnreg = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LblEcart = new System.Windows.Forms.Label();
            this.LblMoy = new System.Windows.Forms.Label();
            this.LblInf = new System.Windows.Forms.Label();
            this.LblSup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblT);
            this.groupBox1.Controls.Add(this.LblRes);
            this.groupBox1.Controls.Add(this.BtnEnreg);
            this.groupBox1.Controls.Add(this.TxtN);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement des Notes:";
            // 
            // LblT
            // 
            this.LblT.AutoSize = true;
            this.LblT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblT.Location = new System.Drawing.Point(146, 87);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(0, 23);
            this.LblT.TabIndex = 3;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Arial", 9F);
            this.LblRes.Location = new System.Drawing.Point(8, 46);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 15);
            this.LblRes.TabIndex = 2;
            // 
            // BtnEnreg
            // 
            this.BtnEnreg.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEnreg.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnreg.Image")));
            this.BtnEnreg.Location = new System.Drawing.Point(286, 20);
            this.BtnEnreg.Name = "BtnEnreg";
            this.BtnEnreg.Size = new System.Drawing.Size(171, 55);
            this.BtnEnreg.TabIndex = 1;
            this.BtnEnreg.Text = "   Enregistrer";
            this.BtnEnreg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEnreg.UseVisualStyleBackColor = true;
            this.BtnEnreg.Click += new System.EventHandler(this.BtnEnreg_Click);
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(204, 42);
            this.TxtN.Multiline = true;
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(59, 23);
            this.TxtN.TabIndex = 0;
            this.TxtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(36, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(495, 166);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LblEcart
            // 
            this.LblEcart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEcart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEcart.Location = new System.Drawing.Point(212, 234);
            this.LblEcart.Name = "LblEcart";
            this.LblEcart.Size = new System.Drawing.Size(88, 27);
            this.LblEcart.TabIndex = 5;
            this.LblEcart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMoy
            // 
            this.LblMoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMoy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoy.Location = new System.Drawing.Point(212, 199);
            this.LblMoy.Name = "LblMoy";
            this.LblMoy.Size = new System.Drawing.Size(88, 27);
            this.LblMoy.TabIndex = 6;
            this.LblMoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInf
            // 
            this.LblInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblInf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInf.ForeColor = System.Drawing.Color.Red;
            this.LblInf.Location = new System.Drawing.Point(212, 269);
            this.LblInf.Name = "LblInf";
            this.LblInf.Size = new System.Drawing.Size(88, 27);
            this.LblInf.TabIndex = 7;
            this.LblInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSup
            // 
            this.LblSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSup.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblSup.Location = new System.Drawing.Point(212, 304);
            this.LblSup.Name = "LblSup";
            this.LblSup.Size = new System.Drawing.Size(88, 27);
            this.LblSup.TabIndex = 8;
            this.LblSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(44, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Moyenne de la classe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(44, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "L\'écart-type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(44, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre des Notes < 10:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(44, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre des Notes >=10:";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCalc.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalc.Image")));
            this.BtnCalc.Location = new System.Drawing.Point(366, 211);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(113, 46);
            this.BtnCalc.TabIndex = 13;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnQ
            // 
            this.BtnQ.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BtnQ.Image = ((System.Drawing.Image)(resources.GetObject("BtnQ.Image")));
            this.BtnQ.Location = new System.Drawing.Point(366, 269);
            this.BtnQ.Name = "BtnQ";
            this.BtnQ.Size = new System.Drawing.Size(113, 39);
            this.BtnQ.TabIndex = 14;
            this.BtnQ.Text = " Quitter";
            this.BtnQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQ.UseVisualStyleBackColor = true;
            this.BtnQ.Click += new System.EventHandler(this.BtnQ_Click);
            // 
            // OfrmTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 371);
            this.Controls.Add(this.BtnQ);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblSup);
            this.Controls.Add(this.LblInf);
            this.Controls.Add(this.LblMoy);
            this.Controls.Add(this.LblEcart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfrmTableau";
            this.Text = "Les Tableaux";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnEnreg;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblEcart;
        private System.Windows.Forms.Label LblMoy;
        private System.Windows.Forms.Label LblInf;
        private System.Windows.Forms.Label LblSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnQ;
    }
}