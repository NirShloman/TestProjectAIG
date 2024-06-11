using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System;

namespace TestProjectAIG.Views
{
    partial class InsuranceOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private RadioButton rbHomeInsurance;
        private RadioButton rbLifeInsurance;
        private Button btnNext;
        private Button btnPrev;
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
            this.rbHomeInsurance = new System.Windows.Forms.RadioButton();
            this.rbLifeInsurance = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbHomeInsurance
            // 
            this.rbHomeInsurance.AutoSize = true;
            this.rbHomeInsurance.Location = new System.Drawing.Point(151, 70);
            this.rbHomeInsurance.Name = "rbHomeInsurance";
            this.rbHomeInsurance.Size = new System.Drawing.Size(103, 17);
            this.rbHomeInsurance.TabIndex = 0;
            this.rbHomeInsurance.TabStop = true;
            this.rbHomeInsurance.Text = "Home Insurance";
            this.rbHomeInsurance.UseVisualStyleBackColor = true;
            // 
            // rbLifeInsurance
            // 
            this.rbLifeInsurance.AutoSize = true;
            this.rbLifeInsurance.Location = new System.Drawing.Point(151, 120);
            this.rbLifeInsurance.Name = "rbLifeInsurance";
            this.rbLifeInsurance.Size = new System.Drawing.Size(92, 17);
            this.rbLifeInsurance.TabIndex = 1;
            this.rbLifeInsurance.TabStop = true;
            this.rbLifeInsurance.Text = "Life Insurance";
            this.rbLifeInsurance.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(80, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(243, 210);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += btnPrev_Click;
            // 
            // InsuranceOptions
            // 
            this.ClientSize = new System.Drawing.Size(418, 333);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbLifeInsurance);
            this.Controls.Add(this.rbHomeInsurance);
            this.Name = "InsuranceOptions";
            this.Text = "Select Policy Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion


    }
}