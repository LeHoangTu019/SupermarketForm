using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entity
{
    public class Employee
    {
        // Dùng mọi nơi và chỉ được đọc
        //Set quyền
        public static readonly string ADMIN = "Quản lý";
        public static readonly string EMPLOYEE = "Nhân viên";

        private int ID;
        private string username;
        private string password;
        private string type;

        public Employee(int iD, string username, string password, string type)
        {
            ID = iD;
            this.username = username;
            this.password = password;
            this.type = type;
        }
        public Employee() { }
        public int ID1 { get => ID; set => ID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }

        
    }

   

}
