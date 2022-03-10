using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaring the formto the chargesForm variable name
            TotalCharges chargesForm = new TotalCharges();

            // Setting the total cost to the values returned from each of the functions
            int totalSemesterCost = FoodCharge() + DormCharge();

            // writing the information on the charges form
            chargesForm.totalChargeLbl.Text = "$" + totalSemesterCost.ToString() + " per semester.";
            // Displaying the dialog to the user 
            chargesForm.ShowDialog();
            
            
        }

        // Declaring the Food Charge Function
        public int FoodCharge()
        {
            // Setting the food cost to 0
            int foodCost = 0;

            // If statment to check which value was selected
            if (sevenMeals.Checked)
            {
                // set the price
                foodCost += 600;
            }
            // If statment to check which value was selected
            else if (fourteenMeals.Checked)
            {
                // set the price
                foodCost += 1200;
            }
            // If statment to check which value was selected
            else if (unlimMeals.Checked)
            {
                // set the price
                foodCost += 1700;
            }
            // return the cost
            return foodCost;
        }

        public int DormCharge()
        {
            // Setting the dorm cost to 0
            int dormCost = 0;
            // If statment to check which value was selected
            if (allenHall.Checked)
            {
                // set the price
                dormCost += 1500;
            }
            // If statment to check which value was selected
            else if (pikeHall.Checked)
            {
                // set the price
                dormCost += 1500;
            }
            // If statment to check which value was selected
            else if (farthingHall.Checked)
            {
                // set the price
                dormCost += 1800;
            }
            // If statment to check which value was selected
            else if (uniSuites.Checked)
            {
                // set the price
                dormCost += 2500;
            }

            // return the cost
            return dormCost;
        }
    }
}
