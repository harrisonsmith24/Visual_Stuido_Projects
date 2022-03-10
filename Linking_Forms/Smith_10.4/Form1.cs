using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_10._4
{
    // Harrison Smith 
    // Exercise 10.4
    // Prof. Carman
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Run program on load of the form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare each employee as a variable from the employee class 
            Employee employee01 = new Employee("Susan Meyers", "Accounting", "Vice President", 47889);
            Employee employee02 = new Employee("Mark Jones", "Info Tech", "Programmer", 39119);
            Employee employee03 = new Employee("Joy Rogers", "Manufacturing", "Engineer", 81774);

            // Print out the employee infor to each of the labels in the program
            empLbl1.Text = employee01.Name + "       " + employee01.Department + "       " + employee01.Position + "      " + employee01.IdNumber.ToString();
            empLbl2.Text = employee02.Name + "       " + employee02.Department + "       " + employee02.Position + "      " + employee02.IdNumber.ToString();
            empblL3.Text = employee03.Name + "       " + employee03.Department + "       " + employee03.Position + "      " + employee03.IdNumber.ToString();
        }
    }
}
