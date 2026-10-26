namespace WinFormOnlineShop_2026
{
    partial class FormCatalog
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
            panelCatalog = new Panel();
            listBoxCatalog = new ListBox();
            label1 = new Label();
            splitter1 = new Splitter();
            panelProduct = new Panel();
            buttonShowCart = new Button();
            buttonAddToCart = new Button();
            labelPrice = new Label();
            labelDescription = new Label();
            labelProductName = new Label();
            label2 = new Label();
            panelCatalog.SuspendLayout();
            panelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panelCatalog
            // 
            panelCatalog.Controls.Add(listBoxCatalog);
            panelCatalog.Controls.Add(label1);
            panelCatalog.Dock = DockStyle.Left;
            panelCatalog.Location = new Point(0, 0);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(252, 450);
            panelCatalog.TabIndex = 0;
            // 
            // listBoxCatalog
            // 
            listBoxCatalog.FormattingEnabled = true;
            listBoxCatalog.ItemHeight = 15;
            listBoxCatalog.Location = new Point(27, 63);
            listBoxCatalog.Name = "listBoxCatalog";
            listBoxCatalog.Size = new Size(219, 349);
            listBoxCatalog.TabIndex = 1;
            listBoxCatalog.SelectedIndexChanged += listBoxCatalog_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Список товаров";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(252, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelProduct
            // 
            panelProduct.BackColor = SystemColors.ControlLight;
            panelProduct.Controls.Add(buttonShowCart);
            panelProduct.Controls.Add(buttonAddToCart);
            panelProduct.Controls.Add(labelPrice);
            panelProduct.Controls.Add(labelDescription);
            panelProduct.Controls.Add(labelProductName);
            panelProduct.Controls.Add(label2);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(255, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(545, 450);
            panelProduct.TabIndex = 2;
            // 
            // buttonShowCart
            // 
            buttonShowCart.BackColor = Color.Thistle;
            buttonShowCart.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonShowCart.Location = new Point(114, 380);
            buttonShowCart.Name = "buttonShowCart";
            buttonShowCart.Size = new Size(286, 48);
            buttonShowCart.TabIndex = 6;
            buttonShowCart.Text = "ПЕРЕЙТИ В КОРЗИНУ";
            buttonShowCart.UseVisualStyleBackColor = false;
            buttonShowCart.Click += buttonShowCart_Click;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.BackColor = SystemColors.ActiveCaption;
            buttonAddToCart.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddToCart.Location = new Point(114, 298);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(286, 48);
            buttonAddToCart.TabIndex = 5;
            buttonAddToCart.Text = "ДОБАВИТЬ В КОРЗИНУ";
            buttonAddToCart.UseVisualStyleBackColor = false;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(114, 251);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(74, 30);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "0 руб.";
            // 
            // labelDescription
            // 
            labelDescription.BackColor = SystemColors.ActiveCaption;
            labelDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelDescription.ForeColor = SystemColors.ActiveCaptionText;
            labelDescription.Location = new Point(114, 98);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(286, 132);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Название товара";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelProductName.Location = new Point(114, 58);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(186, 30);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Название товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 30);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Карточка товара";
            // 
            // FormCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelProduct);
            Controls.Add(splitter1);
            Controls.Add(panelCatalog);
            Name = "FormCatalog";
            Text = "Каталог";
            panelCatalog.ResumeLayout(false);
            panelCatalog.PerformLayout();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCatalog;
        private Splitter splitter1;
        private Panel panelProduct;
        private ListBox listBoxCatalog;
        private Label label1;
        private Label labelProductName;
        private Label label2;
        private Label labelDescription;
        private Label labelPrice;
        private Button buttonAddToCart;
        private Button buttonShowCart;
    }
}
