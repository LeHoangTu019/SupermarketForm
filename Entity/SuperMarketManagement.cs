using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    internal class SuperMarketManagement
    {
        private List<Product> products;
        private List<Customer> customers;
        private List<Bill> bills;
        private List<Employee> employees;
        static Employee loginEmployee;
        public SuperMarketManagement()
        {
            initDatabase();
        }

        public List<Product> Products { get => products; set => products = value; }
        public List<Customer> Customers { get => customers; set => customers = value; }
        public List<Bill> Bills { get => bills; set => bills = value; }
        internal List<Employee> Employees { get => employees; set => employees = value; }
        public Employee LoginEmployee { get => loginEmployee; set => loginEmployee = value; }
        

        private void initDatabase()
        {
            products = new List<Product>();
            customers = new List<Customer>();
            bills = new List<Bill>();
            Employees = new List<Employee>();
            initProduct();
            initCustomer();
            initBill();
            initEmployee();
        }

        private void initEmployee()
        {
            Employees.Add(new Employee(1, "Admin", "conmeo", Employee.ADMIN));
            Employees.Add(new Employee(2, "wjbu", "123", Employee.EMPLOYEE));
            Employees.Add(new Employee(3, "Tu", "123", Employee.EMPLOYEE));
            Employees.Add(new Employee(4, "Tien", "123", Employee.EMPLOYEE));
            Employees.Add(new Employee(5, "Thinh", "123", Employee.EMPLOYEE));
        }
        
        private void initProduct()
        {
            products.Add(new Product(1, 2, "Chicken", 100));
            products.Add(new Product(2, 2, "Beef", 220));
            products.Add(new Product(3, 2, "Pork", 120));
            products.Add(new Product(4, 100, "Milk", 30));
            products.Add(new Product(5, 100, "Apple", 40));
            products.Add(new Product(6, 100, "Mango", 40));
            products.Add(new Product(7, 100, "Mushroom", 100));
            products.Add(new Product(8, 100, "Cabbage", 20));
        }

        private void initCustomer()
        {
            customers.Add(new Customer(1, "Le Hoang Tu", "0919719xxx", "Ho Chi Minh City",Customer.GOLD, 1000000));
            customers.Add(new Customer(2, "Le Hoang Nam", "038xxxxxxx", "Ho Chi Minh City"));
        }

        private void initBill()
        {
            List<BillDetail> billDetails = new List<BillDetail>();
            billDetails.Add(new BillDetail(1,1,4));
            billDetails.Add(new BillDetail(1,3,2));
            billDetails.Add(new BillDetail(1,6,2));
            Bill bill1 = new Bill(billDetails, 1, 1);
            bills.Add(bill1);
        }

        public void addProduct(Product product)
        {
            if(products.Count > 0)
            {
                product.Id = products[products.Count - 1].Id + 1;
                products.Add(product);
            }
            else
            {
                product.Id = 1;
                products.Add(product);
            }
            
        }

        public void updateProduct(Product product)
        {
            foreach(Product item in products)
            {
                if(item.Id == product.Id)
                {
                    item.Price = product.Price;
                    item.Name = product.Name;
                    item.Quantity = product.Quantity;
                    break;
                }
            }
        }
        public bool login(string username, string password)
        {
            foreach(Employee employee in employees)
            {
                if(username == employee.Username && password == employee.Password) 
                {
                    loginEmployee = employee;
                    return true;
                }
            }
            return false;
        }
        public void deleteProduct(Product product) 
        {
            foreach( Product item in products)
            {
                if(item.Id == product.Id)
                {
                    products.Remove(item);
                    return;
                }
            }
        }

        public void addCustomer(Customer customer)
        {
            if(customers.Count > 0)
            {
                customer.Id = customers[customers.Count - 1].Id + 1;
                customers.Add(customer);
            }
            else
            {
                customer.Id = 1;
                customers.Add(customer);
            }
        }

        public void updateCustomer(Customer customer)
        {
            foreach (Customer item in customers)
            {
                if(item.Id == customer.Id)
                {
                    item.Address = customer.Address;
                    item.Name = customer.Name; 
                    item.Phone = customer.Phone;
                    item.Sum = customer.Sum;
                    item.Type = customer.Type;
                }
            }
        }

        public void deleteCustomer(Customer customer)
        {
            foreach ( Customer item in customers)
            {
                if (item.Id == customer.Id)
                {
                    //Bill bill = findBillByID(customer.Id);
                    //bills.Remove(bill);
                    deleteBill(customer.Id);
                    customers.Remove(item);
                    return;
                }
            }
        }

        public void deleteBill(int id)
        {
            foreach (Bill bill in bills)
            {
                if(bill.BillID == id)
                {
                    bills.Remove(bill);
                    return;
                }
            }
        }

        public void addBill(Bill bill)
        {
            if (bills.Count > 0)
            {
                bill.BillID = bills[bills.Count - 1].BillID + 1;
            }
            else if (bills.Count == 0) bill.BillID = 1;
            
            foreach(BillDetail billDetail in bill.BillDetails)
            {
                billDetail.BillID = bill.BillID;
            }
            bills.Add(bill);
        }

        public void addEmployee(Employee employee)
        {
            if (employees.Count > 0)
            {
                employee.ID1 = employees[employees.Count - 1].ID1 + 1;
                employees.Add(employee);
            }
        }

        public void updateEmployee(Employee employee)
        {
            foreach (Employee employee1 in employees)
            {
                if (employee1.ID1 == employee.ID1)
                {
                    employee1.Username = employee.Username;
                    employee1.Password = employee.Password;
                    employee1.Type = employee.Type;
                    break;
                }
            }
        }
        public void deleteEmployee(Employee employee)
        {
            foreach (Employee employee1 in employees)
            {
                if (employee1.ID1 == employee.ID1)
                {
                    employees.Remove(employee1);
                    return;
                }
            }
        }
        public static Customer findCustomerByID(int id)
        {
            foreach (Customer customer in Program.superMarketManagement.Customers)
            {
                if (id == customer.Id)
                {
                    return customer;
                }
            }
            return null;
        }


        public static Product findProductById(int id)
        {
            
            foreach (Product product in Program.superMarketManagement.Products)
            {
                if (product.Id == id) return product;
            }
            return null;
        }

        public static Bill findBillByID(int id)
        {
            foreach (Bill bill in Program.superMarketManagement.bills)
            {
                if(bill.BillID == id) return bill;
            }
            return null;
        }
    }
}
