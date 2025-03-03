namespace GroceryDiscountApp
{
    partial class ProductInCart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            QuantityBox = new TextBox();
            SubTotalBox = new TextBox();
            increaseBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Helvetica", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 58, 64);
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "[Product Name]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 58, 64);
            label2.Location = new Point(179, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "[Price]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(52, 58, 64);
            label3.Location = new Point(162, 18);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 2;
            label3.Text = "₱";
            // 
            // QuantityBox
            // 
            QuantityBox.BackColor = SystemColors.Control;
            QuantityBox.BorderStyle = BorderStyle.None;
            QuantityBox.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            QuantityBox.ForeColor = Color.FromArgb(52, 58, 64);
            QuantityBox.Location = new Point(248, 18);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(50, 21);
            QuantityBox.TabIndex = 3;
            QuantityBox.Text = "1";
            QuantityBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SubTotalBox
            // 
            SubTotalBox.BackColor = SystemColors.Control;
            SubTotalBox.BorderStyle = BorderStyle.None;
            SubTotalBox.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            SubTotalBox.ForeColor = Color.FromArgb(52, 58, 64);
            SubTotalBox.Location = new Point(304, 18);
            SubTotalBox.Name = "SubTotalBox";
            SubTotalBox.Size = new Size(70, 21);
            SubTotalBox.TabIndex = 4;
            SubTotalBox.Text = "[₱₱₱₱]";
            SubTotalBox.TextAlign = HorizontalAlignment.Center;
            // 
            // increaseBtn
            // 
            increaseBtn.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            increaseBtn.Location = new Point(388, 9);
            increaseBtn.Name = "increaseBtn";
            increaseBtn.Size = new Size(30, 37);
            increaseBtn.TabIndex = 5;
            increaseBtn.Text = "+";
            increaseBtn.UseVisualStyleBackColor = true;
            increaseBtn.Click += increaseBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Helvetica", 12.75F, FontStyle.Bold);
            button2.Location = new Point(421, 9);
            button2.Name = "button2";
            button2.Size = new Size(30, 37);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductInCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(increaseBtn);
            Controls.Add(SubTotalBox);
            Controls.Add(QuantityBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ProductInCart";
            Size = new Size(454, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox QuantityBox;
        private TextBox SubTotalBox;
        private Button increaseBtn;
        private Button button2;
    }
}
