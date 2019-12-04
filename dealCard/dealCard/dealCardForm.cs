/*
 * Created by: Kaelan K
 * Created on: 04-12-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Deal Card
 * This program...
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

namespace dealCard
{
    public partial class dealCardForm : Form
    {
        //create an empty list
        List<Image> listCardImages = new List<Image>();

        public dealCardForm()
        {
            InitializeComponent();
        }

        private int DealCard(ref List<Image> cardImages)
        {

        }

        private void NewDeck()
        {
            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);
            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);
            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);
            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);
            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);
            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);
            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);
            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);
            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);
            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);
            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);
            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);
            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {

            










        }
    }
}
