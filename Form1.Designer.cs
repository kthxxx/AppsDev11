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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormd));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            BT_Sell = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            Name = new TextBox();
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
            panel1.Location = new Point(1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 673);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(52, 58, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(248, 249, 251);
            textBox1.Location = new Point(18, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 29);
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
            BT_Sell.Location = new Point(11, 78);
            BT_Sell.Name = "BT_Sell";
            BT_Sell.Size = new Size(52, 53);
            BT_Sell.TabIndex = 4;
            BT_Sell.UseVisualStyleBackColor = false;
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
            panel3.Controls.Add(Name);
            panel3.Location = new Point(90, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1197, 66);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // Name
            // 
            Name.BorderStyle = BorderStyle.None;
            Name.Font = new Font("Ravie", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.FromArgb(23, 162, 185);
            Name.Location = new Point(6, 11);
            Name.Name = "Name";
            Name.Size = new Size(558, 43);
            Name.TabIndex = 0;
            Name.Text = "7 Ebelen";
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
            BT_Calculate.Click += BT_Calculate_Click;
            // 
            // BT_Vegi
            // 
            BT_Vegi.Font = new Font("Helvetica", 10F, FontStyle.Bold);
            BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Vegi.Location = new Point(105, 142);
            BT_Vegi.Name = "BT_Vegi";
            BT_Vegi.Size = new Size(111, 48);
            BT_Vegi.TabIndex = 4;
            BT_Vegi.Text = "Vegetables";
            BT_Vegi.UseVisualStyleBackColor = true;
            BT_Vegi.Click += BT_Vegi_Click_1;
            // 
            // BT_Fruit
            // 
            BT_Fruit.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
            BT_Fruit.Location = new Point(105, 196);
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
            BT_Meat.Location = new Point(105, 304);
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
            BT_Dairy.Location = new Point(105, 250);
            BT_Dairy.Name = "BT_Dairy";
            BT_Dairy.Size = new Size(111, 48);
            BT_Dairy.TabIndex = 6;
            BT_Dairy.Text = "Dairy";
            BT_Dairy.UseVisualStyleBackColor = true;
            BT_Dairy.Click += BT_Dairy_Click;
            // 
            // BT_All
            // 
            BT_All.BackColor = Color.White;
            BT_All.Font = new Font("Helvetica", 14.25F, FontStyle.Bold);
            BT_All.ForeColor = Color.FromArgb(23, 162, 184);
            BT_All.Location = new Point(105, 88);
            BT_All.Name = "BT_All";
            BT_All.Size = new Size(111, 48);
            BT_All.TabIndex = 8;
            BT_All.Text = "ALL";
            BT_All.UseVisualStyleBackColor = false;
            BT_All.Click += BT_All_Click;
            // 
            // productDisplayPanel
            // 
            productDisplayPanel.AutoScroll = true;
            productDisplayPanel.Location = new Point(236, 83);
            productDisplayPanel.Name = "productDisplayPanel";
            productDisplayPanel.Size = new Size(540, 621);
            productDisplayPanel.TabIndex = 9;
            // 
            // MainFormd
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1284, 661);
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
            Name.Text = "7 Ebelen";
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
        private new TextBox Name;
        private PictureBox pictureBox1;
        private Panel productDisplayPanel;
    }
}
