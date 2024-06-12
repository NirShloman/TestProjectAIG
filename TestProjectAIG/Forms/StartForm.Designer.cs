using System.Windows.Forms;
using System.Drawing;
using System;

namespace TestProjectAIG.Views
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private RadioButton rbUI;
        private RadioButton rbExcel;
        private Button btnNext;
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
            this.rbUI = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbUI
            // 
            this.rbUI.AutoSize = true;
            this.rbUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbUI.Location = new System.Drawing.Point(162, 72);
            this.rbUI.Name = "rbUI";
            this.rbUI.Size = new System.Drawing.Size(187, 17);
            this.rbUI.TabIndex = 0;
            this.rbUI.TabStop = true;
            this.rbUI.Text = "ייבוא נתונים ממשק משתמש (UI)";
            this.rbUI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbUI.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbExcel.Location = new System.Drawing.Point(162, 122);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(131, 17);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "ייבוא נתונים מאקסל";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(162, 190);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click;
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(418, 333);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbExcel);
            this.Controls.Add(this.rbUI);
            this.Name = "StartForm";
            this.Text = "Select Input Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
    }
}