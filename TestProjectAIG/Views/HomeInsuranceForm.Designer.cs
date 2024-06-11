using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace TestProjectAIG.Views
{
    partial class HomeInsuranceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        private TextBox txtStreet;
        private ListBox lbStreetSuggestions;
        private TextBox txtCity;
        private ListBox lbCitySuggestions;
        private Label FirstNameLabel;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label LastNameLabel;
        private TextBox textBox1;
        private Label IdLabel;
        private ComboBox cbGender;
        private Label GenderLabel;
        private Label StreetLabel;
        private Label CityLabel;
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
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbStreetSuggestions = new System.Windows.Forms.ListBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCitySuggestions = new System.Windows.Forms.ListBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(30, 183);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 20);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // lbStreetSuggestions
            // 
            this.lbStreetSuggestions.FormattingEnabled = true;
            this.lbStreetSuggestions.Location = new System.Drawing.Point(30, 213);
            this.lbStreetSuggestions.Name = "lbStreetSuggestions";
            this.lbStreetSuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbStreetSuggestions.TabIndex = 1;
            this.lbStreetSuggestions.Visible = false;
            this.lbStreetSuggestions.SelectedIndexChanged += new System.EventHandler(this.lbStreetSuggestions_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(338, 183);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 2;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lbCitySuggestions
            // 
            this.lbCitySuggestions.FormattingEnabled = true;
            this.lbCitySuggestions.Location = new System.Drawing.Point(338, 213);
            this.lbCitySuggestions.Name = "lbCitySuggestions";
            this.lbCitySuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbCitySuggestions.TabIndex = 3;
            this.lbCitySuggestions.Visible = false;
            this.lbCitySuggestions.SelectedIndexChanged += new System.EventHandler(this.lbCitySuggestions_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(526, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = ":שם פרטי";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(398, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(149, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(277, 34);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = ":שם משפחה";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(534, 93);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 13);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = ":מס\' ת\"ז";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(128, 89);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 10;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(295, 93);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(27, 13);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = ":מין";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(236, 186);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(61, 13);
            this.StreetLabel.TabIndex = 12;
            this.StreetLabel.Text = ":שם הרחוב";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(544, 190);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(54, 13);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = ":שם העיר";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(159, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click;

            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(338, 380);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += btnPrev_Click;
            
            // 
            // HomeInsuranceForm
            // 
            this.ClientSize = new System.Drawing.Size(614, 460);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.lbCitySuggestions);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbStreetSuggestions);
            this.Controls.Add(this.txtStreet);
            this.Name = "HomeInsuranceForm";
            this.Text = "Enter Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}