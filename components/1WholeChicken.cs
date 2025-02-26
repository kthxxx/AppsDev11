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
    public partial class _1WholeChicken : UserControl {
        public _1WholeChicken() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void _1WholeChicken_Load(object sender, EventArgs e) {

        }

        private void WholeChickenClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Whole Chicken", 230, 1);
        }
    }
}
