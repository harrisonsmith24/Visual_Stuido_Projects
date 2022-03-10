using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smith_10._4
{
    class Employee
    {
        //Declare Variables
        private string _name, _department, _position;
        private int _IdNumber;

        // Constructor to declare the default values
        public Employee()
        {
            _name = "";
            _department = "";
            _position = "";
            _IdNumber = 0;
        }

        // Overloaded constructor that can accept more than one variable type
        public Employee(string name, string department, string position, int IdNumber)
        {
            _name = name;
            _department = department;
            _position = position;
            _IdNumber = IdNumber;
        }
        // Constructor to set values to the employee name and id number
        public Employee(string name, int IdNumber)
        {
            _name = name;
            _IdNumber = IdNumber;
            _position = "";
            _department = "";
        }
        // Getter and setter for the name variable
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        // Getter and setter for the department variable
        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }
        // Getter and setter for the position variable
        public string Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }
        // Getter and setter for the Id number variable
        public int IdNumber
        {
            get
            {
                return _IdNumber;
            }

            set
            {
                _IdNumber = value;
            }
        }
    }
}
