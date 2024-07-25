using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Product
    {
        private int id;
        private int quantity;
        private string name;
        private double price;
        public Product() { }
        public Product(int id, int quantity, string name, double price)
        {
            this.id = id;
            this.quantity = quantity;
            this.name = name;
            this.price = price;
        }

        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

    }
}
