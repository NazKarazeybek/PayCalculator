using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        double hours;
        double rate;
        double subtotal;
        double taxAmount;
        double totalAmount;
        double taxRate = 0.2;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                hours = Convert.ToDouble(hoursInput.Text);
            rate = Convert.ToDouble(rateInput.Text);

            subtotal = hours* rate;
            taxAmount = subtotal * taxRate; //you could use .2 aswell but putting a variable is better. (we added double taxRate=0.2 above so whenever we say "tax rate" it means its 0.2)
            totalAmount = subtotal - taxAmount;

            subtotalOutput.Text = $" {subtotal.ToString(".00")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{totalAmount.ToString("C")}";
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }
        }

        private void hoursInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void rateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
