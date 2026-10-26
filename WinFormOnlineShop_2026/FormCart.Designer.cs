namespace WinFormOnlineShop_2026
{
    partial class FormCart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCart = new ListBox();
            labelTotal = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxCart
            // 
            listBoxCart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 25;
            listBoxCart.Location = new Point(12, 87);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(761, 229);
            listBoxCart.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(12, 349);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 50);
            labelTotal.TabIndex = 1;
            labelTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 2;
            label1.Text = "Корзина";
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelTotal);
            Controls.Add(listBoxCart);
            Name = "FormCart";
            Text = "Корзина";
            Load += FormCart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxCart;
        private Label labelTotal;
        private Label label1;
    }
}