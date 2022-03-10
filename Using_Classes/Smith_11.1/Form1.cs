using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ShiftSupervisor myWorker = new ShiftSupervisor();

        // Method for submit button click
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // try and catch parameter to check for errors
            try
            {
                // Setting each of the variables in the class name

                // Employee Name
                myWorker.employeeName = empNameTxt.Text;
                // Employee Number
                myWorker.employeeNumber = int.Parse(empNumTxt.Text);
                // Shift Number
                myWorker.supervisorSalary = double.Parse(supervisorSalaryNum.Text);
                // Pay Rate
                myWorker.yearlyBonus = double.Parse(supervisorBonusNum.Text);

                

                
                // Setting the label to rpint out the entered information
                submitTxt.Text = "Name: " + myWorker.employeeName + " / Number: " + myWorker.employeeNumber + " / $" + myWorker.supervisorSalary  + " / $" + myWorker.yearlyBonus ;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
