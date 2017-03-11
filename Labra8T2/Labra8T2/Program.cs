using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T2
{
    class ShoppingCart
    {
        private Dictionary<Product, int> contents;

        public ShoppingCart()
        {
            contents = new Dictionary<Product, int>();
        }
        public void Add(Product product)
        {
            if (contents.ContainsKey(product))
            {
                contents[product]++;
            }
            else
            {
                contents.Add(product, 1);
            }
        }
        public void Remove(Product product)
        {
            if (contents.ContainsKey(product))
            {
                contents[product]--;
                if (contents[product] == 0)
                {
                    contents.Remove(product);
                }
            }
        }
        public override string ToString()
        {
            string temp = "";
            foreach (KeyValuePair<Product, int> product in contents)
            {
                temp += product.ToString() + "\n";
            }
            return "Products in cart:\n" + temp;
        }
    }
    class Product
    {
        private string id;
        private double price;

        public double Price { get { return price; } }

        public Product()
        {

        }
        public Product(string name, double priceIn)
        {
            id = name;
            price = priceIn;
        }
        public override string ToString()
        {
            return "Product [" + id + "]: " + price + "e";
        }
    }
    class Wallet
    {
        private double money;

        public double Money { get { return money; } set { money = value; } }

        public Wallet()
        {

        }
        public Wallet(double moneyIn)
        {
            money = moneyIn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product0 = new Product("Beer", 1.19);
            Product product1 = new Product("Milk", 1.29);
            Product product2 = new Product("Juice", 1.79);
            Product product3 = new Product("Lemonade", 3.10);

            ShoppingCart cart0 = new ShoppingCart();
            cart0.Add(product0);
            cart0.Add(product1);
            cart0.Add(product1);
            cart0.Add(product1);
            cart0.Add(product2);
            cart0.Add(product3);
            cart0.Remove(product3);
            Console.WriteLine(cart0.ToString());



            List<Product> cart1 = new List<Product>();
            // Add beer into the cart until you run out of money
            Wallet wallet0 = new Wallet(20);
            do
            {
                cart1.Add(product0);
                wallet0.Money -= product0.Price;
            } while (wallet0.Money > product0.Price);
            Console.WriteLine("Products in cart:");
            foreach (Product product in cart1)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine("Your change is: " + wallet0.Money + "e");
        }
    }
}
