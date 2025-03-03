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
    public partial class ProductInCart : UserControl
    {
        public ProductInCart()
        {
            InitializeComponent();
        }
        internal class Product
        {
            private string name;
            private double price;
            private int quantity;

            public Product(string name, double price, int quantity)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
