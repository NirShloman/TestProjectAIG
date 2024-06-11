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
            rbUI = new RadioButton();
            rbExcel = new RadioButton();
            btnNext = new Button();
            SuspendLayout();
            // 
            // rbUI
            // 
            rbUI.AutoSize = true;
            rbUI.Location = new Point(162, 72);
            rbUI.Name = "rbUI";
            rbUI.Size = new Size(67, 19);
            rbUI.TabIndex = 0;
            rbUI.TabStop = true;
            rbUI.Text = "UI Input";
            rbUI.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            rbExcel.AutoSize = true;
            rbExcel.Location = new Point(162, 122);
            rbExcel.Name = "rbExcel";
            rbExcel.Size = new Size(82, 19);
            rbExcel.TabIndex = 1;
            rbExcel.TabStop = true;
            rbExcel.Text = "Excel Input";
            rbExcel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(162, 190);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // StartForm
            // 
            ClientSize = new Size(418, 333);
            Controls.Add(btnNext);
            Controls.Add(rbExcel);
            Controls.Add(rbUI);
            Name = "StartForm";
            Text = "Select Input Method";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
    }
}