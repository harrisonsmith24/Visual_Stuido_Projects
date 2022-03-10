using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Smith_IST271__Exam2
{
    public partial class Form1 : Form
    {
        double totalCost = 0.00;

        // Instantiate each of the products using the products class
        theProducts reeseCup = new theProducts("Reese's", "Peanut Butter cup covered in chocolate.", 20, 1.00);
        theProducts milkyWay = new theProducts("Milky Way", "Chcolate marshmellow with carmel covered in chocolate.", 18, 1.50);
        theProducts snickersBar = new theProducts("Snikers", "Peanuts and wafer bar covered in choclate.", 17, 3.00);
        theProducts kitKat = new theProducts("Kit Kat", "Four crisp wafer bars covered in chocolate.", 25, 4.00);
        theProducts tobleroneBar = new theProducts("Toblerone", "Crispy wafer bits formed into triangles for easy consumption.", 20, 6.00);

        
        public Form1()
        {
            InitializeComponent(); 
        }
        // Establishing the printinfo function
        private void PrintInfo(theProducts product)
        {
            // Taking the product that was passed in and printing the information to labels
            proNameLbl.Text = product.Name;
            descLbl.Text = product.Description;
            priceLbl.Text = "Price: $" + product.Price.ToString();
            qtyLbl.Text = "Quantity: " + product.Quantity.ToString();
        }

        // Declaring the add to order function
        private void AddToOrder(theProducts product)
        {
            // dclaring the order sting variable that will print to the list box
            string orderString = product.Name + "------------- $" + product.Price;
            // Changing the product quantity on click
            product.Quantity -= 1;
            // adding the const of the product to the total price
            totalCost += product.Price;
            // printing the total to the total label
            totalLbl.Text = "Total: " + totalCost.ToString("C", CultureInfo.CurrentCulture);
            // adding the items to the orderbox
            orderBox.Items.Add(orderString);
           
            // if statements to check if the quantity reaches 0 or anything below it disables the button
            if (snickersBar.Quantity <= 0)
            {
                addSnickers.Enabled = false;
            }
            if (milkyWay.Quantity <= 0)
            {
                addMilky.Enabled = false;
            }
            if (reeseCup.Quantity <= 0)
            {
                addReeses.Enabled = false;
            }
            if (tobleroneBar.Quantity <= 0)
            {
                addTob.Enabled = false;
            }
            if (kitKat.Quantity <= 0)
            {
                addKit.Enabled = false;
            }
        }

        // Setting each 'add' button to run the AddOrder and Print Info function on click
        private void addReeses_Click(object sender, EventArgs e)
        {
            AddToOrder(reeseCup);
            PrintInfo(reeseCup);
        }

        // Setting each description button to print the name, description, price, and quantity of the product when pressed.
        private void reeseDesBtn_Click(object sender, EventArgs e)
        {
            PrintInfo(reeseCup);
        }

        private void milkyDesBtn_Click(object sender, EventArgs e)
        {
            PrintInfo(milkyWay);
        }

        private void addMilky_Click(object sender, EventArgs e)
        {
            AddToOrder(milkyWay);
            PrintInfo(milkyWay);
        }

        private void snickersDesBtn_Click(object sender, EventArgs e)
        {
            PrintInfo(snickersBar);
        }

        private void addSnickers_Click(object sender, EventArgs e)
        {
            AddToOrder(snickersBar);
            PrintInfo(snickersBar);
        }

        private void kitDesBtn_Click(object sender, EventArgs e)
        {
            PrintInfo(kitKat);
        }

        private void addKit_Click(object sender, EventArgs e)
        {
            AddToOrder(kitKat);
            PrintInfo(kitKat);
        }

        private void tobDesBtn_Click(object sender, EventArgs e)
        {
            PrintInfo(tobleroneBar);
        }

        private void addTob_Click(object sender, EventArgs e)
        {
            AddToOrder(tobleroneBar);
            PrintInfo(tobleroneBar);
        }

        // declaring the reset button function
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clearing the order box
            orderBox.Items.Clear();

            // Setting each of the products quantity back to its original quantity
            milkyWay.Quantity = 18;
            reeseCup.Quantity = 20;
            snickersBar.Quantity = 17;
            kitKat.Quantity = 25;
            tobleroneBar.Quantity = 20;

            // Setting the total cost back to 0
            totalCost = 0.00;
            // printing the label to say 0.00
            totalLbl.Text = "0.00";

            // Enabling each of the buttons
            addMilky.Enabled = true;
            addReeses.Enabled = true;
            addKit.Enabled = true;
            addTob.Enabled = true;
            addSnickers.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // adding the sales tax to the total cost
            totalCost += totalCost * .11;
            // displaying the total cost with the sales tax added
            totalLbl.Text = "Total: " + totalCost.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
