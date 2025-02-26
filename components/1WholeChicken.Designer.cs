namespace GroceryDiscountApp.components
{
    partial class _1WholeChicken
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_1WholeChicken));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            allProduct1 = new AllProduct();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 219);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 44;
            label2.Text = "230₱ ";
            label2.Click += WholeChickenClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 180);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 43;
            label1.Text = "Whole Chicken";
            label1.Click += WholeChickenClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += WholeChickenClicked;
            // 
            // allProduct1
            // 
            allProduct1.AutoScroll = true;
            allProduct1.Location = new Point(116, 230);
            allProduct1.Margin = new Padding(3, 4, 3, 4);
            allProduct1.Name = "allProduct1";
            allProduct1.Size = new Size(771, 944);
            allProduct1.TabIndex = 45;
            // 
            // _1WholeChicken
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 162, 184);
            Controls.Add(allProduct1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "_1WholeChicken";
            Size = new Size(179, 252);
            Load += _1WholeChicken_Load;
            Click += WholeChickenClicked;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private AllProduct allProduct1;
    }
}
