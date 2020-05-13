using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaShop
{
    /// <summary>
    /// Task 3.2
    /// This is a Pizza ordering program which helps to work the total cost of a pizza after selection of
    /// size and toppings.
    /// Author: Shan Ahmed
    /// </summary>
    public partial class Form1 : Form
    {
        double pizzacost = 0;
        double toppingcost = 0;
        double totalcost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbnLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnLarge.Checked)
            {
                pizzacost = 12;
            }
            totalcost = pizzacost + toppingcost;
            lblCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void rbnSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSmall.Checked)
            {
                pizzacost = 5;
            }
            totalcost = pizzacost + toppingcost;
            lblCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void rbnMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMedium.Checked)
            {
                pizzacost = 8;
            }
            totalcost = pizzacost + toppingcost;
            lblCost.Text = "£ " + totalcost.ToString("0.00");
        }

  
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx1.Checked)
            {
                toppingcost = toppingcost + 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
            else
            {
                toppingcost = toppingcost - 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx2.Checked)
            {
                toppingcost = toppingcost + 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
            else
            {
                toppingcost = toppingcost - 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
        }

        private void cbx3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx3.Checked)
            {
                toppingcost = toppingcost + 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
            else
            {
                toppingcost = toppingcost - 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
        }

        private void cbx4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx4.Checked)
            {
                toppingcost = toppingcost + 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
            else
            {
                toppingcost = toppingcost - 2.50;
                totalcost = pizzacost + toppingcost;
                lblCost.Text = "£ " + totalcost.ToString("0.00");
            }
        }
    }
}