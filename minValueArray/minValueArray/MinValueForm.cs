/*
 * Created by: Kaelan
 * Created on: 29-01-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program generates numbers and then puts them in an array where it picks out the lowest value
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

namespace minValueArray
{
    public partial class frmMinValue : Form
    {
        public frmMinValue()
        {
            InitializeComponent();
        }

        private void FrmMinValue_Load(object sender, EventArgs e)
        {

        }

        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            // declaring vars
            int tmpMinVal = 500;
            int counter;

            // for loop
            for (counter = 0; counter < 10; counter++)
            {
                // if array value is greater then max val set it to array val
                if (tmpMinVal > tmpArrayOfIntegers[counter])
                {
                    tmpMinVal = tmpArrayOfIntegers[counter];
                }
            }

            // return max val
            return tmpMinVal;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local var and const
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUM = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;

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
            minValue = GetMinValue(arrayOfIntegers);

            // display what value is greatest with label
            this.lblOutput.Text = "The min value is " + minValue;
        }
    }
}
