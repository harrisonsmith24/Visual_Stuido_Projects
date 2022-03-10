using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_Exam2
{
    public partial class Form1 : Form
    {

        // Harrison Smith
        // CPT 230 Prof. Carman
        // 8/4/2021 Exam 2
        public Form1()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            // Calling the function to display the boxes on the form to enter the data for calculations
            DisplayTextBoxForBudget();
        }

        private void DisplayTextBoxForBudget()
        {
            // Declaring Variables
            int numOfBills;
            
            // Parsing the info from the text box to be used in the if statement
            numOfBills = int.Parse(billsTxt.Text);
            
            // Setting the if statement to print the right amount line for the user to enter bills
            if (numOfBills == 0 || numOfBills > 4)
            {
                // printing an error
                errorLbl.Visible = true;
            }

            // Displaying one box for data
            else if (numOfBills == 1)
            {
                // Setting the visibility to true to display the boxes and the calculation button
                billLBL1.Visible = true;
                billTxt1.Visible = true;

                errorLbl.Visible = false;

                calcBtn.Visible = true;
            }

            // Displaying 2 boxes for data entry
            else if (numOfBills == 2)
            {
                // Setting the visibility to true to display the boxes and the calculation button
                billLBL1.Visible = true;
                billTxt1.Visible = true;
                billLBL2.Visible = true;
                billTxt2.Visible = true;

                errorLbl.Visible = false;

                calcBtn.Visible = true;
            }

            // Displaying 3 boxes for data entry
            else if (numOfBills == 3)
            {
                // Setting the visibility to true to display the boxes and the calculation button
                billLBL1.Visible = true;
                billTxt1.Visible = true;
                billLBL2.Visible = true;
                billTxt2.Visible = true;
                billLBL3.Visible = true;
                billTxt3.Visible = true;

                errorLbl.Visible = false;

                calcBtn.Visible = true;
            }

            // Displaying 4 boxes for data entry
            else if (numOfBills == 4)
            {
                // Setting the visibility to true to display the boxes and the calculation button
                billLBL1.Visible = true;
                billTxt1.Visible = true;
                billLBL2.Visible = true;
                billTxt2.Visible = true;
                billLBL3.Visible = true;
                billTxt3.Visible = true;
                billLBL4.Visible = true;
                billTxt4.Visible = true;

                errorLbl.Visible = false;

                calcBtn.Visible = true;
            }



        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Restarting the application on the click of the reset button
            Application.Restart();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            // Calling the display total function
            DisplayTotal();
        }

        // Defining the Calculate Total function
        public double CalculateTotal()
        {
            // Declaring all the variables
            double totalBills;
            int numOfBills;
            double billAmt1;
            double billAmt2;
            double billAmt3;
            double billAmt4;

            // Setting the Variables to to parse hte info entered by the user
            totalBills = 0;
            numOfBills = int.Parse(billsTxt.Text);
            billAmt1 = double.Parse(billTxt1.Text);
            billAmt2 = double.Parse(billTxt2.Text);
            billAmt3 = double.Parse(billTxt3.Text);
            billAmt4 = double.Parse(billTxt4.Text);

            // If statement to calculate all the totals for the bills depending on the amount of bills the user has
            if (numOfBills == 1)
            {
                totalBills = billAmt1;
            }

            else if (numOfBills == 2)
            {
                totalBills = billAmt1 + billAmt2;
            }

            else if (numOfBills == 3)
            {
                totalBills = billAmt1 + billAmt2 + billAmt3;
            }

            else if (numOfBills == 3)
            {
                totalBills = billAmt1 + billAmt2 + billAmt3 + billAmt4;
            }

            return totalBills;
        }

        // Defining the display total function
        private void DisplayTotal()
        {
            // Setting the variables
            double budgetAmt;
            double finalResult;

            // Defining the value of the variables by paring the ifo enterd by the user
            budgetAmt = double.Parse(budgetTxt.Text);

            // Subtractiong the total of the bills from the budget amount so that the remainder is own and used in the if statement
            finalResult = budgetAmt - CalculateTotal();

            // Printing a final statment to the form to inform the user if they exceded or reached their budget.
            if (finalResult > 0)
            {
                totalLbl.Text = "Your budget for " + monthComboBox.Text + " was " + budgetTxt.Text + ". \n" +
                                "You had " + billsTxt.Text + "bill(s) this month totaling at " + CalculateTotal() + ". \n" +
                                "Your bills this month did not exceed your monthly budget. You have $" + finalResult + ".";
                                
            }

            if (finalResult < 0)
            {
                totalLbl.Text = "Your budget for " + monthComboBox.Text + " was " + budgetTxt.Text + ". \n" +
                                "You had " + billsTxt.Text + "bill(s) this month totaling at " + CalculateTotal() + ". \n" +
                                "Your bills this month exceeded your monthly budget by $" + Math.Abs(finalResult) + ".";

            }

        }
    }
}
