﻿namespace SoftWare_Engineering
{
    partial class LevelQ1_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelQ1_3));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LA2 = new System.Windows.Forms.Label();
            this.LA3 = new System.Windows.Forms.Label();
            this.lA1 = new System.Windows.Forms.Label();
            this.ANSWER3 = new System.Windows.Forms.RadioButton();
            this.ANSWER2 = new System.Windows.Forms.RadioButton();
            this.ANSWER1 = new System.Windows.Forms.RadioButton();
            this.QUSTION = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.COUNTER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.STAR3 = new System.Windows.Forms.Label();
            this.STAR2 = new System.Windows.Forms.Label();
            this.STAR1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_star_48px.png");
            this.imageList1.Images.SetKeyName(1, "icons8_christmas_star_48px.png");
            this.imageList1.Images.SetKeyName(2, "icons8_left_48px.png");
            this.imageList1.Images.SetKeyName(3, "long_arrow_left_26px.png");
            // 
            // BOK
            // 
            this.BOK.BackColor = System.Drawing.Color.White;
            this.BOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOK.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOK.Location = new System.Drawing.Point(207, 280);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(83, 29);
            this.BOK.TabIndex = 40;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = false;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LA2);
            this.groupBox1.Controls.Add(this.LA3);
            this.groupBox1.Controls.Add(this.lA1);
            this.groupBox1.Controls.Add(this.ANSWER3);
            this.groupBox1.Controls.Add(this.ANSWER2);
            this.groupBox1.Controls.Add(this.ANSWER1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 123);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // LA2
            // 
            this.LA2.AutoSize = true;
            this.LA2.BackColor = System.Drawing.Color.White;
            this.LA2.Location = new System.Drawing.Point(7, 56);
            this.LA2.Name = "LA2";
            this.LA2.Size = new System.Drawing.Size(21, 24);
            this.LA2.TabIndex = 5;
            this.LA2.Text = "2";
            // 
            // LA3
            // 
            this.LA3.AutoSize = true;
            this.LA3.BackColor = System.Drawing.Color.White;
            this.LA3.Location = new System.Drawing.Point(6, 89);
            this.LA3.Name = "LA3";
            this.LA3.Size = new System.Drawing.Size(21, 24);
            this.LA3.TabIndex = 6;
            this.LA3.Text = "3";
            // 
            // lA1
            // 
            this.lA1.AutoSize = true;
            this.lA1.BackColor = System.Drawing.Color.White;
            this.lA1.Location = new System.Drawing.Point(6, 22);
            this.lA1.Name = "lA1";
            this.lA1.Size = new System.Drawing.Size(21, 24);
            this.lA1.TabIndex = 4;
            this.lA1.Text = "1";
            // 
            // ANSWER3
            // 
            this.ANSWER3.AutoSize = true;
            this.ANSWER3.BackColor = System.Drawing.Color.White;
            this.ANSWER3.Location = new System.Drawing.Point(40, 91);
            this.ANSWER3.Name = "ANSWER3";
            this.ANSWER3.Size = new System.Drawing.Size(68, 28);
            this.ANSWER3.TabIndex = 3;
            this.ANSWER3.TabStop = true;
            this.ANSWER3.Text = "10%";
            this.ANSWER3.UseVisualStyleBackColor = false;
            // 
            // ANSWER2
            // 
            this.ANSWER2.AutoSize = true;
            this.ANSWER2.BackColor = System.Drawing.Color.White;
            this.ANSWER2.Location = new System.Drawing.Point(40, 56);
            this.ANSWER2.Name = "ANSWER2";
            this.ANSWER2.Size = new System.Drawing.Size(68, 28);
            this.ANSWER2.TabIndex = 2;
            this.ANSWER2.TabStop = true;
            this.ANSWER2.Text = "20%";
            this.ANSWER2.UseVisualStyleBackColor = false;
            this.ANSWER2.CheckedChanged += new System.EventHandler(this.ANSWER2_CheckedChanged);
            // 
            // ANSWER1
            // 
            this.ANSWER1.AutoSize = true;
            this.ANSWER1.BackColor = System.Drawing.Color.White;
            this.ANSWER1.Location = new System.Drawing.Point(40, 23);
            this.ANSWER1.Name = "ANSWER1";
            this.ANSWER1.Size = new System.Drawing.Size(68, 28);
            this.ANSWER1.TabIndex = 1;
            this.ANSWER1.TabStop = true;
            this.ANSWER1.Text = "80%";
            this.ANSWER1.UseVisualStyleBackColor = false;
            // 
            // QUSTION
            // 
            this.QUSTION.BackColor = System.Drawing.Color.White;
            this.QUSTION.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUSTION.Location = new System.Drawing.Point(14, 55);
            this.QUSTION.Name = "QUSTION";
            this.QUSTION.Size = new System.Drawing.Size(285, 72);
            this.QUSTION.TabIndex = 42;
            this.QUSTION.Text = "Q3 : Cost of Fixing Design of Fault ?";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Number of Counter :";
            // 
            // COUNTER
            // 
            this.COUNTER.AutoSize = true;
            this.COUNTER.BackColor = System.Drawing.Color.White;
            this.COUNTER.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COUNTER.Location = new System.Drawing.Point(172, 325);
            this.COUNTER.Name = "COUNTER";
            this.COUNTER.Size = new System.Drawing.Size(21, 24);
            this.COUNTER.TabIndex = 45;
            this.COUNTER.Text = "0";
            // 
            // label1
            // 
            this.label1.ImageIndex = 3;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 43;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // STAR3
            // 
            this.STAR3.ImageIndex = 0;
            this.STAR3.ImageList = this.imageList1;
            this.STAR3.Location = new System.Drawing.Point(173, 452);
            this.STAR3.Name = "STAR3";
            this.STAR3.Size = new System.Drawing.Size(35, 23);
            this.STAR3.TabIndex = 39;
            // 
            // STAR2
            // 
            this.STAR2.ImageIndex = 0;
            this.STAR2.ImageList = this.imageList1;
            this.STAR2.Location = new System.Drawing.Point(140, 452);
            this.STAR2.Name = "STAR2";
            this.STAR2.Size = new System.Drawing.Size(35, 23);
            this.STAR2.TabIndex = 38;
            // 
            // STAR1
            // 
            this.STAR1.ImageIndex = 0;
            this.STAR1.ImageList = this.imageList1;
            this.STAR1.Location = new System.Drawing.Point(102, 452);
            this.STAR1.Name = "STAR1";
            this.STAR1.Size = new System.Drawing.Size(35, 23);
            this.STAR1.TabIndex = 37;
            // 
            // LevelQ1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(313, 510);
            this.Controls.Add(this.COUNTER);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QUSTION);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.STAR3);
            this.Controls.Add(this.STAR2);
            this.Controls.Add(this.STAR1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelQ1_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelQ1_3";
            this.Load += new System.EventHandler(this.LevelQ1_3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label STAR3;
        public System.Windows.Forms.Label STAR2;
        public System.Windows.Forms.Label STAR1;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LA2;
        private System.Windows.Forms.Label LA3;
        private System.Windows.Forms.Label lA1;
        public System.Windows.Forms.RadioButton ANSWER3;
        public System.Windows.Forms.RadioButton ANSWER2;
        public System.Windows.Forms.RadioButton ANSWER1;
        public System.Windows.Forms.Label QUSTION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label COUNTER;
    }
}