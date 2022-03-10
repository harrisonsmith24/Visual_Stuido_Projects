using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smith_11._1
{
    class Employee
    {
        // Declaring the variable to hold information
        private string _employeeName;
        private int _employeeNumber;

        // declaring an empty condtructor
        public Employee()
        {

        }

        // getter and setter foor the employee name
        public string employeeName
        {
            //getter
            get
            {
                return _employeeName;
            }
            // Setter
            set
            {
                _employeeName = value;
            }

        }

        // Declaring a getter and setter for the employee number
        public int employeeNumber
        {
            // Getter
            get { return _employeeNumber; }
            //Setter
            set { _employeeNumber = value; }
        }
    }
}
