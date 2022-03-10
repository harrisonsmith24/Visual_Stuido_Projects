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
    // Declaring the form as a class so it can be called in other forms
    public partial class TotalCharges : Form
    {
        public TotalCharges()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}
