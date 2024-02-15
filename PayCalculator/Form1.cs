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

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            hours = Convert.ToDouble(hoursInput.Text);
            rate = Convert.ToDouble(rateInput.Text);

            subtotal = hours* rate;

            subtotalOutput.Text = $" {subtotal}";
        }
    }
}
