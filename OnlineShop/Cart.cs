using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();

        public int Count { get {return items.Count();} }

        public void Add(Product product)
        {
            CartItem selectedProduct = null;
            foreach (CartItem item in items)
            {
                if (item.Product.Name == product.Name)
                {
                    selectedProduct = item;
                    break; 
                }
            }
            if (selectedProduct != null)
            {
                selectedProduct.Count++;
            }
            else
            {
                items.Add(new CartItem(product));
            }
        }

        public void Delete()
            {  }

        
        public CartItem[] getAll()
            { return items.ToArray(); }

        public void AddOneInCart(CartItem item)
        {
            if (item != null)
            {
                item.Count++;
            }
        }

        public void RemoveOneInCart(CartItem item)
        {
            if (item != null)
            {
                item.Count--;
                if (item.Count <= 0)
                {
                    items.Remove(item);
                }
            }
        }

    }
}
