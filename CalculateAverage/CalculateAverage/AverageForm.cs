using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAverage
{
    public partial class frmAverage : Form
    {
        // create global list
        List<double> myListOfIntegers = new List<double>();

        public frmAverage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local vars
            double average = 0;
            int
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // declare local vars
            int userMark = -1;

            // convert the value in the textbox to an int
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            catch (Exception parseError)
            {
                Console.WriteLine("An error has occurred: '{0}'", parseError);
            }

            // check if the user entered a number between 0 and 100
            if ( (userMark >= 0) && (userMark <= 100))
            {
                // add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                // add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }
    }
}
