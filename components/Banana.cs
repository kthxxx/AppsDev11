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
    public partial class Banana : UserControl {
        public Banana() {
            InitializeComponent();
        }

        private void BananaClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Banana", 80, 1);
        }
    }
}
