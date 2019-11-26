using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrayMaxVal
{
    public partial class maxArrayForm : Form
    {
        public maxArrayForm()
        {
            InitializeComponent();
        }

        private int GetMaxValue

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local var and const
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUM = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;

            // random number
            Random randomNumberGenerator = new Random();

            // clear list box

            // for loop
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random num
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // assign the random num between
            }

            
        }
    }
}
