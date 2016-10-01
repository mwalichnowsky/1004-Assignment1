using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        // Variables
        double PercentageOfHours;
        double SalesPercent;
        String Language = "English";


        /* -------- Labels ----------------------------------------------------------- */
            private void EmployeeNameLabel_Click(object sender, EventArgs e)
            {

            }
            private void EmployeeIDLabel_Click(object sender, EventArgs e)
            {

            }
            private void TotalHoursWorkedLabel_Click(object sender, EventArgs e)
            {

            }
            private void TotalMonthlySalesLabel_Click(object sender, EventArgs e)
            {

            }
            private void SalesBonusLabel_Click(object sender, EventArgs e)
            {

            }

        /* -------- End of Labels ---------------------------------------------------- */

        /* -------- Language --------------------------------------------------------- */
            private void English_CheckedChanged(object sender, EventArgs e)
            {
                Language = "English";
                EmployeeNameLabel.Text = "Employee Name:";
                EmployeeIDLabel.Text = "Employee ID:";
                TotalHoursWorkedLabel.Text = "Total Hours Worked:";
                TotalHoursWorkedLabel.Text = "Total Hours Worked:";
                SalesBonusLabel.Text = "Sales Bonus Label:";
            }

            private void French_CheckedChanged(object sender, EventArgs e)
            {
                Language = "French";

                EmployeeNameLabel.Text = "Nom de l'employé:";
                EmployeeIDLabel.Text = "ID de employé:";
                TotalHoursWorkedLabel.Text = "Total des heures travaillées:";
                TotalHoursWorkedLabel.Text = "Total des heures travaillées:";
                SalesBonusLabel.Text = "Bonus de vente Étiquette:";
            }

            private void Spanish_CheckedChanged(object sender, EventArgs e)
            {
                Language = "Spanish";
                EmployeeNameLabel.Text = "Nombre de empleado:";
                EmployeeIDLabel.Text = "ID de empleado:";
                TotalHoursWorkedLabel.Text = "Total de horas trabajadas:";
                TotalHoursWorkedLabel.Text = "Total de horas trabajadas:";
                SalesBonusLabel.Text = "Bono de ventas de etiquetas:";
            }

        /* -------- End of Language -------------------------------------------------- */

        /* -------- Buttons --------------------------------------------------------- */
            private void CalculateButton_Click(object sender, EventArgs e)
            {
                Calculate();
            }

            private void Calculate()
            {
                try
                {
                    try
                    {
                        /* Divide the Total Hours Worked by 160. This will determine the Percentage of
                         * hours worked during the bonus period. 
                         */
                        PercentageOfHours = Convert.ToDouble(TotalHoursWorked.Text);
                        PercentageOfHours = PercentageOfHours / 160;
                    }
                    catch
                    {
                        if (Language == "English")
                        {
                            MessageBox.Show(TotalHoursWorked.Text + " is an invalid entry.");
                        }
                        else if (Language == "French")
                        {
                            MessageBox.Show(TotalHoursWorked.Text + " est une entrée non valide.");
                        }
                        else if (Language == "Spanish")
                        {
                            MessageBox.Show(TotalHoursWorked.Text + " es una entrada no válida.");
                        }
                    }

                    try
                    {
                        /* Multiply Total Monthly Sales by 0.02 – This will calculate 2% of Sales which is
                         * the Total Bonus Amount. 
                         */
                        SalesPercent = Convert.ToDouble(TotalMonthlySales.Text);
                        SalesPercent = SalesPercent * 0.02;
                    }
                    catch
                    {
                        if (Language == "English")
                        {
                            MessageBox.Show(TotalMonthlySales.Text + " is an invalid entry.");
                        }
                        else if (Language == "French")
                        {
                            MessageBox.Show(":( est une entrée non valide.");
                        }
                        else if (Language == "Spanish")
                        {
                            MessageBox.Show(":( es una entrada no válida.");
                        }
                    }

                    try
                    {
                        /* Multiply the Percentage of Hours Worked by the Total Bonus Amount. This will
                         * determine the value you need to display in the Sales Bonus Text Field.
                         */
                        SalesBonus.Text = Convert.ToString(PercentageOfHours * SalesPercent);
                    }
                    catch
                    {
                        if (Language == "English")
                        {
                            MessageBox.Show(":( There was an error calculating your sales bonus.");
                        }
                        else if (Language == "French")
                        {
                            MessageBox.Show(":( Il y avait une erreur de calcul de votre prime de vente.");
                        }
                        else if (Language == "Spanish")
                        {
                            MessageBox.Show(":( Hubo un error al calcular la bonificación de ventas.");
                        }
                    }
                }
                // Show error message to catch overall errors.
                catch
                {
                    MessageBox.Show(":( General error.");
                }
            } // End of Calculate method.

            private void Print_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Job has been sent to the printer.");
            }

            private void ClearButton_Click(object sender, EventArgs e)
            {
                try
                {
                    // This clear each field individually.
                    SalesBonus.Text = String.Empty;
                    TotalHoursWorked.Text = String.Empty;
                    TotalMonthlySales.Text = String.Empty;
                    EmployeeName.Text = String.Empty;
                    EmployeeID.Text = String.Empty;
                }
                catch
                {
                    MessageBox.Show(":( There was an error clearing the form");
                }
            }

            private void ExitButton_Click(object sender, /*FormClosing*/EventArgs e)
            {
            /* Determines whether the user wants to exit the application and either cancels or exits. 
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // The user wants to exit the application. Close everything down.
                //Application.Exit(); */
            this.Close();
               // } 
            } // End of ExitButton_Click method.

        /* -------- End of Buttons -------------------------------------------------- */





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void SalesBonus_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void TotalHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

 


    } // End of form1 class.
} // End of namespace Assignment 1.
