﻿using System.Drawing;
using System.Windows.Forms;
using TestProjectAIG.Models;

namespace TestProjectAIG.Views
{
    partial class LifeInsuranceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbOccupation;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtID;
        private ComboBox cbGender;
        private Button btnNext;
        private Button btnPrev;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label IdLabel;
        private Label GenderLabel;
        private Label HobbiesLabel;
        private Label OccupationLabel;
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
            this.cbOccupation = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.HobbiesLabel = new System.Windows.Forms.Label();
            this.OccupationLabel = new System.Windows.Forms.Label();
            this.LifeInsuranceTitle = new System.Windows.Forms.Label();
            this.clbHobbies = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cbOccupation
            // 
            this.cbOccupation.FormattingEnabled = true;
            this.cbOccupation.Location = new System.Drawing.Point(105, 221);
            this.cbOccupation.Name = "cbOccupation";
            this.cbOccupation.Size = new System.Drawing.Size(121, 21);
            this.cbOccupation.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(384, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(126, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(384, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.cbGender.Location = new System.Drawing.Point(126, 140);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(177, 341);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click; 
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(384, 341);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "הקודם";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += btnPrev_Click;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(490, 97);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = ":שם פרטי";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(241, 97);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = ":שם משפחה";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(498, 148);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 13);
            this.IdLabel.TabIndex = 10;
            this.IdLabel.Text = ":מס\' ת\"ז";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(280, 144);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(27, 13);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = ":מין";
            // 
            // HobbiesLabel
            // 
            this.HobbiesLabel.AutoSize = true;
            this.HobbiesLabel.Location = new System.Drawing.Point(498, 224);
            this.HobbiesLabel.Name = "HobbiesLabel";
            this.HobbiesLabel.Size = new System.Drawing.Size(55, 13);
            this.HobbiesLabel.TabIndex = 12;
            this.HobbiesLabel.Text = ":תחביבים";
            // 
            // OccupationLabel
            // 
            this.OccupationLabel.AutoSize = true;
            this.OccupationLabel.Location = new System.Drawing.Point(266, 224);
            this.OccupationLabel.Name = "OccupationLabel";
            this.OccupationLabel.Size = new System.Drawing.Size(41, 13);
            this.OccupationLabel.TabIndex = 13;
            this.OccupationLabel.Text = ":עיסוק";
            // 
            // LifeInsuranceTitle
            // 
            this.LifeInsuranceTitle.AutoSize = true;
            this.LifeInsuranceTitle.Location = new System.Drawing.Point(298, 27);
            this.LifeInsuranceTitle.Name = "LifeInsuranceTitle";
            this.LifeInsuranceTitle.Size = new System.Drawing.Size(141, 13);
            this.LifeInsuranceTitle.TabIndex = 14;
            this.LifeInsuranceTitle.Text = ":ביטוח חיים - מילוי פרטים";
            // 
            // clbHobbies
            // 
            this.clbHobbies.FormattingEnabled = true;
            this.clbHobbies.Location = new System.Drawing.Point(362, 221);
            this.clbHobbies.Name = "clbHobbies";
            this.clbHobbies.Size = new System.Drawing.Size(130, 94);
            this.clbHobbies.TabIndex = 15;
            // 
            // LifeInsuranceForm
            // 
            this.ClientSize = new System.Drawing.Size(614, 460);
            this.Controls.Add(this.clbHobbies);
            this.Controls.Add(this.LifeInsuranceTitle);
            this.Controls.Add(this.OccupationLabel);
            this.Controls.Add(this.HobbiesLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbOccupation);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "LifeInsuranceForm";
            this.Text = "Life Insurance Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label LifeInsuranceTitle;
        private CheckedListBox clbHobbies;
    }
}