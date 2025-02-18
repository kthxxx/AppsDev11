namespace GroceryDiscountApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BT_Items.BackColor = Color.FromArgb(0, 123, 255);
            BT_Items.ForeColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BT_Vegi.BackColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.ForeColor = Color.White;
        }

        private void BT_Meat_Click(object sender, EventArgs e)
        {
            BT_Meat.BackColor = Color.FromArgb(23, 162, 184);
            BT_Meat.ForeColor = Color.White;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BT_All.BackColor = Color.FromArgb(23, 162, 184);
            BT_All.ForeColor = Color.White;
        }

        private void BT_Favor_Click(object sender, EventArgs e)
        {
            BT_Favor.BackColor = Color.FromArgb(0, 123, 255);
            BT_Favor.ForeColor = Color.White;
        }

        private void BT_Fruit_Click(object sender, EventArgs e)
        {
            BT_Fruit.BackColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.ForeColor = Color.White;
        }

        private void BT_Dairy_Click(object sender, EventArgs e)
        {
            BT_Dairy.BackColor = Color.FromArgb(23, 162, 184);
            BT_Dairy.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
