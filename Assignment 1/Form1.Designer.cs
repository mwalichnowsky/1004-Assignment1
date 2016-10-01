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
            this.language = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.Label();
            this.totalMonthlySales = new System.Windows.Forms.Label();
            this.salesBonus = new System.Windows.Forms.Label();
            this.hoursWorked = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.english = new System.Windows.Forms.RadioButton();
            this.french = new System.Windows.Forms.RadioButton();
            this.spanish = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Location = new System.Drawing.Point(378, 91);
            this.language.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(81, 20);
            this.language.TabIndex = 0;
            this.language.Text = "Language";
            this.language.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(75, 315);
            this.employeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(129, 20);
            this.employeeName.TabIndex = 1;
            this.employeeName.Text = "Employee Name:";
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Location = new System.Drawing.Point(75, 371);
            this.employeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(104, 20);
            this.employeeID.TabIndex = 2;
            this.employeeID.Text = "Employee ID:";
            // 
            // totalMonthlySales
            // 
            this.totalMonthlySales.AutoSize = true;
            this.totalMonthlySales.Location = new System.Drawing.Point(75, 529);
            this.totalMonthlySales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalMonthlySales.Name = "totalMonthlySales";
            this.totalMonthlySales.Size = new System.Drawing.Size(151, 20);
            this.totalMonthlySales.TabIndex = 3;
            this.totalMonthlySales.Text = "Total Monthly Sales:";
            // 
            // salesBonus
            // 
            this.salesBonus.AutoSize = true;
            this.salesBonus.Location = new System.Drawing.Point(75, 588);
            this.salesBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesBonus.Name = "salesBonus";
            this.salesBonus.Size = new System.Drawing.Size(103, 20);
            this.salesBonus.TabIndex = 4;
            this.salesBonus.Text = "Sales Bonus:";
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Location = new System.Drawing.Point(75, 477);
            this.hoursWorked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(154, 20);
            this.hoursWorked.TabIndex = 5;
            this.hoursWorked.Text = "Total Hours Worked:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.ForestGreen;
            this.calculateButton.Location = new System.Drawing.Point(68, 691);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.clearButton.Location = new System.Drawing.Point(272, 691);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(462, 691);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 366);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 472);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 525);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(234, 583);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(148, 26);
            this.textBox5.TabIndex = 13;
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.Location = new System.Drawing.Point(382, 135);
            this.english.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(79, 24);
            this.english.TabIndex = 14;
            this.english.TabStop = true;
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = true;
            // 
            // french
            // 
            this.french.AutoSize = true;
            this.french.Location = new System.Drawing.Point(382, 172);
            this.french.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.french.Name = "french";
            this.french.Size = new System.Drawing.Size(88, 24);
            this.french.TabIndex = 15;
            this.french.TabStop = true;
            this.french.Text = "Français";
            this.french.UseVisualStyleBackColor = true;
            // 
            // spanish
            // 
            this.spanish.AutoSize = true;
            this.spanish.Location = new System.Drawing.Point(382, 209);
            this.spanish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spanish.Name = "spanish";
            this.spanish.Size = new System.Drawing.Size(94, 24);
            this.spanish.TabIndex = 16;
            this.spanish.TabStop = true;
            this.spanish.Text = "Espagnol";
            this.spanish.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 176);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(462, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 80);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(462, 472);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 77);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(650, 771);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spanish);
            this.Controls.Add(this.french);
            this.Controls.Add(this.english);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.salesBonus);
            this.Controls.Add(this.totalMonthlySales);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.language);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label totalMonthlySales;
        private System.Windows.Forms.Label salesBonus;
        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton english;
        private System.Windows.Forms.RadioButton french;
        private System.Windows.Forms.RadioButton spanish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

