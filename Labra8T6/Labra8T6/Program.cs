using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T6
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public InvoiceItem()
        {

        }
        public InvoiceItem(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Name + " " + Price + "e " + Quantity + " pieces ";
        }
    }
    public class Invoice
    {
        private List<InvoiceItem> items;
        public string Customer { get; set; }

        public Invoice()
        {
            items = new List<InvoiceItem>();
        }
        public void Add(InvoiceItem item)
        {
            items.Add(item);
        }
        public string Total()
        {
            double total = 0.00;
            foreach (InvoiceItem item in items)
            {
                total += item.Total();
            }
            return "Sum of InvoiceItems: " + total + " euros";
        }
        public void PrintInvoice()
        {
            string temp = "";
            temp += "Customer " + Customer + "'s invoice:\n";
            foreach (InvoiceItem item in items)
            {
                temp += item.ToString() + item.Total() + "e total" +  "\n";
            }
            temp += Total();
            Console.WriteLine(temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceItem item0 = new InvoiceItem("Banana", 0.39, 6);
            InvoiceItem item1 = new InvoiceItem("Beer", 1.19, 12);
            InvoiceItem item2 = new InvoiceItem("Cigarettes", 5.60, 1);

            Invoice invoice0 = new Invoice();
            invoice0.Customer = "Kirsi Kernel";
            invoice0.Add(item0);
            invoice0.Add(item1);
            invoice0.Add(item2);

            invoice0.PrintInvoice();
        }
    }
}
