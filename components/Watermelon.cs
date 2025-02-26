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
    public partial class Watermelon : UserControl {
        public Watermelon() {
            InitializeComponent();
        }

        private void WatermelonClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Watermelon", 185, 1);
        }
    }
}
