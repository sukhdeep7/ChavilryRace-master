namespace ChavilryRace
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
            this.TrackLengthPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.RaceTime = new System.Windows.Forms.Timer(this.components);
            this.knightBlack = new System.Windows.Forms.PictureBox();
            this.knightGreen = new System.Windows.Forms.PictureBox();
            this.knightRed = new System.Windows.Forms.PictureBox();
            this.knightBlue = new System.Windows.Forms.PictureBox();
            this.TrackLengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackLengthPanel
            // 
            this.TrackLengthPanel.Controls.Add(this.knightBlue);
            this.TrackLengthPanel.Controls.Add(this.knightRed);
            this.TrackLengthPanel.Controls.Add(this.knightGreen);
            this.TrackLengthPanel.Controls.Add(this.knightBlack);
            this.TrackLengthPanel.Location = new System.Drawing.Point(13, 13);
            this.TrackLengthPanel.Name = "TrackLengthPanel";
            this.TrackLengthPanel.Size = new System.Drawing.Size(983, 421);
            this.TrackLengthPanel.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 441);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 465);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 489);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bet Amount: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bet Chevilry: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(606, 478);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(606, 452);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            995,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceBet.Location = new System.Drawing.Point(732, 452);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(264, 50);
            this.PlaceBet.TabIndex = 11;
            this.PlaceBet.Text = "PLACE BET";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRace.Location = new System.Drawing.Point(534, 509);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(461, 81);
            this.StartRace.TabIndex = 12;
            this.StartRace.Text = "RACE";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // RaceTime
            // 
            this.RaceTime.Tick += new System.EventHandler(this.RaceTime_Tick);
            // 
            // knightBlack
            // 
            this.knightBlack.Image = global::ChavilryRace.Properties.Resources.knightBlack;
            this.knightBlack.Location = new System.Drawing.Point(4, 18);
            this.knightBlack.Name = "knightBlack";
            this.knightBlack.Size = new System.Drawing.Size(65, 65);
            this.knightBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightBlack.TabIndex = 0;
            this.knightBlack.TabStop = false;
            // 
            // knightGreen
            // 
            this.knightGreen.Image = global::ChavilryRace.Properties.Resources.knightGreen;
            this.knightGreen.Location = new System.Drawing.Point(4, 120);
            this.knightGreen.Name = "knightGreen";
            this.knightGreen.Size = new System.Drawing.Size(65, 65);
            this.knightGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightGreen.TabIndex = 1;
            this.knightGreen.TabStop = false;
            // 
            // knightRed
            // 
            this.knightRed.Image = global::ChavilryRace.Properties.Resources.knightRed;
            this.knightRed.Location = new System.Drawing.Point(4, 222);
            this.knightRed.Name = "knightRed";
            this.knightRed.Size = new System.Drawing.Size(65, 65);
            this.knightRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightRed.TabIndex = 2;
            this.knightRed.TabStop = false;
            // 
            // knightBlue
            // 
            this.knightBlue.Image = global::ChavilryRace.Properties.Resources.knightBlue;
            this.knightBlue.Location = new System.Drawing.Point(4, 325);
            this.knightBlue.Name = "knightBlue";
            this.knightBlue.Size = new System.Drawing.Size(65, 65);
            this.knightBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.knightBlue.TabIndex = 3;
            this.knightBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TrackLengthPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrackLengthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TrackLengthPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.Timer RaceTime;
        private System.Windows.Forms.PictureBox knightBlue;
        private System.Windows.Forms.PictureBox knightRed;
        private System.Windows.Forms.PictureBox knightGreen;
        private System.Windows.Forms.PictureBox knightBlack;
    }
}

