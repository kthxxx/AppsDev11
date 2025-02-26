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
    public partial class Cucumber : UserControl {
        public Cucumber() {
            InitializeComponent();
        }

        private void CucumberClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;

            productList.AddProduct("Cucumber", 80, 1);
        }
    }
}
