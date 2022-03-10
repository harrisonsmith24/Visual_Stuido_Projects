using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smith_11._1
{
    // Allowing the production worker class to be inherited by the employee class
    class ProductionWorker : Employee
    {
        // declaring variables for the production worker
        private int _shiftNumber;
        private double _hourlyPayRate;

        // using an empty constructor
        public ProductionWorker()
        {

        }

        // Getter and setter for the shift number 
        public int shiftNumber
        {
            // Getter 
            get { return _shiftNumber; }
            // Setter
            set { _shiftNumber = value; }
        }

        // Getter and Setter for the hourly pay rate
        public double hourlyPayRate
        {
            // getter 
            get { return _hourlyPayRate; }
            // setter
            set { _hourlyPayRate = value; }
            
        }
    }
}
