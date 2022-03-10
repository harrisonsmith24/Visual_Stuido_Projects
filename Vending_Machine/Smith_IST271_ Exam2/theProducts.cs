using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smith_IST271__Exam2
{
    class theProducts
    {
        // Declare Variables
        private string _name, _description;
        private int _quantity;
        private double _price;

        // Construtor to declare the dfault values
        public theProducts()
        {
            _name = "";
            _description = "";
            _quantity = 0;
            _price = 0.00;
        }

        // Overloaded Constructor that can accept more than one type of variable.
        public theProducts(string name, string description, int quantity, double price)
        {
            _name = name;
            _description = description;
            _quantity = quantity;
            _price = price;
        }

        // Get and Set for name
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

        // Get and Set for description
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        // Get and Set for Quantity
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        // Get and set for price
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

    }
}
