using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryDiscountApp;
using static System.Windows.Forms.DataFormats;

namespace GroceryDiscountApp.components
{
    public partial class Meat : UserControl
    {
        public Meat()
        {
            InitializeComponent();
        }

        private void WholeChickenClicked(object sender, EventArgs e)
        {
       
        }





        private void ShowProductInCart()
        {
            ProductInCart productInCart = new ProductInCart();
            productInCart.Dock = DockStyle.Top;
            productInCart.Name = "ProductInCart";
            productInCart.BringToFront();
        }

        private void ribs1_Load(object sender, EventArgs e)
        {
        }

        private void _1WholeChicken1Clicked(object sender, EventArgs e)
        {
        }

        private void _1WholeChicken1_Load(object sender, EventArgs e)
        {
        }
    }
}
