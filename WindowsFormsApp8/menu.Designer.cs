namespace WindowsFormsApp8
{
    partial class MainMenu
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
            this.oynaLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.p1Lbl = new System.Windows.Forms.Label();
            this.p2Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oynaLbl
            // 
            this.oynaLbl.AutoSize = true;
            this.oynaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oynaLbl.Location = new System.Drawing.Point(567, 359);
            this.oynaLbl.Name = "oynaLbl";
            this.oynaLbl.Size = new System.Drawing.Size(144, 51);
            this.oynaLbl.TabIndex = 0;
            this.oynaLbl.Text = "OYNA";
            this.oynaLbl.Click += new System.EventHandler(this.PlayGameLabelClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(545, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(545, 273);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 30);
            this.textBox2.TabIndex = 2;
            // 
            // p1Lbl
            // 
            this.p1Lbl.AutoSize = true;
            this.p1Lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p1Lbl.Location = new System.Drawing.Point(345, 208);
            this.p1Lbl.Name = "p1Lbl";
            this.p1Lbl.Size = new System.Drawing.Size(182, 32);
            this.p1Lbl.TabIndex = 3;
            this.p1Lbl.Text = "1.OYUNCU : ";
            // 
            // p2Lbl
            // 
            this.p2Lbl.AutoSize = true;
            this.p2Lbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p2Lbl.Location = new System.Drawing.Point(345, 270);
            this.p2Lbl.Name = "p2Lbl";
            this.p2Lbl.Size = new System.Drawing.Size(182, 32);
            this.p2Lbl.TabIndex = 4;
            this.p2Lbl.Text = "2.OYUNCU : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(507, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 156);
            this.label1.TabIndex = 5;
            this.label1.Text = "HOŞGELDİNİZ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(424, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "LÜTFEN OYUNCU İSİMLERİNİ GİRİNİZ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2Lbl);
            this.Controls.Add(this.p1Lbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.oynaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oynaLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label p1Lbl;
        private System.Windows.Forms.Label p2Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}