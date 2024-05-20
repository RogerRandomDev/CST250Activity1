namespace CarShopGUI
{
    partial class Form1
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
            CarCreatorGpBx = new GroupBox();
            CarCreateBtn = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            AddCartBtn = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            CostLbl = new Label();
            CheckoutBtn = new Button();
            listBox2 = new ListBox();
            CarCreatorGpBx.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CarCreatorGpBx
            // 
            CarCreatorGpBx.Controls.Add(CarCreateBtn);
            CarCreatorGpBx.Controls.Add(textBox5);
            CarCreatorGpBx.Controls.Add(label5);
            CarCreatorGpBx.Controls.Add(textBox4);
            CarCreatorGpBx.Controls.Add(label4);
            CarCreatorGpBx.Controls.Add(textBox3);
            CarCreatorGpBx.Controls.Add(label3);
            CarCreatorGpBx.Controls.Add(textBox2);
            CarCreatorGpBx.Controls.Add(label2);
            CarCreatorGpBx.Controls.Add(textBox1);
            CarCreatorGpBx.Controls.Add(label1);
            CarCreatorGpBx.Location = new Point(12, 12);
            CarCreatorGpBx.Name = "CarCreatorGpBx";
            CarCreatorGpBx.Size = new Size(200, 264);
            CarCreatorGpBx.TabIndex = 0;
            CarCreatorGpBx.TabStop = false;
            CarCreatorGpBx.Text = "Create A Car";
            // 
            // CarCreateBtn
            // 
            CarCreateBtn.Location = new Point(48, 176);
            CarCreateBtn.Name = "CarCreateBtn";
            CarCreateBtn.Size = new Size(98, 23);
            CarCreateBtn.TabIndex = 14;
            CarCreateBtn.Text = "Create Car";
            CarCreateBtn.UseVisualStyleBackColor = true;
            CarCreateBtn.Click += CarCreateBtn_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(65, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Year";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Color";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Model";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Make";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(218, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 426);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Inventory";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 394);
            listBox1.TabIndex = 0;
            // 
            // AddCartBtn
            // 
            AddCartBtn.Location = new Point(447, 188);
            AddCartBtn.Name = "AddCartBtn";
            AddCartBtn.Size = new Size(98, 23);
            AddCartBtn.TabIndex = 15;
            AddCartBtn.Text = "Add To Cart ->";
            AddCartBtn.UseVisualStyleBackColor = true;
            AddCartBtn.Click += AddCartBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CostLbl);
            groupBox2.Controls.Add(CheckoutBtn);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(551, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 426);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Shopping Cart";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 404);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 16;
            label6.Text = "Total Cost:";
            // 
            // CostLbl
            // 
            CostLbl.AutoSize = true;
            CostLbl.Location = new Point(82, 404);
            CostLbl.Name = "CostLbl";
            CostLbl.Size = new Size(89, 15);
            CostLbl.TabIndex = 15;
            CostLbl.Text = "Nothing In Cart";
            // 
            // CheckoutBtn
            // 
            CheckoutBtn.Location = new Point(82, 358);
            CheckoutBtn.Name = "CheckoutBtn";
            CheckoutBtn.Size = new Size(98, 23);
            CheckoutBtn.TabIndex = 16;
            CheckoutBtn.Text = "Checkout";
            CheckoutBtn.UseVisualStyleBackColor = true;
            CheckoutBtn.Click += CheckoutBtn_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(6, 25);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(211, 274);
            listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(AddCartBtn);
            Controls.Add(groupBox1);
            Controls.Add(CarCreatorGpBx);
            Name = "Form1";
            Text = "Form1";
            CarCreatorGpBx.ResumeLayout(false);
            CarCreatorGpBx.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CarCreatorGpBx;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button CarCreateBtn;
        private Button AddCartBtn;
        private GroupBox groupBox2;
        private Label label6;
        private Label CostLbl;
        private Button CheckoutBtn;
        private ListBox listBox2;
    }
}
