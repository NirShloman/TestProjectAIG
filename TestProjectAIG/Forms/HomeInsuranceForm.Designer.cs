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
            this.FloorLabel = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.HouseNumberLabel = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.אסאApartmentNumber = new System.Windows.Forms.TextBox();
            this.ApartmentNumberLabel = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApartmentTypeLabel = new System.Windows.Forms.Label();
            this.cbApartmentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStructureType = new System.Windows.Forms.ComboBox();
            this.HomeInsuranceTitle = new System.Windows.Forms.Label();
            this.txtHomeSize = new System.Windows.Forms.TextBox();
            this.HomeSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(58, 198);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 20);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // lbStreetSuggestions
            // 
            this.lbStreetSuggestions.FormattingEnabled = true;
            this.lbStreetSuggestions.Location = new System.Drawing.Point(58, 228);
            this.lbStreetSuggestions.Name = "lbStreetSuggestions";
            this.lbStreetSuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbStreetSuggestions.TabIndex = 1;
            this.lbStreetSuggestions.Visible = false;
            this.lbStreetSuggestions.SelectedIndexChanged += new System.EventHandler(this.lbStreetSuggestions_SelectedIndexChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(366, 198);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 2;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lbCitySuggestions
            // 
            this.lbCitySuggestions.FormattingEnabled = true;
            this.lbCitySuggestions.Location = new System.Drawing.Point(366, 228);
            this.lbCitySuggestions.Name = "lbCitySuggestions";
            this.lbCitySuggestions.Size = new System.Drawing.Size(200, 95);
            this.lbCitySuggestions.TabIndex = 3;
            this.lbCitySuggestions.Visible = false;
            this.lbCitySuggestions.SelectedIndexChanged += new System.EventHandler(this.lbCitySuggestions_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(554, 95);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = ":שם פרטי";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(426, 92);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(177, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(305, 95);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = ":שם משפחה";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(562, 154);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 13);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = ":מס\' ת\"ז";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.cbGender.Location = new System.Drawing.Point(221, 150);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 10;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(371, 155);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(27, 13);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = ":מין";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(264, 201);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(61, 13);
            this.StreetLabel.TabIndex = 12;
            this.StreetLabel.Text = ":שם הרחוב";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(572, 205);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(54, 13);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = ":שם העיר";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(195, 491);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(374, 491);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "הקודם";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += btnPrev_Click; 
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Location = new System.Drawing.Point(380, 345);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(36, 13);
            this.FloorLabel.TabIndex = 18;
            this.FloorLabel.Text = ":קומה";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(474, 342);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(70, 20);
            this.txtHouseNumber.TabIndex = 17;
            // 
            // HouseNumberLabel
            // 
            this.HouseNumberLabel.AutoSize = true;
            this.HouseNumberLabel.Location = new System.Drawing.Point(572, 345);
            this.HouseNumberLabel.Name = "HouseNumberLabel";
            this.HouseNumberLabel.Size = new System.Drawing.Size(48, 13);
            this.HouseNumberLabel.TabIndex = 16;
            this.HouseNumberLabel.Text = ":מס\' בית";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(287, 342);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(70, 20);
            this.txtFloor.TabIndex = 19;
            // 
            // ApartmentNumber
            // 
            this.אסאApartmentNumber.Location = new System.Drawing.Point(81, 342);
            this.אסאApartmentNumber.Name = "אסאApartmentNumber";
            this.אסאApartmentNumber.Size = new System.Drawing.Size(70, 20);
            this.אסאApartmentNumber.TabIndex = 21;
            // 
            // ApartmentNumberLabel
            // 
            this.ApartmentNumberLabel.AutoSize = true;
            this.ApartmentNumberLabel.Location = new System.Drawing.Point(174, 345);
            this.ApartmentNumberLabel.Name = "ApartmentNumberLabel";
            this.ApartmentNumberLabel.Size = new System.Drawing.Size(54, 13);
            this.ApartmentNumberLabel.TabIndex = 20;
            this.ApartmentNumberLabel.Text = ":מס\' דירה";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(73, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 20);
            this.txtAge.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = ":גיל";
            // 
            // ApartmentTypeLabel
            // 
            this.ApartmentTypeLabel.AutoSize = true;
            this.ApartmentTypeLabel.Location = new System.Drawing.Point(583, 398);
            this.ApartmentTypeLabel.Name = "ApartmentTypeLabel";
            this.ApartmentTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.ApartmentTypeLabel.TabIndex = 25;
            this.ApartmentTypeLabel.Text = ":סוג הדירה";
            // 
            // cbApartmentType
            // 
            this.cbApartmentType.FormattingEnabled = true;
            this.cbApartmentType.Location = new System.Drawing.Point(451, 393);
            this.cbApartmentType.Name = "cbApartmentType";
            this.cbApartmentType.Size = new System.Drawing.Size(121, 21);
            this.cbApartmentType.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = ":סוג המבנה";
            // 
            // cbStructureType
            // 
            this.cbStructureType.FormattingEnabled = true;
            this.cbStructureType.Location = new System.Drawing.Point(248, 393);
            this.cbStructureType.Name = "cbStructureType";
            this.cbStructureType.Size = new System.Drawing.Size(98, 21);
            this.cbStructureType.TabIndex = 26;
            // 
            // HomeInsuranceTitle
            // 
            this.HomeInsuranceTitle.AutoSize = true;
            this.HomeInsuranceTitle.Location = new System.Drawing.Point(285, 31);
            this.HomeInsuranceTitle.Name = "HomeInsuranceTitle";
            this.HomeInsuranceTitle.Size = new System.Drawing.Size(139, 13);
            this.HomeInsuranceTitle.TabIndex = 28;
            this.HomeInsuranceTitle.Text = "ביטוח דירה - מילוי פרטים";
            // 
            // txtHomeSize
            // 
            this.txtHomeSize.Location = new System.Drawing.Point(47, 394);
            this.txtHomeSize.Name = "txtHomeSize";
            this.txtHomeSize.Size = new System.Drawing.Size(70, 20);
            this.txtHomeSize.TabIndex = 30;
            // 
            // HomeSizeLabel
            // 
            this.HomeSizeLabel.AutoSize = true;
            this.HomeSizeLabel.Location = new System.Drawing.Point(123, 398);
            this.HomeSizeLabel.Name = "HomeSizeLabel";
            this.HomeSizeLabel.Size = new System.Drawing.Size(97, 13);
            this.HomeSizeLabel.TabIndex = 29;
            this.HomeSizeLabel.Text = ":גודל הדירה (מ\"ר)";
            // 
            // HomeInsuranceForm
            // 
            this.ClientSize = new System.Drawing.Size(699, 568);
            this.Controls.Add(this.txtHomeSize);
            this.Controls.Add(this.HomeSizeLabel);
            this.Controls.Add(this.HomeInsuranceTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStructureType);
            this.Controls.Add(this.ApartmentTypeLabel);
            this.Controls.Add(this.cbApartmentType);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.אסאApartmentNumber);
            this.Controls.Add(this.ApartmentNumberLabel);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.FloorLabel);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.HouseNumberLabel);
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
        private Label FloorLabel;
        private TextBox txtHouseNumber;
        private Label HouseNumberLabel;
        private TextBox txtFloor;
        private TextBox אסאApartmentNumber;
        private Label ApartmentNumberLabel;
        private TextBox txtAge;
        private Label label1;
        private Label ApartmentTypeLabel;
        private ComboBox cbApartmentType;
        private Label label2;
        private ComboBox cbStructureType;
        private Label HomeInsuranceTitle;
        private TextBox txtHomeSize;
        private Label HomeSizeLabel;
    }
}