using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryDiscountApp.components
{
    public partial class AllProduct : UserControl
    {
        public AllProduct()
        {
            InitializeComponent();
        }

        private void AppleClicked(object sender, EventArgs e)
        {
            ShowProductInCart();
        }
        
        private void ShowProductInCart()
        {
            ProductInCart productInCart = new ProductInCart();
            productInCart.Dock = DockStyle.Top;
            productInCart.Name = "ProductInCart";
            productInCart.BringToFront();
            this.Controls.Add(productInCart);
            productInCart.Show();
        }
    }
}
