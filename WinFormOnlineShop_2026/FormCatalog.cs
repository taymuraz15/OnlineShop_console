using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "по информатике"));
            ShowCatalog();
        }

        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCatalog.SelectedIndex != -1)
            {
                int catalogIndex = listBoxCatalog.SelectedIndex + 1;
                Product selectedProduct = catalog[catalogIndex];
                labelProductName.Text = selectedProduct.Name;
                labelDescription.Text = selectedProduct.Description;
                labelPrice.Text = $"{selectedProduct.Price} руб.";
            }
        }
    }
}
