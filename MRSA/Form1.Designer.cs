namespace MRSA
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClearPanel = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.FileO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrOfCross = new System.Windows.Forms.NumericUpDown();
            this.PrOfMutate = new System.Windows.Forms.NumericUpDown();
            this.CountOfIt = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShagOfAlg = new System.Windows.Forms.Label();
            this.BestOfChroma = new System.Windows.Forms.Label();
            this.BestOfLength = new System.Windows.Forms.Label();
            this.TimeOfAlg = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.CountOfChr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.CountOfPoints = new System.Windows.Forms.NumericUpDown();
            this.GeneratePoint = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelForDraw = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrOfCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrOfMutate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfIt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfChr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.ClearPanel);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.FileO);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.CountOfChr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.CountOfPoints);
            this.panel1.Controls.Add(this.GeneratePoint);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 613);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Algorithm settings";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClearPanel
            // 
            this.ClearPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ClearPanel.Location = new System.Drawing.Point(133, 159);
            this.ClearPanel.Name = "ClearPanel";
            this.ClearPanel.Size = new System.Drawing.Size(115, 36);
            this.ClearPanel.TabIndex = 26;
            this.ClearPanel.Text = "Clear";
            this.ClearPanel.UseVisualStyleBackColor = true;
            this.ClearPanel.Click += new System.EventHandler(this.ClearPanel_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(171, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.TabStop = false;
            // 
            // FileO
            // 
            this.FileO.AutoSize = true;
            this.FileO.Location = new System.Drawing.Point(8, 136);
            this.FileO.Name = "FileO";
            this.FileO.Size = new System.Drawing.Size(39, 13);
            this.FileO.TabIndex = 25;
            this.FileO.Text = "File:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(133, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PrOfCross);
            this.groupBox2.Controls.Add(this.PrOfMutate);
            this.groupBox2.Controls.Add(this.CountOfIt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(8, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 119);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Crossover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mutation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maximum iterations";
            // 
            // PrOfCross
            // 
            this.PrOfCross.Location = new System.Drawing.Point(166, 25);
            this.PrOfCross.Name = "PrOfCross";
            this.PrOfCross.Size = new System.Drawing.Size(65, 20);
            this.PrOfCross.TabIndex = 3;
            this.PrOfCross.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // PrOfMutate
            // 
            this.PrOfMutate.Location = new System.Drawing.Point(166, 58);
            this.PrOfMutate.Name = "PrOfMutate";
            this.PrOfMutate.Size = new System.Drawing.Size(65, 20);
            this.PrOfMutate.TabIndex = 4;
            this.PrOfMutate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CountOfIt
            // 
            this.CountOfIt.Location = new System.Drawing.Point(166, 90);
            this.CountOfIt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CountOfIt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountOfIt.Name = "CountOfIt";
            this.CountOfIt.Size = new System.Drawing.Size(65, 20);
            this.CountOfIt.TabIndex = 13;
            this.CountOfIt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ShagOfAlg);
            this.groupBox1.Controls.Add(this.BestOfChroma);
            this.groupBox1.Controls.Add(this.BestOfLength);
            this.groupBox1.Controls.Add(this.TimeOfAlg);
            this.groupBox1.Location = new System.Drawing.Point(4, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 207);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional information";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(144, 178);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(32, 20);
            this.textBox8.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(211, 178);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(32, 20);
            this.textBox7.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Point coordinates";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(98, 20);
            this.textBox6.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tree size";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(98, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(98, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            // 
            // ShagOfAlg
            // 
            this.ShagOfAlg.AutoSize = true;
            this.ShagOfAlg.Location = new System.Drawing.Point(2, 34);
            this.ShagOfAlg.Name = "ShagOfAlg";
            this.ShagOfAlg.Size = new System.Drawing.Size(30, 13);
            this.ShagOfAlg.TabIndex = 15;
            this.ShagOfAlg.Text = "Step:";
            // 
            // BestOfChroma
            // 
            this.BestOfChroma.AutoSize = true;
            this.BestOfChroma.Location = new System.Drawing.Point(2, 64);
            this.BestOfChroma.Name = "BestOfChroma";
            this.BestOfChroma.Size = new System.Drawing.Size(108, 13);
            this.BestOfChroma.TabIndex = 9;
            this.BestOfChroma.Text = "Best chromosome:";
            // 
            // BestOfLength
            // 
            this.BestOfLength.AutoSize = true;
            this.BestOfLength.Location = new System.Drawing.Point(2, 94);
            this.BestOfLength.Name = "BestOfLength";
            this.BestOfLength.Size = new System.Drawing.Size(138, 13);
            this.BestOfLength.TabIndex = 8;
            this.BestOfLength.Text = "Steiner tree size";
            // 
            // TimeOfAlg
            // 
            this.TimeOfAlg.AutoSize = true;
            this.TimeOfAlg.Location = new System.Drawing.Point(4, 149);
            this.TimeOfAlg.Name = "TimeOfAlg";
            this.TimeOfAlg.Size = new System.Drawing.Size(40, 13);
            this.TimeOfAlg.TabIndex = 17;
            this.TimeOfAlg.Text = "Time";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Save.Location = new System.Drawing.Point(7, 159);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 36);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Stop.Location = new System.Drawing.Point(183, 569);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(70, 37);
            this.Stop.TabIndex = 16;
            this.Stop.Text = "Pause";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // CountOfChr
            // 
            this.CountOfChr.Location = new System.Drawing.Point(174, 53);
            this.CountOfChr.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CountOfChr.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CountOfChr.Name = "CountOfChr";
            this.CountOfChr.Size = new System.Drawing.Size(65, 20);
            this.CountOfChr.TabIndex = 11;
            this.CountOfChr.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of chromosomes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of points";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Start.Location = new System.Drawing.Point(7, 569);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(167, 37);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start/Continue";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CountOfPoints
            // 
            this.CountOfPoints.Location = new System.Drawing.Point(174, 15);
            this.CountOfPoints.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CountOfPoints.Name = "CountOfPoints";
            this.CountOfPoints.Size = new System.Drawing.Size(65, 20);
            this.CountOfPoints.TabIndex = 1;
            this.CountOfPoints.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // GeneratePoint
            // 
            this.GeneratePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GeneratePoint.Location = new System.Drawing.Point(7, 89);
            this.GeneratePoint.Name = "GeneratePoint";
            this.GeneratePoint.Size = new System.Drawing.Size(120, 40);
            this.GeneratePoint.TabIndex = 0;
            this.GeneratePoint.Text = "Generate";
            this.GeneratePoint.UseVisualStyleBackColor = true;
            this.GeneratePoint.Click += new System.EventHandler(this.GeneratePoint_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelForDraw
            // 
            this.PanelForDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForDraw.BackColor = System.Drawing.Color.White;
            this.PanelForDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelForDraw.Location = new System.Drawing.Point(266, 48);
            this.PanelForDraw.Name = "PanelForDraw";
            this.PanelForDraw.Size = new System.Drawing.Size(1006, 897);
            this.PanelForDraw.TabIndex = 2;
            this.PanelForDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelForDraw_MouseClick);
            this.PanelForDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForDraw_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.PanelForDraw);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MRSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrOfCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrOfMutate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfIt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfChr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GeneratePoint;
        private System.Windows.Forms.NumericUpDown CountOfPoints;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PrOfMutate;
        private System.Windows.Forms.NumericUpDown PrOfCross;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label BestOfLength;
        private System.Windows.Forms.Label BestOfChroma;
        private System.Windows.Forms.NumericUpDown CountOfChr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CountOfIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ShagOfAlg;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label TimeOfAlg;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label FileO;
        private System.Windows.Forms.Panel PanelForDraw;
        private System.Windows.Forms.Button ClearPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
    }
}

