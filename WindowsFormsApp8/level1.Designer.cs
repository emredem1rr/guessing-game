namespace WindowsFormsApp8
{
    partial class Level1Form
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
            this.components = new System.ComponentModel.Container();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button27 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.nextLvl = new System.Windows.Forms.Label();
            this.level1Lbl = new System.Windows.Forms.Label();
            this.currentPlayerLabelPrefix = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLbl.Location = new System.Drawing.Point(947, 319);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(39, 38);
            this.saniyeLbl.TabIndex = 99;
            this.saniyeLbl.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(915, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 38);
            this.label2.TabIndex = 98;
            this.label2.Text = ":";
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakikaLbl.Location = new System.Drawing.Point(870, 319);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(39, 38);
            this.dakikaLbl.TabIndex = 97;
            this.dakikaLbl.Text = "--";
            this.dakikaLbl.Click += new System.EventHandler(this.dakikaLbl_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(871, 207);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(115, 28);
            this.button26.TabIndex = 96;
            this.button26.Text = "TESLİM OL";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(871, 173);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(115, 28);
            this.button25.TabIndex = 95;
            this.button25.Text = "BAŞLA";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(839, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(16, 821);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(264, 15);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(115, 28);
            this.button27.TabIndex = 70;
            this.button27.Text = "GÖSTER";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.MapGeneration);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // nextLvl
            // 
            this.nextLvl.AutoSize = true;
            this.nextLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextLvl.Location = new System.Drawing.Point(1070, 507);
            this.nextLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextLvl.Name = "nextLvl";
            this.nextLvl.Size = new System.Drawing.Size(141, 20);
            this.nextLvl.TabIndex = 100;
            this.nextLvl.Text = "SONRAKİ LEVEL";
            this.nextLvl.Click += new System.EventHandler(this.nextLvl_Click);
            // 
            // level1Lbl
            // 
            this.level1Lbl.AutoSize = true;
            this.level1Lbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.level1Lbl.Location = new System.Drawing.Point(11, 9);
            this.level1Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.level1Lbl.Name = "level1Lbl";
            this.level1Lbl.Size = new System.Drawing.Size(103, 31);
            this.level1Lbl.TabIndex = 101;
            this.level1Lbl.Text = "LEVEL 1";
            // 
            // currentPlayerLabelPrefix
            // 
            this.currentPlayerLabelPrefix.AutoSize = true;
            this.currentPlayerLabelPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentPlayerLabelPrefix.Location = new System.Drawing.Point(861, 21);
            this.currentPlayerLabelPrefix.Name = "currentPlayerLabelPrefix";
            this.currentPlayerLabelPrefix.Size = new System.Drawing.Size(159, 22);
            this.currentPlayerLabelPrefix.TabIndex = 102;
            this.currentPlayerLabelPrefix.Text = "Oynayan Oyuncu :";
            this.currentPlayerLabelPrefix.Click += new System.EventHandler(this.currentPlayerLabelPrefix_Click);
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentPlayerLabel.Location = new System.Drawing.Point(986, 21);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 25);
            this.currentPlayerLabel.TabIndex = 103;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(188, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 49);
            this.button4.TabIndex = 71;
            this.button4.Tag = "map";
            this.button4.Text = "  ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(279, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 49);
            this.button5.TabIndex = 72;
            this.button5.Tag = "map";
            this.button5.Text = "  ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(370, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 49);
            this.button6.TabIndex = 73;
            this.button6.Tag = "map";
            this.button6.Text = "  ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(279, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 49);
            this.button7.TabIndex = 74;
            this.button7.Tag = "map";
            this.button7.Text = "  ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(188, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 49);
            this.button8.TabIndex = 75;
            this.button8.Tag = "map";
            this.button8.Text = "  ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(370, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 49);
            this.button9.TabIndex = 76;
            this.button9.Tag = "map";
            this.button9.Text = "  ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(188, 209);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 49);
            this.button10.TabIndex = 77;
            this.button10.Tag = "map";
            this.button10.Text = "  ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(279, 209);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 49);
            this.button11.TabIndex = 78;
            this.button11.Tag = "map";
            this.button11.Text = "  ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(370, 209);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(85, 49);
            this.button12.TabIndex = 79;
            this.button12.Tag = "map";
            this.button12.Text = "  ";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(188, 264);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 49);
            this.button13.TabIndex = 80;
            this.button13.Tag = "map";
            this.button13.Text = "  ";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(279, 264);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(85, 49);
            this.button14.TabIndex = 81;
            this.button14.Tag = "map";
            this.button14.Text = "  ";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(370, 264);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(85, 49);
            this.button15.TabIndex = 82;
            this.button15.Tag = "map";
            this.button15.Text = "  ";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(188, 321);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(85, 49);
            this.button16.TabIndex = 83;
            this.button16.Tag = "map";
            this.button16.Text = "  ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(279, 319);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(85, 49);
            this.button17.TabIndex = 84;
            this.button17.Tag = "map";
            this.button17.Text = "  ";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(370, 319);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(85, 49);
            this.button18.TabIndex = 85;
            this.button18.Tag = "map";
            this.button18.Text = "  ";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(188, 374);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(85, 49);
            this.button19.TabIndex = 86;
            this.button19.Tag = "map";
            this.button19.Text = "  ";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(279, 374);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(85, 49);
            this.button20.TabIndex = 87;
            this.button20.Tag = "map";
            this.button20.Text = "  ";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(370, 374);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(85, 49);
            this.button21.TabIndex = 88;
            this.button21.Tag = "map";
            this.button21.Text = "  ";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.MapButtonClick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Level1Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1222, 603);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.currentPlayerLabelPrefix);
            this.Controls.Add(this.level1Lbl);
            this.Controls.Add(this.nextLvl);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Level1Form";
            this.Text = "Level 1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label nextLvl;
        private System.Windows.Forms.Label level1Lbl;
        private System.Windows.Forms.Label currentPlayerLabelPrefix;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Timer timer3;
    }
}