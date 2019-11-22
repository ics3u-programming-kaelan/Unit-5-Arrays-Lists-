/*
 * Created by: Kaelan K
 * Created on: 22-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program makes a list box of 10 numbers and then calculates the average of it
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

namespace introArrayKaelanK
{
    public partial class frmArrays : Form
    {
        // declare global vars and const
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrays()
        {
            InitializeComponent();
        }

        private void ArraysForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local vars
            int randomNum;
            int counter;
            Random randomNumberGenerator = new Random();

            // clear list box
            this.lstArray.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new rnadom num between 1 and 10
                randomNum = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE+1);

                // assign the random num to the cell posistion in the array
                arrayOfNumbers[counter] = randomNum;

                // add num to the list box
                this.lstArray.Items.Add(randomNum);

                // refresh the from
                this.Refresh();
            }
            
        }

        private void BtnCalAverage_Click(object sender, EventArgs e)
        {
            // declare local vars
            double average = 0;
            double sum = 0;
            int counter;

            // calculate the sum pf all array values
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            // calculate the average of the values in the array
            average = sum / arrayOfNumbers.Length;

            // display the average in the label
            this.lblOutput.Text = "Average: " + average;
        }
    }
}
