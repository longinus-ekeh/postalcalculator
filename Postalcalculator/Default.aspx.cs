using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postalcalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void lengthTexBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performInputCheck();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performInputCheck();
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            performInputCheck();
        }
        private void performInputCheck()
        {
            if ((widthTextBox.Text.Trim().Length == 0)
                && (heightTextBox.Text.Trim().Length == 0))
                return;
            if (lengthTexBox.Text.Trim().Length == 0)
                return;


            double width = 0.0;
            double height = 0.0;
            double length = 0.0;
            if (!Double.TryParse(widthTextBox.Text, out width)) return;
            if (!Double.TryParse(heightTextBox.Text, out height)) return;
            if (!Double.TryParse(lengthTexBox.Text, out length)) return;

            double totalCost = 0.0;
            double freightCost = calculateCost(width, height, length, out totalCost);

           
        
            resultLabel.Text = String.Format("The total cost of freight is {0:C}.", freightCost);

        }





        private void convertValuesToDouble(double width, double height, double length)
        {

            /*
            if (!Double.TryParse(widthTextBox.Text, out width)) return;
            if (!Double.TryParse(heightTextBox.Text, out height)) return;
            if (!Double.TryParse(lengthTexBox.Text, out length)) return;

            double totalCost = 0.0;
            double freightCost = calculateCost(width, height, length, out totalCost);

            resultLabel.Text = String.Format("The total cost of freight is {0:C}.", freightCost);

    */

        }



        private double calculateCost(double width, double height, double length, out double totalCost)
        {


            if ((groundRadioButton.Checked) && (length <= 0))
                totalCost = width * height * .15;
            else if ((groundRadioButton.Checked) && (length > 0))
                totalCost = width * height * length * .15;
            else if ((airRadioButton.Checked) && (length <= 0))
                totalCost = width * height * .25;
            else if ((airRadioButton.Checked) && (length > 0))
                totalCost = width * height * length * .25;
            else if ((nextDayRadioButton.Checked) && (length <= 0))
                totalCost = width * height * .45;
            else totalCost = width * height * length * .45;
           
            return totalCost;


        }

    }

    }

