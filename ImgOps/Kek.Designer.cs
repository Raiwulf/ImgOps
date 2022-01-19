
using System;

namespace ImgFinder
{
    partial class Kek
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
            this.impPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clickDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.impBtn = new System.Windows.Forms.Button();
            this.wName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scanDelay = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scanCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.impPic)).BeginInit();
            this.SuspendLayout();
            // 
            // impPic
            // 
            this.impPic.Location = new System.Drawing.Point(13, 13);
            this.impPic.Name = "impPic";
            this.impPic.Size = new System.Drawing.Size(402, 276);
            this.impPic.TabIndex = 0;
            this.impPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Window Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // clickDelay
            // 
            this.clickDelay.Location = new System.Drawing.Point(371, 388);
            this.clickDelay.Name = "clickDelay";
            this.clickDelay.Size = new System.Drawing.Size(44, 20);
            this.clickDelay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delay(ms):";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(245, 390);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Clicker";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(13, 295);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(222, 127);
            this.Log.TabIndex = 9;
            this.Log.Text = "";
            // 
            // impBtn
            // 
            this.impBtn.Location = new System.Drawing.Point(241, 295);
            this.impBtn.Name = "impBtn";
            this.impBtn.Size = new System.Drawing.Size(75, 23);
            this.impBtn.TabIndex = 12;
            this.impBtn.Text = "Import";
            this.impBtn.UseVisualStyleBackColor = true;
            this.impBtn.Click += new System.EventHandler(this.impBtn_Click);
            // 
            // wName
            // 
            this.wName.Cursor = System.Windows.Forms.Cursors.Default;
            this.wName.Location = new System.Drawing.Point(323, 331);
            this.wName.Name = "wName";
            this.wName.Size = new System.Drawing.Size(100, 20);
            this.wName.TabIndex = 14;
            this.wName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delay(ms):";
            // 
            // scanDelay
            // 
            this.scanDelay.Location = new System.Drawing.Point(371, 358);
            this.scanDelay.Name = "scanDelay";
            this.scanDelay.Size = new System.Drawing.Size(44, 20);
            this.scanDelay.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scanCB
            // 
            this.scanCB.AutoSize = true;
            this.scanCB.Location = new System.Drawing.Point(245, 361);
            this.scanCB.Name = "scanCB";
            this.scanCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scanCB.Size = new System.Drawing.Size(51, 17);
            this.scanCB.TabIndex = 15;
            this.scanCB.Text = "Scan";
            this.scanCB.UseVisualStyleBackColor = true;
            this.scanCB.CheckedChanged += new System.EventHandler(this.scanCB_CheckedChanged);
            // 
            // Kek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 431);
            this.Controls.Add(this.scanCB);
            this.Controls.Add(this.wName);
            this.Controls.Add(this.impBtn);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scanDelay);
            this.Controls.Add(this.clickDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.impPic);
            this.Name = "Kek";
            this.Text = "ImgOps";
            this.Load += new System.EventHandler(this.Kek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.impPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox impPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clickDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.Button impBtn;
        private System.Windows.Forms.TextBox wName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scanDelay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox scanCB;
    }
}

