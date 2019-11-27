/*
 * Created by: Kaelan K
 * Created on: 27-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program make 10 random numbers then check to see what is the biggest
*/
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

        // Get max value function
        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            // declaring vars
            int tmpMaxVal = -1;
            int counter;

            // for loop
            for (counter = 0; counter < 10; counter++)
            {
                // if array value is greater then max val set it to array val
                if (tmpMaxVal < tmpArrayOfIntegers[counter])
                {
                    tmpMaxVal = tmpArrayOfIntegers[counter];
                }
            }

            // return max val
            return tmpMaxVal;
        }

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
            this.lstArray.Items.Clear();

            // for loop
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random num
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUM + 1);

                // assign the random num between
                arrayOfIntegers[counter] = randomNumber;

                // add array value to list box
                this.lstArray.Items.Add(randomNumber);

                this.Refresh();
            }

            // calling on function
            maxValue = GetMaxValue(arrayOfIntegers);

            // display what value is greatest with label
            this.lblOutput.Text = "The max value is " + maxValue;
            
        }
    }
}
