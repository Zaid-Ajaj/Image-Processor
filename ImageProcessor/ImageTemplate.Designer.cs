﻿namespace ImageProcessor
{
    partial class ImageTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "ImageTemplate";
            this.Size = new System.Drawing.Size(140, 125);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageTemplate_Paint);
            this.DoubleClick += new System.EventHandler(this.ImageTemplate_DoubleClick);
            this.Enter += new System.EventHandler(this.ImageTemplate_Enter);
            this.Leave += new System.EventHandler(this.ImageTemplate_Leave);
            this.MouseEnter += new System.EventHandler(this.ImageTemplate_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ImageTemplate_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
