using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Customer
    {
        
        public static readonly string GOLD = "Vàng";
        public static readonly string SILVER = "Bạc";
        public static readonly string BRONZE = "Đồng";
        public static readonly string NORMAL = "Sắt";

        private int id;
        private string name;
        private string phone;
        private string address;
        private string type;
        private double sum;

        
        public Customer() { }
        public Customer(int id, string name, string phone, string address, string type, double sum)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.type = type;
            this.sum = sum;
        }
        public Customer(int id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.type = NORMAL;
            this.sum = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Type { get => type; set => type = value; }
        public double Sum { get => sum; set => sum = value; }

        public string updateType(double sum)
        {
            if(sum >= 0 && sum < 2000)
            {
                return Customer.NORMAL;
            }
            if(sum >= 2000 && sum < 5000)
            {
                return Customer.BRONZE;
            }
            if(sum >= 5000 && sum < 10000)
            {
                return Customer.SILVER;
            }
            if(sum >= 10000)
            {
                return Customer.GOLD;
            }
            return null;
        }

        
    }
}
