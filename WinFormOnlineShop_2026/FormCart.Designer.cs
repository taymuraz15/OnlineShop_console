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
            buttonPlus = new Button();
            buttonMinus = new Button();
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
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.ActiveCaption;
            buttonPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(282, 18);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(46, 51);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "+";
            buttonPlus.TextAlign = ContentAlignment.TopCenter;
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.ActiveCaption;
            buttonMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMinus.Location = new Point(365, 18);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(46, 51);
            buttonMinus.TabIndex = 4;
            buttonMinus.Text = "-";
            buttonMinus.TextAlign = ContentAlignment.TopCenter;
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
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
        private Button buttonPlus;
        private Button buttonMinus;
    }
}