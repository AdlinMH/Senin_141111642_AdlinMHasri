﻿namespace Latihan_4_1
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
            this.rTTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tBtnBold = new System.Windows.Forms.ToolStripButton();
            this.tBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tscbFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.tscbFontColor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTTextBox
            // 
            this.rTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTTextBox.Location = new System.Drawing.Point(20, 88);
            this.rTTextBox.Name = "rTTextBox";
            this.rTTextBox.Size = new System.Drawing.Size(600, 332);
            this.rTTextBox.TabIndex = 0;
            this.rTTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbFontSize,
            this.tBtnBold,
            this.tBtnItalic,
            this.tBtnUnderline,
            this.tscbFontFamily,
            this.tscbFontColor});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscbFontSize
            // 
            this.tscbFontSize.Name = "tscbFontSize";
            this.tscbFontSize.Size = new System.Drawing.Size(121, 25);
            this.tscbFontSize.SelectedIndexChanged += new System.EventHandler(this.tscbFontSize_SelectedIndexChanged);
            this.tscbFontSize.LostFocus += new System.EventHandler(this.tscbFontSize_LostFocus);
            // 
            // tBtnBold
            // 
            this.tBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtnBold.Image = global::Latihan_4_1.Properties.Resources.bold;
            this.tBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnBold.Name = "tBtnBold";
            this.tBtnBold.Size = new System.Drawing.Size(23, 22);
            this.tBtnBold.Text = "Bold";
            this.tBtnBold.Click += new System.EventHandler(this.tBtnBold_Click);
            // 
            // tBtnItalic
            // 
            this.tBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtnItalic.Image = global::Latihan_4_1.Properties.Resources.italic;
            this.tBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnItalic.Name = "tBtnItalic";
            this.tBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tBtnItalic.Text = "Italic";
            this.tBtnItalic.Click += new System.EventHandler(this.tBtnItalic_Click);
            // 
            // tBtnUnderline
            // 
            this.tBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtnUnderline.Image = global::Latihan_4_1.Properties.Resources.underline;
            this.tBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtnUnderline.Name = "tBtnUnderline";
            this.tBtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tBtnUnderline.Text = "Underline";
            this.tBtnUnderline.Click += new System.EventHandler(this.tBtnUnderline_Click);
            // 
            // tscbFontFamily
            // 
            this.tscbFontFamily.Name = "tscbFontFamily";
            this.tscbFontFamily.Size = new System.Drawing.Size(121, 25);
            this.tscbFontFamily.SelectedIndexChanged += new System.EventHandler(this.tscbFontFamily_SelectedIndexChanged);
            this.tscbFontFamily.LostFocus += new System.EventHandler(this.tscbFontFamily_LostFocus);
            // 
            // tscbFontColor
            // 
            this.tscbFontColor.Name = "tscbFontColor";
            this.tscbFontColor.Size = new System.Drawing.Size(121, 25);
            this.tscbFontColor.SelectedIndexChanged += new System.EventHandler(this.tscbFontColor_SelectedIndexChanged);
            this.tscbFontColor.LostFocus += new System.EventHandler(this.tscbFontColor_LostFocus);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rTTextBox);
            this.Name = "Form1";
            this.Text = "Latihan 3_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbFontSize;
        private System.Windows.Forms.ToolStripButton tBtnBold;
        private System.Windows.Forms.ToolStripButton tBtnItalic;
        private System.Windows.Forms.ToolStripButton tBtnUnderline;
        private System.Windows.Forms.ToolStripComboBox tscbFontFamily;
        private System.Windows.Forms.ToolStripComboBox tscbFontColor;
    }
}

