﻿namespace lab_w2
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
            this.btnOrigin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBlackWhite = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnLogTransform = new System.Windows.Forms.Button();
            this.btnPowerLaw = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenPic = new System.Windows.Forms.Button();
            this.btnGrayScale1 = new System.Windows.Forms.Button();
            this.txtBoxThreshold = new System.Windows.Forms.TextBox();
            this.txtBoxCoef = new System.Windows.Forms.TextBox();
            this.txtBoxAlpha = new System.Windows.Forms.TextBox();
            this.btnInvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigin
            // 
            this.btnOrigin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrigin.ForeColor = System.Drawing.Color.Navy;
            this.btnOrigin.Location = new System.Drawing.Point(81, 45);
            this.btnOrigin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(206, 66);
            this.btnOrigin.TabIndex = 0;
            this.btnOrigin.Text = "Origin";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(550, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gray Scale 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBlackWhite
            // 
            this.btnBlackWhite.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlackWhite.ForeColor = System.Drawing.Color.Navy;
            this.btnBlackWhite.Location = new System.Drawing.Point(810, 132);
            this.btnBlackWhite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBlackWhite.Name = "btnBlackWhite";
            this.btnBlackWhite.Size = new System.Drawing.Size(232, 66);
            this.btnBlackWhite.TabIndex = 4;
            this.btnBlackWhite.Text = "Black_White 1";
            this.btnBlackWhite.UseVisualStyleBackColor = true;
            this.btnBlackWhite.Click += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.ForeColor = System.Drawing.Color.Navy;
            this.btnNegative.Location = new System.Drawing.Point(810, 305);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(232, 66);
            this.btnNegative.TabIndex = 5;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnLogTransform
            // 
            this.btnLogTransform.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogTransform.ForeColor = System.Drawing.Color.Navy;
            this.btnLogTransform.Location = new System.Drawing.Point(807, 502);
            this.btnLogTransform.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogTransform.Name = "btnLogTransform";
            this.btnLogTransform.Size = new System.Drawing.Size(236, 66);
            this.btnLogTransform.TabIndex = 7;
            this.btnLogTransform.Text = "Log Transformation";
            this.btnLogTransform.UseVisualStyleBackColor = true;
            this.btnLogTransform.Click += new System.EventHandler(this.btnLogTransform_Click);
            // 
            // btnPowerLaw
            // 
            this.btnPowerLaw.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerLaw.ForeColor = System.Drawing.Color.Navy;
            this.btnPowerLaw.Location = new System.Drawing.Point(814, 609);
            this.btnPowerLaw.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPowerLaw.Name = "btnPowerLaw";
            this.btnPowerLaw.Size = new System.Drawing.Size(226, 66);
            this.btnPowerLaw.TabIndex = 8;
            this.btnPowerLaw.Text = "Power Law";
            this.btnPowerLaw.UseVisualStyleBackColor = true;
            this.btnPowerLaw.Click += new System.EventHandler(this.btnPowerLaw_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Navy;
            this.button10.Location = new System.Drawing.Point(428, 811);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(358, 66);
            this.button10.TabIndex = 9;
            this.button10.Text = "Median Filter";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Navy;
            this.button11.Location = new System.Drawing.Point(81, 811);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(327, 66);
            this.button11.TabIndex = 10;
            this.button11.Text = "Mean Filter";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(81, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(810, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Threshold = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 705);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "C = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(810, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alpha = ";
            // 
            // btnOpenPic
            // 
            this.btnOpenPic.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPic.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOpenPic.Location = new System.Drawing.Point(814, 45);
            this.btnOpenPic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpenPic.Name = "btnOpenPic";
            this.btnOpenPic.Size = new System.Drawing.Size(226, 66);
            this.btnOpenPic.TabIndex = 19;
            this.btnOpenPic.Text = "Open Picture";
            this.btnOpenPic.UseVisualStyleBackColor = true;
            this.btnOpenPic.Click += new System.EventHandler(this.btnOpenPic_Click);
            // 
            // btnGrayScale1
            // 
            this.btnGrayScale1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrayScale1.ForeColor = System.Drawing.Color.Navy;
            this.btnGrayScale1.Location = new System.Drawing.Point(308, 45);
            this.btnGrayScale1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGrayScale1.Name = "btnGrayScale1";
            this.btnGrayScale1.Size = new System.Drawing.Size(220, 66);
            this.btnGrayScale1.TabIndex = 21;
            this.btnGrayScale1.Text = "Gray Scale 1";
            this.btnGrayScale1.UseVisualStyleBackColor = true;
            this.btnGrayScale1.Click += new System.EventHandler(this.btnGrayScale1_Click);
            // 
            // txtBoxThreshold
            // 
            this.txtBoxThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxThreshold.Location = new System.Drawing.Point(940, 231);
            this.txtBoxThreshold.Name = "txtBoxThreshold";
            this.txtBoxThreshold.Size = new System.Drawing.Size(100, 30);
            this.txtBoxThreshold.TabIndex = 22;
            this.txtBoxThreshold.Text = "0";
            // 
            // txtBoxCoef
            // 
            this.txtBoxCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCoef.Location = new System.Drawing.Point(864, 705);
            this.txtBoxCoef.Name = "txtBoxCoef";
            this.txtBoxCoef.Size = new System.Drawing.Size(178, 30);
            this.txtBoxCoef.TabIndex = 23;
            this.txtBoxCoef.Text = "0";
            // 
            // txtBoxAlpha
            // 
            this.txtBoxAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAlpha.Location = new System.Drawing.Point(900, 774);
            this.txtBoxAlpha.Name = "txtBoxAlpha";
            this.txtBoxAlpha.Size = new System.Drawing.Size(143, 30);
            this.txtBoxAlpha.TabIndex = 24;
            this.txtBoxAlpha.Text = "0";
            // 
            // btnInvert
            // 
            this.btnInvert.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.ForeColor = System.Drawing.Color.Navy;
            this.btnInvert.Location = new System.Drawing.Point(810, 406);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(232, 66);
            this.btnInvert.TabIndex = 25;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 911);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.txtBoxAlpha);
            this.Controls.Add(this.txtBoxCoef);
            this.Controls.Add(this.txtBoxThreshold);
            this.Controls.Add(this.btnGrayScale1);
            this.Controls.Add(this.btnOpenPic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnPowerLaw);
            this.Controls.Add(this.btnLogTransform);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnBlackWhite);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOrigin);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBlackWhite;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnLogTransform;
        private System.Windows.Forms.Button btnPowerLaw;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenPic;
        private System.Windows.Forms.Button btnGrayScale1;
        private System.Windows.Forms.TextBox txtBoxThreshold;
        private System.Windows.Forms.TextBox txtBoxCoef;
        private System.Windows.Forms.TextBox txtBoxAlpha;
        private System.Windows.Forms.Button btnInvert;
    }
}
