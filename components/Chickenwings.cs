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
    public partial class Chickenwings : UserControl {
        public Chickenwings() {
            InitializeComponent();
        }

        private void ChickenWingsClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Chicken Wings", 190, 1);
        }
    }
}
