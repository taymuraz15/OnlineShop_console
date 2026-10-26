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
    }
}
