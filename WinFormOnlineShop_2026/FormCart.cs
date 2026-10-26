using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCart : Form
    {
        Cart cart;
        public FormCart(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
            ShowCart();
        }

        void ShowCart()
        {
            listBoxCart.Items.Clear();
            decimal totalOrderPrice = 0;
            foreach (CartItem item in this.cart.getAll())
            {
                decimal itemSum = item.Product.Price * item.Count;
                totalOrderPrice += itemSum;
                string row = $"{item.Product.Name} \t| Цена: {item.Product.Price} руб. \t| Кол-во: {item.Count} шт. \t| Стоимость: {itemSum} руб.";
                listBoxCart.Items.Add(row);
            }
            labelTotal.Text = $"Итого к оплате: {totalOrderPrice} руб.";
        }

        private void FormCart_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex != -1)
            {
                CartItem selectedItem = this.cart.getAll()[listBoxCart.SelectedIndex];
                this.cart.AddOneInCart(selectedItem);
                int savedIndex = listBoxCart.SelectedIndex;
                ShowCart();
                if (listBoxCart.Items.Count > 0)
                    listBoxCart.SelectedIndex = savedIndex;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex != -1)
            {
                CartItem selectedItem = this.cart.getAll()[listBoxCart.SelectedIndex];
                this.cart.RemoveOneInCart(selectedItem);
                int savedIndex = listBoxCart.SelectedIndex;
                ShowCart();
                if (listBoxCart.Items.Count > 0)
                {
                    if (savedIndex >= listBoxCart.Items.Count)
                        listBoxCart.SelectedIndex = listBoxCart.Items.Count - 1;
                    else
                        listBoxCart.SelectedIndex = savedIndex;
                }
            }
        }
    }
}
