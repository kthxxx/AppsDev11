using GroceryDiscountApp.components;

namespace GroceryDiscountApp {
    public partial class MainFormd : Form {
        private static readonly Color ButtonActiveColor = Color.FromArgb(23, 162, 184);
        private static readonly Color ButtonDefaultColor = Color.White;

        public MainFormd() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Optionally, you can show a default product category on load
            ShowAllProduct();
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

        private void BT_Dairy_Click(object sender, EventArgs e) {
            ResetButtonColors();
            BT_Dairy.BackColor = ButtonActiveColor;
            BT_Dairy.ForeColor = Color.White;

            ShowDairy();
        }

        private void ResetButtonColors() {
            BT_All.BackColor = ButtonDefaultColor;
            BT_Vegi.BackColor = ButtonDefaultColor;
            BT_Fruit.BackColor = ButtonDefaultColor;
            BT_Meat.BackColor = ButtonDefaultColor;
            BT_Dairy.BackColor = ButtonDefaultColor;

            BT_All.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Meat.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Dairy.ForeColor = Color.FromArgb(23, 162, 184);
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

        private void ShowDairy() {
            productDisplayPanel.Controls.Clear();
            Dairy dairy = new Dairy();
            productDisplayPanel.Controls.Add(dairy);
            dairy.BringToFront();
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
            Products productList = Products.Instance;

            MessageBox.Show($"Total: Php {productList.GetDiscountedPrice()}");

        }

        private void panel5_Paint(object sender, PaintEventArgs e) {

        }
    }
}