/*
 * Created by: Romy I. Chu II
 * Created on: 26-02-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - PizzaCost
 * This program calculates the cost of a pizza given the diameter
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

namespace PizzaCostRomyIIC
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            //Assigning txtDiameterOfPizza as a variable.
            Double inputDiameter = Double.Parse(txtDiameterOfPizza.Text);

            //Assigning HST as a Constant.
            const Double HST = 1.13;

            //Calculating The pizza cost.
            lblPizzaCost.Text = Convert.ToString((0.75 + 0.99 + 0.5 * inputDiameter) * HST);
        }
    }
}
