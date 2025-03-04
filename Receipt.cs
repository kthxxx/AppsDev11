using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryDiscountApp
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping at Evelyn", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Find the MainFormd instance
            MainFormd mainForm = Application.OpenForms.OfType<MainFormd>().FirstOrDefault();
            if (mainForm != null)
            {
                // Call the reset method on MainFormd
                mainForm.ResetForm();
            }

            // Close the Receipt form
            this.Close();
        }


    }
}
