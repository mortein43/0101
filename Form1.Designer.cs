﻿namespace _0101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_start = new Button();
            btn_stop = new Button();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(71, 64);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(89, 23);
            btn_start.TabIndex = 0;
            btn_start.Text = "Продовжити";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(71, 144);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(89, 23);
            btn_stop.TabIndex = 0;
            btn_stop.Text = "Зупинити";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 251);
            Controls.Add(btn_stop);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button btn_stop;
    }
}