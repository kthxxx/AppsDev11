using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDiscountApp
{
    internal class Products
    {
        private List<Product> productList;
        public Products()
        {
            productList = new List<Product>();

            if (productList is null)
            {
                throw new ArgumentNullException("Failed to instantiate list");
            }
        }

        public bool AddProduct(string name, double price, int quantity)
        {
            if (productList is null)
            {
                throw new ArgumentNullException("Failed to instantiate List");
            }

            Product product = new Product(name, price, quantity);

            productList.Add(product);
            return true;
        }

        public bool RemoveProduct(string name)
        {
            if (productList is null)
            {
                throw new ArgumentNullException("List is null!");
            }
            foreach (Product p in productList)
            {
                if (p.Name == name)
                {
                    productList.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public bool UpdatePrice(string name, double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price must not be less than 0!");
            }

            if (productList.Count == 0)
            {
                return false;
            }

            foreach (Product p in productList)
            {
                if (p.Name.Equals(name))
                {
                    p.Price = price;
                    return true;
                }
            }
            return false;
        }

        public Product? GetProductDetails(string name)
        {
            foreach (Product item in productList)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }

        public double GetTotalPrice()
        {
            if (productList.Count == 0)
            {
                return 0;
            }

            double totalPrice = 0;

            foreach (Product p in productList)
            {
                totalPrice += p.Price * p.Quantity;
            }

            return totalPrice;
        }

        public double GetDiscountedPrice()
        {
            const double BASE_DISCOUNT = 0.1;
            double totalPrice = GetTotalPrice(), discountedPrice;

            if (totalPrice > 100 && totalPrice <= 200)
            {
                discountedPrice = totalPrice - (totalPrice / BASE_DISCOUNT);
            }
            else if (totalPrice > 200 && totalPrice <= 500)
            {
                discountedPrice = totalPrice - (totalPrice / (BASE_DISCOUNT + 0.05));
            }
            else if (totalPrice > 500)
            {
                discountedPrice = totalPrice - (totalPrice / (BASE_DISCOUNT + 0.1));
            }
            else
            {
                discountedPrice = totalPrice;
            }

            return discountedPrice;
        }
    }
}