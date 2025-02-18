namespace GroceryDiscountApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            BT_Favor = new Button();
            BT_Items = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            AllTotal = new TextBox();
            LB_Total = new Label();
            DiscountTotal = new TextBox();
            label1 = new Label();
            QuantityTotal = new TextBox();
            LB_Quantity = new Label();
            ItemTotal = new TextBox();
            ItemLabel = new Label();
            SubTotal = new TextBox();
            TX_Subtotal = new TextBox();
            panel7 = new Panel();
            BT_Remove = new Button();
            BT_Calculate = new Button();
            BT_Vegi = new Button();
            BT_Fruit = new Button();
            BT_Meat = new Button();
            BT_Dairy = new Button();
            BT_All = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            apple1 = new components.Apple();
            avocado1 = new components.Avocado();
            banana1 = new components.Banana();
            breast1 = new components.Breast();
            carrots1 = new components.Carrots();
            chickenwings1 = new components.Chickenwings();
            cucumber1 = new components.Cucumber();
            eggplant1 = new components.Eggplant();
            mango1 = new components.Mango();
            onion1 = new components.Onion();
            orange1 = new components.Orange();
            pineapple1 = new components.Pineapple();
            ribs1 = new components.Ribs();
            tomato1 = new components.Tomato();
            userControl11 = new components.UserControl1();
            watermelon1 = new components.Watermelon();
            _1WholeChicken1 = new components._1WholeChicken();
            vegetables1 = new components.Vegetables();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 58, 64);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 673);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(52, 58, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(248, 249, 251);
            textBox1.Location = new Point(18, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 29);
            textBox1.TabIndex = 5;
            textBox1.Text = "Sell";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.FromArgb(52, 58, 64);
            button1.BackgroundImage = Properties.Resources.shopping;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(11, 78);
            button1.Name = "button1";
            button1.Size = new Size(52, 53);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(88, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 66);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(90, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1197, 66);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(BT_Favor);
            panel4.Controls.Add(BT_Items);
            panel4.Location = new Point(90, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(708, 66);
            panel4.TabIndex = 2;
            // 
            // BT_Favor
            // 
            BT_Favor.BackColor = SystemColors.ActiveBorder;
            BT_Favor.FlatAppearance.BorderSize = 0;
            BT_Favor.FlatStyle = FlatStyle.Flat;
            BT_Favor.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_Favor.ForeColor = Color.FromArgb(0, 123, 255);
            BT_Favor.Location = new Point(133, 0);
            BT_Favor.Margin = new Padding(0);
            BT_Favor.Name = "BT_Favor";
            BT_Favor.Size = new Size(134, 66);
            BT_Favor.TabIndex = 1;
            BT_Favor.Text = "Favorites";
            BT_Favor.UseVisualStyleBackColor = false;
            BT_Favor.Click += BT_Favor_Click;
            // 
            // BT_Items
            // 
            BT_Items.BackColor = SystemColors.ActiveBorder;
            BT_Items.FlatAppearance.BorderSize = 0;
            BT_Items.FlatStyle = FlatStyle.Flat;
            BT_Items.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_Items.ForeColor = Color.FromArgb(0, 123, 255);
            BT_Items.Location = new Point(-1, 0);
            BT_Items.Margin = new Padding(0);
            BT_Items.Name = "BT_Items";
            BT_Items.Size = new Size(134, 66);
            BT_Items.TabIndex = 0;
            BT_Items.Text = "All Items";
            BT_Items.UseVisualStyleBackColor = false;
            BT_Items.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 58, 64);
            panel5.Controls.Add(panel6);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(795, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(492, 600);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(55, 58, 64);
            panel6.Controls.Add(AllTotal);
            panel6.Controls.Add(LB_Total);
            panel6.Controls.Add(DiscountTotal);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(QuantityTotal);
            panel6.Controls.Add(LB_Quantity);
            panel6.Controls.Add(ItemTotal);
            panel6.Controls.Add(ItemLabel);
            panel6.Controls.Add(SubTotal);
            panel6.Controls.Add(TX_Subtotal);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(BT_Remove);
            panel6.Controls.Add(BT_Calculate);
            panel6.Location = new Point(1, 406);
            panel6.Name = "panel6";
            panel6.Size = new Size(488, 191);
            panel6.TabIndex = 0;
            // 
            // AllTotal
            // 
            AllTotal.BackColor = Color.FromArgb(55, 58, 64);
            AllTotal.BorderStyle = BorderStyle.None;
            AllTotal.Font = new Font("Helvetica", 14.25F);
            AllTotal.ForeColor = SystemColors.Control;
            AllTotal.Location = new Point(340, 100);
            AllTotal.Name = "AllTotal";
            AllTotal.Size = new Size(100, 23);
            AllTotal.TabIndex = 11;
            AllTotal.Text = "₱₱₱.₱₱";
            // 
            // LB_Total
            // 
            LB_Total.AutoSize = true;
            LB_Total.Font = new Font("Helvetica", 14F, FontStyle.Bold);
            LB_Total.Location = new Point(334, 75);
            LB_Total.Name = "LB_Total";
            LB_Total.Size = new Size(57, 22);
            LB_Total.TabIndex = 10;
            LB_Total.Text = "Total";
            // 
            // DiscountTotal
            // 
            DiscountTotal.BackColor = Color.FromArgb(55, 58, 64);
            DiscountTotal.BorderStyle = BorderStyle.None;
            DiscountTotal.Font = new Font("Helvetica", 14.25F);
            DiscountTotal.ForeColor = SystemColors.Control;
            DiscountTotal.Location = new Point(220, 99);
            DiscountTotal.Name = "DiscountTotal";
            DiscountTotal.Size = new Size(100, 23);
            DiscountTotal.TabIndex = 9;
            DiscountTotal.Text = "₱₱₱.₱₱";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 14F, FontStyle.Bold);
            label1.Location = new Point(214, 74);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 8;
            label1.Text = "Discount";
            // 
            // QuantityTotal
            // 
            QuantityTotal.BackColor = Color.FromArgb(55, 58, 64);
            QuantityTotal.BorderStyle = BorderStyle.None;
            QuantityTotal.Font = new Font("Helvetica", 14.25F);
            QuantityTotal.ForeColor = SystemColors.Control;
            QuantityTotal.Location = new Point(105, 100);
            QuantityTotal.Name = "QuantityTotal";
            QuantityTotal.Size = new Size(100, 23);
            QuantityTotal.TabIndex = 7;
            QuantityTotal.Text = "₱₱₱.₱₱";
            QuantityTotal.TextChanged += textBox2_TextChanged;
            // 
            // LB_Quantity
            // 
            LB_Quantity.AutoSize = true;
            LB_Quantity.Font = new Font("Helvetica", 14F, FontStyle.Bold);
            LB_Quantity.Location = new Point(99, 75);
            LB_Quantity.Name = "LB_Quantity";
            LB_Quantity.Size = new Size(90, 22);
            LB_Quantity.TabIndex = 6;
            LB_Quantity.Text = "Quantity";
            // 
            // ItemTotal
            // 
            ItemTotal.BackColor = Color.FromArgb(55, 58, 64);
            ItemTotal.BorderStyle = BorderStyle.None;
            ItemTotal.Font = new Font("Helvetica", 14.25F);
            ItemTotal.ForeColor = SystemColors.Control;
            ItemTotal.Location = new Point(7, 100);
            ItemTotal.Name = "ItemTotal";
            ItemTotal.Size = new Size(100, 23);
            ItemTotal.TabIndex = 5;
            ItemTotal.Text = "₱₱₱.₱₱";
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Font = new Font("Helvetica", 14F, FontStyle.Bold);
            ItemLabel.Location = new Point(7, 75);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new Size(64, 22);
            ItemLabel.TabIndex = 4;
            ItemLabel.Text = "Items";
            // 
            // SubTotal
            // 
            SubTotal.BackColor = Color.FromArgb(55, 58, 64);
            SubTotal.BorderStyle = BorderStyle.None;
            SubTotal.Font = new Font("Helvetica", 12F);
            SubTotal.ForeColor = SystemColors.Control;
            SubTotal.Location = new Point(7, 28);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(100, 19);
            SubTotal.TabIndex = 3;
            SubTotal.Text = "₱₱₱.₱₱";
            // 
            // TX_Subtotal
            // 
            TX_Subtotal.BackColor = Color.FromArgb(55, 58, 64);
            TX_Subtotal.BorderStyle = BorderStyle.None;
            TX_Subtotal.Font = new Font("Helvetica", 10F, FontStyle.Bold);
            TX_Subtotal.ForeColor = SystemColors.Control;
            TX_Subtotal.Location = new Point(7, 12);
            TX_Subtotal.Name = "TX_Subtotal";
            TX_Subtotal.Size = new Size(100, 16);
            TX_Subtotal.TabIndex = 0;
            TX_Subtotal.Text = "Subtotal";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(7, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(465, 10);
            panel7.TabIndex = 2;
            // 
            // BT_Remove
            // 
            BT_Remove.BackColor = Color.FromArgb(220, 53, 68);
            BT_Remove.Font = new Font("Helvetica", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_Remove.Location = new Point(39, 132);
            BT_Remove.Name = "BT_Remove";
            BT_Remove.Size = new Size(60, 46);
            BT_Remove.TabIndex = 1;
            BT_Remove.Text = "🗑️";
            BT_Remove.UseVisualStyleBackColor = false;
            // 
            // BT_Calculate
            // 
            BT_Calculate.BackColor = Color.FromArgb(40, 167, 69);
            BT_Calculate.Font = new Font("Helvetica", 16F, FontStyle.Bold);
            BT_Calculate.Location = new Point(214, 132);
            BT_Calculate.Name = "BT_Calculate";
            BT_Calculate.Size = new Size(262, 46);
            BT_Calculate.TabIndex = 0;
            BT_Calculate.Text = "Checkout";
            BT_Calculate.UseVisualStyleBackColor = false;
            // 
            // BT_Vegi
            // 
            BT_Vegi.Font = new Font("Helvetica", 10F, FontStyle.Bold);
            BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.Location = new Point(96, 274);
            BT_Vegi.Name = "BT_Vegi";
            BT_Vegi.Size = new Size(111, 48);
            BT_Vegi.TabIndex = 4;
            BT_Vegi.Text = "Vegetables";
            BT_Vegi.UseVisualStyleBackColor = true;
            BT_Vegi.Click += button2_Click;
            // 
            // BT_Fruit
            // 
            BT_Fruit.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.Location = new Point(96, 328);
            BT_Fruit.Name = "BT_Fruit";
            BT_Fruit.Size = new Size(111, 48);
            BT_Fruit.TabIndex = 5;
            BT_Fruit.Text = "Fruits";
            BT_Fruit.UseVisualStyleBackColor = true;
            BT_Fruit.Click += BT_Fruit_Click;
            // 
            // BT_Meat
            // 
            BT_Meat.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_Meat.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Meat.Location = new Point(96, 436);
            BT_Meat.Name = "BT_Meat";
            BT_Meat.Size = new Size(111, 48);
            BT_Meat.TabIndex = 7;
            BT_Meat.Text = "Meat";
            BT_Meat.UseVisualStyleBackColor = true;
            BT_Meat.Click += BT_Meat_Click;
            // 
            // BT_Dairy
            // 
            BT_Dairy.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            BT_Dairy.ForeColor = Color.FromArgb(23, 162, 185);
            BT_Dairy.Location = new Point(96, 382);
            BT_Dairy.Name = "BT_Dairy";
            BT_Dairy.Size = new Size(111, 48);
            BT_Dairy.TabIndex = 6;
            BT_Dairy.Text = "Dairy";
            BT_Dairy.UseVisualStyleBackColor = true;
            BT_Dairy.Click += BT_Dairy_Click;
            // 
            // BT_All
            // 
            BT_All.BackColor = Color.FromArgb(23, 162, 184);
            BT_All.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            BT_All.ForeColor = Color.White;
            BT_All.Location = new Point(96, 220);
            BT_All.Name = "BT_All";
            BT_All.Size = new Size(111, 48);
            BT_All.TabIndex = 8;
            BT_All.Text = "ALL";
            BT_All.UseVisualStyleBackColor = false;
            BT_All.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(235, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 448);
            dataGridView1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(apple1);
            flowLayoutPanel1.Controls.Add(avocado1);
            flowLayoutPanel1.Controls.Add(banana1);
            flowLayoutPanel1.Controls.Add(breast1);
            flowLayoutPanel1.Controls.Add(carrots1);
            flowLayoutPanel1.Controls.Add(chickenwings1);
            flowLayoutPanel1.Controls.Add(cucumber1);
            flowLayoutPanel1.Controls.Add(eggplant1);
            flowLayoutPanel1.Controls.Add(mango1);
            flowLayoutPanel1.Controls.Add(onion1);
            flowLayoutPanel1.Controls.Add(orange1);
            flowLayoutPanel1.Controls.Add(pineapple1);
            flowLayoutPanel1.Controls.Add(ribs1);
            flowLayoutPanel1.Controls.Add(tomato1);
            flowLayoutPanel1.Controls.Add(userControl11);
            flowLayoutPanel1.Controls.Add(watermelon1);
            flowLayoutPanel1.Controls.Add(_1WholeChicken1);
            flowLayoutPanel1.Controls.Add(vegetables1);
            flowLayoutPanel1.Location = new Point(235, 219);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(540, 470);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // apple1
            // 
            apple1.BackColor = Color.FromArgb(23, 162, 184);
            apple1.Location = new Point(3, 3);
            apple1.Name = "apple1";
            apple1.Size = new Size(157, 189);
            apple1.TabIndex = 0;
            // 
            // avocado1
            // 
            avocado1.BackColor = Color.FromArgb(23, 162, 184);
            avocado1.Location = new Point(166, 3);
            avocado1.Name = "avocado1";
            avocado1.Size = new Size(157, 189);
            avocado1.TabIndex = 1;
            // 
            // banana1
            // 
            banana1.BackColor = Color.FromArgb(23, 162, 184);
            banana1.Location = new Point(329, 3);
            banana1.Name = "banana1";
            banana1.Size = new Size(157, 189);
            banana1.TabIndex = 2;
            // 
            // breast1
            // 
            breast1.BackColor = Color.FromArgb(23, 162, 184);
            breast1.Location = new Point(3, 198);
            breast1.Name = "breast1";
            breast1.Size = new Size(157, 189);
            breast1.TabIndex = 3;
            // 
            // carrots1
            // 
            carrots1.BackColor = Color.FromArgb(23, 162, 184);
            carrots1.Location = new Point(166, 198);
            carrots1.Name = "carrots1";
            carrots1.Size = new Size(157, 189);
            carrots1.TabIndex = 4;
            // 
            // chickenwings1
            // 
            chickenwings1.BackColor = Color.FromArgb(23, 162, 184);
            chickenwings1.Location = new Point(329, 198);
            chickenwings1.Name = "chickenwings1";
            chickenwings1.Size = new Size(157, 189);
            chickenwings1.TabIndex = 5;
            // 
            // cucumber1
            // 
            cucumber1.BackColor = Color.FromArgb(23, 162, 184);
            cucumber1.Location = new Point(3, 393);
            cucumber1.Name = "cucumber1";
            cucumber1.Size = new Size(157, 189);
            cucumber1.TabIndex = 6;
            // 
            // eggplant1
            // 
            eggplant1.BackColor = Color.FromArgb(23, 162, 184);
            eggplant1.Location = new Point(166, 393);
            eggplant1.Name = "eggplant1";
            eggplant1.Size = new Size(157, 189);
            eggplant1.TabIndex = 7;
            // 
            // mango1
            // 
            mango1.BackColor = Color.FromArgb(23, 162, 184);
            mango1.Location = new Point(329, 393);
            mango1.Name = "mango1";
            mango1.Size = new Size(157, 189);
            mango1.TabIndex = 8;
            // 
            // onion1
            // 
            onion1.BackColor = Color.FromArgb(23, 162, 184);
            onion1.Location = new Point(3, 588);
            onion1.Name = "onion1";
            onion1.Size = new Size(157, 189);
            onion1.TabIndex = 9;
            // 
            // orange1
            // 
            orange1.BackColor = Color.FromArgb(23, 162, 184);
            orange1.Location = new Point(166, 588);
            orange1.Name = "orange1";
            orange1.Size = new Size(157, 189);
            orange1.TabIndex = 10;
            // 
            // pineapple1
            // 
            pineapple1.BackColor = Color.FromArgb(23, 162, 184);
            pineapple1.Location = new Point(329, 588);
            pineapple1.Name = "pineapple1";
            pineapple1.Size = new Size(157, 189);
            pineapple1.TabIndex = 11;
            // 
            // ribs1
            // 
            ribs1.BackColor = Color.FromArgb(23, 162, 184);
            ribs1.Location = new Point(3, 783);
            ribs1.Name = "ribs1";
            ribs1.Size = new Size(157, 189);
            ribs1.TabIndex = 12;
            // 
            // tomato1
            // 
            tomato1.BackColor = Color.FromArgb(23, 162, 184);
            tomato1.Location = new Point(166, 783);
            tomato1.Name = "tomato1";
            tomato1.Size = new Size(157, 189);
            tomato1.TabIndex = 13;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(329, 783);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(150, 150);
            userControl11.TabIndex = 14;
            // 
            // watermelon1
            // 
            watermelon1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            watermelon1.BackColor = Color.FromArgb(23, 162, 184);
            watermelon1.Location = new Point(3, 978);
            watermelon1.Name = "watermelon1";
            watermelon1.Size = new Size(157, 189);
            watermelon1.TabIndex = 15;
            // 
            // _1WholeChicken1
            // 
            _1WholeChicken1.AutoScroll = true;
            _1WholeChicken1.BackColor = Color.FromArgb(23, 162, 184);
            _1WholeChicken1.Location = new Point(166, 978);
            _1WholeChicken1.Name = "_1WholeChicken1";
            _1WholeChicken1.Size = new Size(157, 189);
            _1WholeChicken1.TabIndex = 16;
            // 
            // vegetables1
            // 
            vegetables1.Location = new Point(3, 1173);
            vegetables1.Name = "vegetables1";
            vegetables1.Size = new Size(540, 470);
            vegetables1.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(BT_All);
            Controls.Add(BT_Meat);
            Controls.Add(BT_Dairy);
            Controls.Add(BT_Fruit);
            Controls.Add(BT_Vegi);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button BT_Items;
        private Button button1;
        private TextBox textBox1;
        private Button BT_Vegi;
        private Button BT_Fruit;
        private Button BT_Meat;
        private Button BT_Dairy;
        private Button BT_All;
        private Button BT_Favor;
        private Button BT_Calculate;
        private Button BT_Remove;
        private Panel panel6;
        private Panel panel7;
        private TextBox TX_Subtotal;
        private TextBox SubTotal;
        private Label ItemLabel;
        private TextBox ItemTotal;
        private TextBox QuantityTotal;
        private Label LB_Quantity;
        private TextBox DiscountTotal;
        private Label label1;
        private TextBox AllTotal;
        private Label LB_Total;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private components.Apple apple1;
        private components.Avocado avocado1;
        private components.Banana banana1;
        private components.Breast breast1;
        private components.Carrots carrots1;
        private components.Chickenwings chickenwings1;
        private components.Cucumber cucumber1;
        private components.Eggplant eggplant1;
        private components.Mango mango1;
        private components.Onion onion1;
        private components.Orange orange1;
        private components.Pineapple pineapple1;
        private components.Ribs ribs1;
        private components.Tomato tomato1;
        private components.UserControl1 userControl11;
        private components.Watermelon watermelon1;
        private components._1WholeChicken _1WholeChicken1;
        private components.Vegetables vegetables1;
    }
}
