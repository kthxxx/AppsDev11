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
    public partial class Eggplant : UserControl {
        public Eggplant() {
            InitializeComponent();
        }

        private void EggplantClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Eggplant", 40, 1);
        }
    }
}
