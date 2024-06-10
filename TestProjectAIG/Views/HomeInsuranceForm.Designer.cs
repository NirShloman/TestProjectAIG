using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
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
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtID;
        private ComboBox cbGender;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label HomeInsuranceTitle;
        private Label IdLabel;
        private Label GenderLabel;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtStreet;
        private ListBox lbStreetSuggestions;
        private TextBox txtCity;
        private ListBox lbCitySuggestions;

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
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(100, 50);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 20);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // lbStreetSuggestions
            // 
            this.lbStreetSuggestions.FormattingEnabled = true;
            this.lbStreetSuggestions.Location = new System.Drawing.Point(100, 80);
            this.lbStreetSuggestions.Name = "lbStreetSuggestions";
            this.lbStreetSuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbStreetSuggestions.TabIndex = 1;
            this.lbStreetSuggestions.Visible = false;
            this.lbStreetSuggestions.SelectedIndexChanged += new System.EventHandler(this.lbStreetSuggestions_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(100, 200);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 2;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lbCitySuggestions
            // 
            this.lbCitySuggestions.FormattingEnabled = true;
            this.lbCitySuggestions.Location = new System.Drawing.Point(100, 230);
            this.lbCitySuggestions.Name = "lbCitySuggestions";
            this.lbCitySuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbCitySuggestions.TabIndex = 3;
            this.lbCitySuggestions.Visible = false;
            this.lbCitySuggestions.SelectedIndexChanged += new System.EventHandler(this.lbCitySuggestions_SelectedIndexChanged);
 
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.lbCitySuggestions);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbStreetSuggestions);
            this.Controls.Add(this.txtStreet);
            this.Name = "Form4";
            this.Text = "Enter Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}