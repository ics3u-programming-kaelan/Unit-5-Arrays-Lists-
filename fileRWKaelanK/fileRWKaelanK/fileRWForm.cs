using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileRWKaelanK
{
    public partial class fileRWForm : Form
    {
        public fileRWForm()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // rad each line of the file 
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // 
            char[] charSepartors = new char[] { ' ', '\t' };

            // the output string where my results will go
            string output = "";
            
            //
            foreach (string line in lines)
            {
                string[] words = line.Split(charSeparators)
            }
        }
    }
}
