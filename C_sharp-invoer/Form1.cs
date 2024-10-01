using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // nodig voor Regex

namespace C_sharp_invoer
{
    public partial class Form1 : Form
    {
        // Gejat van internet, want wil geen domme antwoorden
        private static readonly Regex nameRegex = new Regex(@"^[A-Za-zÀ-ÿ'-]+$", RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();
        }

        private void txtFristName_TextChanged(object sender, EventArgs e)
        {
            // Doe niks 
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            // Doet ook niks
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // is ie leeg?
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Invalid first name");
                return;
            }

            // is het een juist format?
            if (!nameRegex.IsMatch(txtFirstName.Text))
            {
                MessageBox.Show("First name must contain only letters");
                return;
            }

            // Is deze leeg?
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Invalid last name");
                return;
            }

            // is deze het juiste format?
            if (!nameRegex.IsMatch(txtLastName.Text))
            {
                MessageBox.Show("Last name must contain only letters");
                return;
            }

            // Wow alles is goed ingevuld nu display!
            MessageBox.Show(txtFirstName.Text + " " + txtLastName.Text);
        }
    }
}
