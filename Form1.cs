using System.Runtime.CompilerServices;
using GroceryDiscountApp.components;

namespace GroceryDiscountApp
{
    public partial class MainFormd : Form {
        private static readonly Color ButtonActiveColor = Color.FromArgb(23, 162, 184);
        private static readonly Color ButtonDefaultColor = Color.White;
        private Receipt receiptForm; // Add this field to hold the reference to the receipt form

        public MainFormd() {
            InitializeComponent();
            BT_Calculate.Click += new EventHandler(BT_Calculate_Click);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Optionally, you can show a default product category on load
            bool showDefaultCategoryOnLoad = true; // This can be set based on a configuration or user preference

            if (showDefaultCategoryOnLoad) {
                ShowAllProduct();
            }
        }

        private void BT_Meat_Click(object sender, EventArgs e) {
            ResetButtonColors();
            BT_Meat.BackColor = ButtonActiveColor;
            BT_Meat.ForeColor = Color.White;

            ShowMeat();
        }

        private void BT_All_Click(object sender, EventArgs e) {
            ResetButtonColors();
            BT_All.BackColor = ButtonActiveColor;
            BT_All.ForeColor = Color.White;

            ShowAllProduct();
        }

        private void BT_Vegi_Click_1(object sender, EventArgs e) {
            ResetButtonColors();
            BT_Vegi.BackColor = ButtonActiveColor;
            BT_Vegi.ForeColor = Color.White;

            ShowVegetables();
        }

        private void BT_Fruit_Click(object sender, EventArgs e) {
            ResetButtonColors();
            BT_Fruit.BackColor = ButtonActiveColor;
            BT_Fruit.ForeColor = Color.White;

            ShowFruits();
        }


        private void ResetButtonColors() {
            BT_All.BackColor = ButtonDefaultColor;
            BT_Vegi.BackColor = ButtonDefaultColor;
            BT_Fruit.BackColor = ButtonDefaultColor;
            BT_Meat.BackColor = ButtonDefaultColor;

            BT_All.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Meat.ForeColor = Color.FromArgb(23, 162, 184);
        }

        private void ShowVegetables() {
            productDisplayPanel.Controls.Clear(); // Clear existing controls
            Vegetables vegetables = new Vegetables();
            productDisplayPanel.Controls.Add(vegetables); // Add to the panel
            vegetables.BringToFront();
        }

        private void ShowFruits() {
            productDisplayPanel.Controls.Clear();
            Fruits fruits = new Fruits();
            productDisplayPanel.Controls.Add(fruits);
            fruits.BringToFront();
        }

        private void ShowMeat() {
            productDisplayPanel.Controls.Clear();
            Meat meat = new Meat();
            productDisplayPanel.Controls.Add(meat);
            meat.BringToFront();
        }

        private void ShowAllProduct() {
            productDisplayPanel.Controls.Clear();
            AllProduct all = new AllProduct();
            productDisplayPanel.Controls.Add(all);
            all.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void BT_Calculate_Click(object sender, EventArgs e) {
            MainFormd? mainForm = Application.OpenForms.OfType<MainFormd>().FirstOrDefault();
            var productList = Products.Instance.ProductList;
            if (productList.Count > 0) {
                MessageBox.Show("Thank you for shopping at 7 ebelen!");
                if (mainForm != null) {
                    // Call the reset method on MainFormd
                    mainForm.ResetForm();
                }
                productList.Clear();
            } else {
                MessageBox.Show("You currently have no items in your cart");
            }
        }

        public decimal CalculateSubtotal() {
            decimal subtotal = 0;
            foreach (var productDetails in productDetailsMap.Values) {
                string quantityText = productDetails.lblProductQuantity.Text.Replace(": ", "");
                int quantity = int.Parse(quantityText);
                string priceText = productDetails.lblProductPrice.Text.Replace("₱", "").Trim();
                decimal price = decimal.Parse(priceText);
                subtotal += price * quantity;
            }
            return subtotal;
        }

        private void UpdateSubtotal() {
            decimal subtotal = CalculateSubtotal();
            SubTotal.Text = $" {subtotal:C}";
        }

        private int CalculateTotalQuantity() {
            int totalQuantity = 0;
            foreach (var productDetails in productDetailsMap.Values) {
                string quantityText = productDetails.lblProductQuantity.Text.Replace(": ", "");
                int quantity = int.Parse(quantityText);
                totalQuantity += quantity;
            }
            return totalQuantity;
        }

        private int CountItemsInCartPanel() {
            return CartPanel.Controls.Count;
        }

        private void UpdateItemTotal() {
            int totalQuantity = CalculateTotalQuantity();
            int totalItemCount = CountItemsInCartPanel();
            QuantityTotal.Text = $" {totalQuantity}";
            ItemTotal.Text = $" {totalItemCount}";
        }

        private void UpdateDiscountTotal() {
            decimal subtotal = CalculateSubtotal();
            double discountedPrice = Products.Instance.GetDiscountedPrice();
            decimal discountTotal = subtotal - (decimal)discountedPrice;

            if (discountTotal < 0) {
                discountTotal = 0;
            }

            if (discountedPrice < 0) {
                discountedPrice = 0;
            }

            AllTotal.Text = $" {discountedPrice:C}";
            DiscountTotal.Text = $" {discountTotal:C}";
        }

        private Dictionary<string, ProductDetailsControl> productDetailsMap = new Dictionary<string, ProductDetailsControl>();

        private void BT_Remove_Click(object sender, EventArgs e) {
            Products prod = Products.Instance;
            productDetailsMap.Clear();
            CartPanel.Controls.Clear();
            UpdateSubtotal();
            UpdateItemTotal();
            UpdateDiscountTotal();
            prod.ProductList.Clear();

            // Set totals to default values
            SubTotal.Text = "₱0";
            QuantityTotal.Text = "0";
            ItemTotal.Text = "0";
            AllTotal.Text = "₱0";
            DiscountTotal.Text = "₱0";
        }

        public void RemoveProductFromCart(string productName) {
            if (productDetailsMap.ContainsKey(productName)) {
                productDetailsMap.Remove(productName);
                UpdateSubtotal();
                UpdateItemTotal();
                UpdateDiscountTotal();

                // Reset discount if no items in the cart
                if (CartPanel.Controls.Count == 0) {
                    DiscountTotal.Text = "₱0";
                }
            }
        }

        public void UpdateProductDetails(string productName, decimal price, int quantity) {
            Products prod = Products.Instance;
            if (productDetailsMap.ContainsKey(productName)) {
                var productDetails = productDetailsMap[productName];
                string quantityText = productDetails.lblProductQuantity.Text;
                int currentQuantity = int.Parse(quantityText.Replace(" ", ""));
                int newQuantity = currentQuantity + quantity;
                productDetails.UpdateQuantity(newQuantity);
                productDetails.lblProductQuantity.Text = $" {newQuantity}";
                //productDetails.UpdatePrice(price * newQuantity);
            } else {
                ProductDetailsControl productDetails = new ProductDetailsControl();
                productDetails.SetProductDetails(productName, price, quantity);
                CartPanel.Controls.Add(productDetails);
                productDetails.BringToFront();
                productDetailsMap[productName] = productDetails;
            }
            UpdateSubtotal();
            UpdateItemTotal();
            UpdateDiscountTotal();

            // Reset discount if no items in the cart
            if (CartPanel.Controls.Count == 0) {
                DiscountTotal.Text = "₱0";
            }
        }

        private void ShowReceipt() {
            decimal total = 0;
            if (receiptForm == null || receiptForm.IsDisposed) {
                List<Product> products = Products.Instance.ProductList;
                decimal subtotal = CalculateSubtotal();
                decimal discount = subtotal - (decimal)Products.Instance.GetDiscountedPrice();
                total = (decimal)Products.Instance.GetDiscountedPrice();

                receiptForm = new Receipt();
                receiptForm.GenerateReceipt(products, subtotal, discount, total);
                receiptForm.Show();
            } else {
                receiptForm.BringToFront();
            }
            Products prod = Products.Instance;
            prod.ProductList.Clear();
        }

        public void ResetForm() {
            // Clear the product details map and cart panel
            productDetailsMap.Clear();
            CartPanel.Controls.Clear();

            // Update the totals
            UpdateSubtotal();
            UpdateItemTotal();
            UpdateDiscountTotal();

            // Set totals to default values
            SubTotal.Text = "₱0";
            QuantityTotal.Text = "0";
            ItemTotal.Text = "0";
            AllTotal.Text = "₱0";
            DiscountTotal.Text = "₱0";
        }

        private void allProduct2_Load(object sender, EventArgs e) {

        }

        private void TX_Subtotal_EnabledChanged(object sender, EventArgs e) {
            TextBox currentOBJ = (TextBox)sender;

            currentOBJ.ForeColor = SystemColors.Control;
        }

        private void MainFormd_Load(object sender, EventArgs e) {

        }
    }
}
