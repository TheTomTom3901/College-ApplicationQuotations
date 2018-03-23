using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationQuotations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string choice;
        int hours;
        int rate;
        double vattaken;
        double subtotal;
        double total;

        private void ExitButtton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PaymentDue.Clear();
            VATAmount.Clear();
            SubTotal.Clear();
            HoursText.ResetText();
            DevelopmentOptions.SelectedIndex = -1;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            choice = DevelopmentOptions.Text;
            if(choice != "")
            {
                rate = 50;
                hours = int.Parse(HoursText.Text);
                subtotal = hours * rate;
                total = subtotal * 1.20;
                vattaken = (total - subtotal);
                SubTotal.Text = "£" + subtotal.ToString();
                VATAmount.Text = "£" + vattaken.ToString();
                PaymentDue.Text = "£" + total.ToString();
            }
            else
            {
                OptionError.Show();
            }
        }

        private void DevelopementOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = DevelopmentOptions.Text;
            if (choice == "Desktop Application")
            {
                HoursText.Text = "20";
            }
            else if(choice == "Network")
            {
                HoursText.Text = "5";
            }
            else if (choice == "Website")
            {
                HoursText.Text = "7";
            }
            else if (choice == "Mobile Application")
            {
                HoursText.Text = "10";
            }
        }

        private void DevelopementOptions_Click(object sender, EventArgs e)
        {
            OptionError.Hide();
        }
    }
}
