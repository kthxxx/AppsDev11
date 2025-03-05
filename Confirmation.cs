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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }


        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            MainFormd? mainForm = Application.OpenForms.OfType<MainFormd>().FirstOrDefault();
           
            Receipt? receiptForm = Application.OpenForms.OfType<Receipt>().FirstOrDefault();
            if (receiptForm != null)
            {
                receiptForm.Close();
            }

            // Get the receipt details
            List<Product> products = Products.Instance.ProductList;
            decimal subtotal = mainForm?.CalculateSubtotal() ?? 0;
            decimal discount = subtotal - (decimal)Products.Instance.GetDiscountedPrice();
            decimal total = (decimal)Products.Instance.GetDiscountedPrice();

            // Show the FinalReceipt form
            FinalReceipt finalReceiptForm = new FinalReceipt(products, subtotal, discount, total);
            finalReceiptForm.Show();

            mainForm?.BringToFront();
            this.Close();
        }







    }
}
