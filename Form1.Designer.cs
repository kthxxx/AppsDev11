namespace GroceryDiscountApp
{
    partial class MainFormd
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormd));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            BT_Sell = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ShopName = new TextBox();
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
            productDisplayPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 58, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(BT_Sell);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, -6);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 841);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 18);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(52, 58, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(248, 249, 251);
            textBox1.Location = new Point(22, 162);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 35);
            textBox1.TabIndex = 5;
            textBox1.Text = "Sell";
            // 
            // BT_Sell
            // 
            BT_Sell.AllowDrop = true;
            BT_Sell.BackColor = Color.FromArgb(52, 58, 64);
            BT_Sell.BackgroundImage = Properties.Resources.shopping;
            BT_Sell.BackgroundImageLayout = ImageLayout.Stretch;
            BT_Sell.FlatAppearance.BorderSize = 0;
            BT_Sell.FlatStyle = FlatStyle.Flat;
            BT_Sell.Location = new Point(14, 98);
            BT_Sell.Margin = new Padding(4);
            BT_Sell.Name = "BT_Sell";
            BT_Sell.Size = new Size(65, 66);
            BT_Sell.TabIndex = 4;
            BT_Sell.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(110, 10);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1414, 82);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(ShopName);
            panel3.Location = new Point(112, 1);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1496, 82);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // ShopName
            // 
            ShopName.BorderStyle = BorderStyle.None;
            ShopName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ShopName.ForeColor = Color.FromArgb(23, 162, 185);
            ShopName.Location = new Point(8, 14);
            ShopName.Margin = new Padding(4);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(698, 46);
            ShopName.TabIndex = 0;
            ShopName.Text = "7 Ebelen";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 58, 64);
            panel5.Controls.Add(panel6);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(994, 84);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 750);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
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
            panel6.Location = new Point(1, 508);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(610, 239);
            panel6.TabIndex = 0;
            // 
            // AllTotal
            // 
            AllTotal.BackColor = Color.FromArgb(55, 58, 64);
            AllTotal.BorderStyle = BorderStyle.None;
            AllTotal.Font = new Font("Arial", 14.25F);
            AllTotal.ForeColor = SystemColors.Control;
            AllTotal.Location = new Point(425, 125);
            AllTotal.Margin = new Padding(4);
            AllTotal.Name = "AllTotal";
            AllTotal.Size = new Size(125, 28);
            AllTotal.TabIndex = 11;
            AllTotal.Text = "₱₱₱.₱₱";
            // 
            // LB_Total
            // 
            LB_Total.AutoSize = true;
            LB_Total.Font = new Font("Arial", 14F, FontStyle.Bold);
            LB_Total.Location = new Point(418, 94);
            LB_Total.Margin = new Padding(4, 0, 4, 0);
            LB_Total.Name = "LB_Total";
            LB_Total.Size = new Size(69, 29);
            LB_Total.TabIndex = 10;
            LB_Total.Text = "Total";
            // 
            // DiscountTotal
            // 
            DiscountTotal.BackColor = Color.FromArgb(55, 58, 64);
            DiscountTotal.BorderStyle = BorderStyle.None;
            DiscountTotal.Font = new Font("Arial", 14.25F);
            DiscountTotal.ForeColor = SystemColors.Control;
            DiscountTotal.Location = new Point(275, 124);
            DiscountTotal.Margin = new Padding(4);
            DiscountTotal.Name = "DiscountTotal";
            DiscountTotal.Size = new Size(125, 28);
            DiscountTotal.TabIndex = 9;
            DiscountTotal.Text = "₱₱₱.₱₱";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(268, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 8;
            label1.Text = "Discount";
            // 
            // QuantityTotal
            // 
            QuantityTotal.BackColor = Color.FromArgb(55, 58, 64);
            QuantityTotal.BorderStyle = BorderStyle.None;
            QuantityTotal.Font = new Font("Arial", 14.25F);
            QuantityTotal.ForeColor = SystemColors.Control;
            QuantityTotal.Location = new Point(131, 125);
            QuantityTotal.Margin = new Padding(4);
            QuantityTotal.Name = "QuantityTotal";
            QuantityTotal.Size = new Size(125, 28);
            QuantityTotal.TabIndex = 7;
            QuantityTotal.Text = "₱₱₱.₱₱";
            // 
            // LB_Quantity
            // 
            LB_Quantity.AutoSize = true;
            LB_Quantity.Font = new Font("Arial", 14F, FontStyle.Bold);
            LB_Quantity.Location = new Point(124, 94);
            LB_Quantity.Margin = new Padding(4, 0, 4, 0);
            LB_Quantity.Name = "LB_Quantity";
            LB_Quantity.Size = new Size(110, 29);
            LB_Quantity.TabIndex = 6;
            LB_Quantity.Text = "Quantity";
            // 
            // ItemTotal
            // 
            ItemTotal.BackColor = Color.FromArgb(55, 58, 64);
            ItemTotal.BorderStyle = BorderStyle.None;
            ItemTotal.Font = new Font("Arial", 14.25F);
            ItemTotal.ForeColor = SystemColors.Control;
            ItemTotal.Location = new Point(9, 125);
            ItemTotal.Margin = new Padding(4);
            ItemTotal.Name = "ItemTotal";
            ItemTotal.Size = new Size(125, 28);
            ItemTotal.TabIndex = 5;
            ItemTotal.Text = "₱₱₱.₱₱";
            // 
            // ItemLabel
            // 
            ItemLabel.AutoSize = true;
            ItemLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            ItemLabel.Location = new Point(9, 94);
            ItemLabel.Margin = new Padding(4, 0, 4, 0);
            ItemLabel.Name = "ItemLabel";
            ItemLabel.Size = new Size(75, 29);
            ItemLabel.TabIndex = 4;
            ItemLabel.Text = "Items";
            // 
            // SubTotal
            // 
            SubTotal.BackColor = Color.FromArgb(55, 58, 64);
            SubTotal.BorderStyle = BorderStyle.None;
            SubTotal.Font = new Font("Arial", 12F);
            SubTotal.ForeColor = SystemColors.Control;
            SubTotal.Location = new Point(9, 35);
            SubTotal.Margin = new Padding(4);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(125, 23);
            SubTotal.TabIndex = 3;
            SubTotal.Text = "₱₱₱.₱₱";
            // 
            // TX_Subtotal
            // 
            TX_Subtotal.BackColor = Color.FromArgb(55, 58, 64);
            TX_Subtotal.BorderStyle = BorderStyle.None;
            TX_Subtotal.Font = new Font("Arial", 10F, FontStyle.Bold);
            TX_Subtotal.ForeColor = SystemColors.Control;
            TX_Subtotal.Location = new Point(9, 15);
            TX_Subtotal.Margin = new Padding(4);
            TX_Subtotal.Name = "TX_Subtotal";
            TX_Subtotal.Size = new Size(125, 20);
            TX_Subtotal.TabIndex = 0;
            TX_Subtotal.Text = "Subtotal";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(9, 70);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(581, 12);
            panel7.TabIndex = 2;
            // 
            // BT_Remove
            // 
            BT_Remove.BackColor = Color.FromArgb(220, 53, 68);
            BT_Remove.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BT_Remove.Location = new Point(49, 165);
            BT_Remove.Margin = new Padding(4);
            BT_Remove.Name = "BT_Remove";
            BT_Remove.Size = new Size(75, 58);
            BT_Remove.TabIndex = 1;
            BT_Remove.Text = "🗑️";
            BT_Remove.UseVisualStyleBackColor = false;
            // 
            // BT_Calculate
            // 
            BT_Calculate.BackColor = Color.FromArgb(40, 167, 69);
            BT_Calculate.Font = new Font("Arial", 16F, FontStyle.Bold);
            BT_Calculate.Location = new Point(268, 165);
            BT_Calculate.Margin = new Padding(4);
            BT_Calculate.Name = "BT_Calculate";
            BT_Calculate.Size = new Size(328, 58);
            BT_Calculate.TabIndex = 0;
            BT_Calculate.Text = "Checkout";
            BT_Calculate.UseVisualStyleBackColor = false;
            BT_Calculate.Click += BT_Calculate_Click;
            // 
            // BT_Vegi
            // 
            BT_Vegi.Font = new Font("Arial", 10F, FontStyle.Bold);
            BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.Location = new Point(131, 178);
            BT_Vegi.Margin = new Padding(4);
            BT_Vegi.Name = "BT_Vegi";
            BT_Vegi.Size = new Size(139, 60);
            BT_Vegi.TabIndex = 4;
            BT_Vegi.Text = "Vegetables";
            BT_Vegi.UseVisualStyleBackColor = true;
            BT_Vegi.Click += BT_Vegi_Click_1;
            // 
            // BT_Fruit
            // 
            BT_Fruit.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.Location = new Point(131, 245);
            BT_Fruit.Margin = new Padding(4);
            BT_Fruit.Name = "BT_Fruit";
            BT_Fruit.Size = new Size(139, 60);
            BT_Fruit.TabIndex = 5;
            BT_Fruit.Text = "Fruits";
            BT_Fruit.UseVisualStyleBackColor = true;
            BT_Fruit.Click += BT_Fruit_Click;
            // 
            // BT_Meat
            // 
            BT_Meat.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_Meat.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Meat.Location = new Point(131, 380);
            BT_Meat.Margin = new Padding(4);
            BT_Meat.Name = "BT_Meat";
            BT_Meat.Size = new Size(139, 60);
            BT_Meat.TabIndex = 7;
            BT_Meat.Text = "Meat";
            BT_Meat.UseVisualStyleBackColor = true;
            BT_Meat.Click += BT_Meat_Click;
            // 
            // BT_Dairy
            // 
            BT_Dairy.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            BT_Dairy.ForeColor = Color.FromArgb(23, 162, 185);
            BT_Dairy.Location = new Point(131, 312);
            BT_Dairy.Margin = new Padding(4);
            BT_Dairy.Name = "BT_Dairy";
            BT_Dairy.Size = new Size(139, 60);
            BT_Dairy.TabIndex = 6;
            BT_Dairy.Text = "Dairy";
            BT_Dairy.UseVisualStyleBackColor = true;
            BT_Dairy.Click += BT_Dairy_Click;
            // 
            // BT_All
            // 
            BT_All.BackColor = Color.White;
            BT_All.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            BT_All.ForeColor = Color.FromArgb(23, 162, 184);
            BT_All.Location = new Point(131, 110);
            BT_All.Margin = new Padding(4);
            BT_All.Name = "BT_All";
            BT_All.Size = new Size(139, 60);
            BT_All.TabIndex = 8;
            BT_All.Text = "ALL";
            BT_All.UseVisualStyleBackColor = false;
            BT_All.Click += BT_All_Click;
            // 
            // productDisplayPanel
            // 
            productDisplayPanel.AutoScroll = true;
            productDisplayPanel.Location = new Point(295, 104);
            productDisplayPanel.Margin = new Padding(4);
            productDisplayPanel.Name = "productDisplayPanel";
            productDisplayPanel.Size = new Size(675, 776);
            productDisplayPanel.TabIndex = 9;
            // 
            // MainFormd
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1605, 826);
            Controls.Add(productDisplayPanel);
            Controls.Add(BT_All);
            Controls.Add(BT_Meat);
            Controls.Add(BT_Dairy);
            Controls.Add(BT_Fruit);
            Controls.Add(BT_Vegi);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "MainFormd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grocery Store";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Button BT_Sell;
        private TextBox textBox1;
        private Button BT_Vegi;
        private Button BT_Fruit;
        private Button BT_Meat;
        private Button BT_Dairy;
        private Button BT_All;
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
        private new TextBox ShopName;
        private PictureBox pictureBox1;
        private Panel productDisplayPanel;
    }
}
