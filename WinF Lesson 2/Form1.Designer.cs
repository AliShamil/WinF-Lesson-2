namespace WinF_Lesson_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFather = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.radioButtonFemale);
            this.groupBoxForm.Controls.Add(this.dateTimePicker1);
            this.groupBoxForm.Controls.Add(this.radioButtonMale);
            this.groupBoxForm.Controls.Add(this.label8);
            this.groupBoxForm.Controls.Add(this.label7);
            this.groupBoxForm.Controls.Add(this.textBoxPhone);
            this.groupBoxForm.Controls.Add(this.label6);
            this.groupBoxForm.Controls.Add(this.textBoxCity);
            this.groupBoxForm.Controls.Add(this.label5);
            this.groupBoxForm.Controls.Add(this.textBoxCountry);
            this.groupBoxForm.Controls.Add(this.label4);
            this.groupBoxForm.Controls.Add(this.textBoxFather);
            this.groupBoxForm.Controls.Add(this.label3);
            this.groupBoxForm.Controls.Add(this.textBoxName);
            this.groupBoxForm.Controls.Add(this.label2);
            this.groupBoxForm.Controls.Add(this.textBoxSurname);
            this.groupBoxForm.Controls.Add(this.label1);
            this.groupBoxForm.Location = new System.Drawing.Point(12, 37);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(441, 417);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Form";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(271, 367);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemale.TabIndex = 0;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 292);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(162, 367);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 19);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "BirthDate";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(123, 232);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(239, 23);
            this.textBoxPhone.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(123, 203);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(239, 23);
            this.textBoxCity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "City";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(123, 174);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(239, 23);
            this.textBoxCountry.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Country";
            // 
            // textBoxFather
            // 
            this.textBoxFather.Location = new System.Drawing.Point(123, 101);
            this.textBoxFather.Name = "textBoxFather";
            this.textBoxFather.Size = new System.Drawing.Size(239, 23);
            this.textBoxFather.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Father Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(239, 23);
            this.textBoxName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(123, 43);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(239, 23);
            this.textBoxSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(350, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 468);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(441, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(188, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearch.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 506);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxForm;
        private Button buttonLoad;
        private Button btn_save;
        private TextBox textBoxSearch;
        private RadioButton radioButtonFemale;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonMale;
        private Label label8;
        private Label label7;
        private TextBox textBoxPhone;
        private Label label6;
        private TextBox textBoxCity;
        private Label label5;
        private TextBox textBoxCountry;
        private Label label4;
        private TextBox textBoxFather;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxSurname;
        private Label label1;
    }
}