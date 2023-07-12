using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Mackenzie Peoples Miranda 
//ID:
//Date: 7/12/23
//The goal of this program is to divide numbers and show the quotients and remainders



namespace DivisionDecVsMod.MackenziePeoplesMiranda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal myQuotient = 0;
            decimal myRemainder = 0;
            decimal dividend = 0;
            decimal divisor;
            decimal answer = 0;


            //INPUT
            divisor = decimal.Parse(DevisorTextbox.Text);


            // the validation

            // if the user tries to divide by 0
            if (divisor != 0)
            {

            }
            else
            {
                MessageBox.Show("cant divide by zero");
                DevisorTextbox.Focus();
                DevisorTextbox.Clear();
                return;
            }

            // try.parse for the dividend box
            if (decimal.TryParse(DividendTextbox.Text, out dividend))
            {

            }
            else
            {
                // if wrong format is entered in the dividend box
                MessageBox.Show("Error must be in numeric format 0-9");
                DividendTextbox.Focus();
                DividendTextbox.Clear();
                return;
            }

            if (decimal.TryParse(DevisorTextbox.Text, out divisor))
            {
                
            }
            else
            {
                // if wrong format is entered in the divisor box
                MessageBox.Show("ERROR must be in numeric format 0-9");
                DevisorTextbox.Focus();
                DevisorTextbox.Clear();
                return;
            }

           dividend = decimal.Parse(DividendTextbox.Text);

















            //PROCESSING
            //


            answer = dividend / divisor;
            myRemainder = dividend % divisor;
            myQuotient = Math.Truncate(answer);
















            //OUTPUT
            //


            AnswerDecTextbox.Text=answer.ToString("F4");
            RemainderTextbox.Text = myRemainder.ToString();
            QuoTextbox.Text = myQuotient.ToString();












        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            // clears all values entered

            DividendTextbox.Text = "";
            DevisorTextbox.Text = "";
            AnswerDecTextbox.Text = "";
            RemainderTextbox.Text = "";
            QuoTextbox.Text = "";



        }
    }
}
