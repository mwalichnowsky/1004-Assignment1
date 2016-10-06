namespace Assignment_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.TotalHoursWorked = new System.Windows.Forms.TextBox();
            this.TotalMonthlySales = new System.Windows.Forms.TextBox();
            this.SalesBonus = new System.Windows.Forms.TextBox();
            this.English = new System.Windows.Forms.RadioButton();
            this.French = new System.Windows.Forms.RadioButton();
            this.Spanish = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LanguagesLabel = new System.Windows.Forms.GroupBox();
            this.Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LanguagesLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(22, 233);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(129, 20);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Employee Name:";
            this.EmployeeNameLabel.Click += new System.EventHandler(this.EmployeeNameLabel_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(22, 281);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(104, 20);
            this.EmployeeIDLabel.TabIndex = 2;
            this.EmployeeIDLabel.Text = "Employee ID:";
            this.EmployeeIDLabel.Click += new System.EventHandler(this.EmployeeIDLabel_Click);
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(21, 385);
            this.TotalMonthlySalesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(151, 20);
            this.TotalMonthlySalesLabel.TabIndex = 3;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            this.TotalMonthlySalesLabel.Click += new System.EventHandler(this.TotalMonthlySalesLabel_Click);
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(21, 437);
            this.SalesBonusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(103, 20);
            this.SalesBonusLabel.TabIndex = 4;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            this.SalesBonusLabel.Click += new System.EventHandler(this.SalesBonusLabel_Click);
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(21, 332);
            this.TotalHoursWorkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(154, 20);
            this.TotalHoursWorkedLabel.TabIndex = 5;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked:";
            this.TotalHoursWorkedLabel.Click += new System.EventHandler(this.TotalHoursWorkedLabel_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.ForestGreen;
            this.CalculateButton.Location = new System.Drawing.Point(25, 521);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(112, 35);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Location = new System.Drawing.Point(297, 521);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 35);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "ClearAll";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(430, 521);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(270, 230);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(148, 26);
            this.EmployeeName.TabIndex = 9;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(270, 275);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(148, 26);
            this.EmployeeID.TabIndex = 10;
            // 
            // TotalHoursWorked
            // 
            this.TotalHoursWorked.Location = new System.Drawing.Point(270, 329);
            this.TotalHoursWorked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalHoursWorked.MaxLength = 160;
            this.TotalHoursWorked.Name = "TotalHoursWorked";
            this.TotalHoursWorked.Size = new System.Drawing.Size(148, 26);
            this.TotalHoursWorked.TabIndex = 11;
            this.TotalHoursWorked.TextChanged += new System.EventHandler(this.TotalHoursWorked_TextChanged);
            // 
            // TotalMonthlySales
            // 
            this.TotalMonthlySales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMonthlySales.Location = new System.Drawing.Point(270, 383);
            this.TotalMonthlySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalMonthlySales.Name = "TotalMonthlySales";
            this.TotalMonthlySales.Size = new System.Drawing.Size(148, 26);
            this.TotalMonthlySales.TabIndex = 12;
            this.TotalMonthlySales.TextChanged += new System.EventHandler(this.TotalMonthlySales_TextChanged);
            // 
            // SalesBonus
            // 
            this.SalesBonus.Location = new System.Drawing.Point(270, 434);
            this.SalesBonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesBonus.Name = "SalesBonus";
            this.SalesBonus.ReadOnly = true;
            this.SalesBonus.Size = new System.Drawing.Size(148, 26);
            this.SalesBonus.TabIndex = 13;
            this.SalesBonus.TextChanged += new System.EventHandler(this.SalesBonus_TextChanged);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Checked = true;
            this.English.Location = new System.Drawing.Point(31, 40);
            this.English.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(79, 24);
            this.English.TabIndex = 14;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.English_CheckedChanged);
            // 
            // French
            // 
            this.French.AutoSize = true;
            this.French.Location = new System.Drawing.Point(31, 74);
            this.French.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.French.Name = "French";
            this.French.Size = new System.Drawing.Size(88, 24);
            this.French.TabIndex = 15;
            this.French.Text = "Français";
            this.French.UseVisualStyleBackColor = true;
            this.French.CheckedChanged += new System.EventHandler(this.French_CheckedChanged);
            // 
            // Spanish
            // 
            this.Spanish.AutoSize = true;
            this.Spanish.Location = new System.Drawing.Point(31, 108);
            this.Spanish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Spanish.Name = "Spanish";
            this.Spanish.Size = new System.Drawing.Size(94, 24);
            this.Spanish.TabIndex = 16;
            this.Spanish.Text = "Espagnol";
            this.Spanish.UseVisualStyleBackColor = true;
            this.Spanish.CheckedChanged += new System.EventHandler(this.Spanish_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 179);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LanguagesLabel
            // 
            this.LanguagesLabel.Controls.Add(this.English);
            this.LanguagesLabel.Controls.Add(this.French);
            this.LanguagesLabel.Controls.Add(this.Spanish);
            this.LanguagesLabel.Location = new System.Drawing.Point(371, 26);
            this.LanguagesLabel.Name = "LanguagesLabel";
            this.LanguagesLabel.Size = new System.Drawing.Size(171, 159);
            this.LanguagesLabel.TabIndex = 20;
            this.LanguagesLabel.TabStop = false;
            this.LanguagesLabel.Text = "Languages";
            this.LanguagesLabel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.SteelBlue;
            this.Print.Location = new System.Drawing.Point(160, 521);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(112, 35);
            this.Print.TabIndex = 21;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(571, 603);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.LanguagesLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalesBonus);
            this.Controls.Add(this.TotalMonthlySales);
            this.Controls.Add(this.TotalHoursWorked);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LanguagesLabel.ResumeLayout(false);
            this.LanguagesLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label TotalHoursWorkedLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.TextBox TotalHoursWorked;
        private System.Windows.Forms.TextBox TotalMonthlySales;
        private System.Windows.Forms.TextBox SalesBonus;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.RadioButton French;
        private System.Windows.Forms.RadioButton Spanish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox LanguagesLabel;
        private System.Windows.Forms.Button Print;
    }
}

