using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smith_11._1
{
    // declaring the shift supervisor class
    class ShiftSupervisor : Employee
    {
        // declaring the properties
        private double _supervisorSalary;
        private double _yearlyBonus;

        // empty constructor for the class
        public ShiftSupervisor()
        {

        }

        // getter and setter for the supervisor salary
        public double supervisorSalary
        {
            get { return _supervisorSalary; }
            set { _supervisorSalary = value; }
        }

        // getter and setter for the yearlyBonus 
        public double yearlyBonus
        {
            get { return _yearlyBonus; }
            set { _yearlyBonus = value; }
        }
    }
}
