﻿namespace FlickBook.Views
{
    partial class Riwayat
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
            this.riwayatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // riwayatLabel
            // 
            this.riwayatLabel.AutoSize = true;
            this.riwayatLabel.Location = new System.Drawing.Point(82, 65);
            this.riwayatLabel.Name = "riwayatLabel";
            this.riwayatLabel.Size = new System.Drawing.Size(94, 13);
            this.riwayatLabel.TabIndex = 0;
            this.riwayatLabel.Text = "Riwayat Transaksi";
            // 
            // Riwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 562);
            this.Controls.Add(this.riwayatLabel);
            this.Name = "Riwayat";
            this.Text = "Riwayat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label riwayatLabel;
    }
}