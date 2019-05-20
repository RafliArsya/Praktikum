using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOM
{
    class bankmgr
    {
        public static List<bankmgr> UserList = new List<bankmgr>();
        public static void ListToArray(string[] array)
        {
            Console.WriteLine("Array received: " + array.Length);
        }
        private string username;
        private string name;
        private string password;
        private double balance;

        public bankmgr() { }
        public bankmgr(string username, string name, string pass, double balance = 0)
        {
            this.username_(username);
            this.name_(name);
            this.pass_(pass);
            this.balance_(balance);
        }
        public static void AddUserToList(bankmgr account)
        {
            UserList.Add(account);
        }
        public void name_(string arga)
        {
            this.name = arga;
        }
        public void pass_(string arga)
        {
            this.password = arga;
        }
        public void balance_(double arga)
        {
            this.balance = arga;
        }
        public void username_(string arga)
        {
            this.username = arga;
        }

        public string _name()
        {
            return name;
        }
        public string _pass()
        {
            return password;
        }
        public double _balance()
        {
            return balance;
        }
        public string _username()
        {
            return username;
        }
        public double deposit(double arga)
        {
            double current = _balance();
            double now = current + arga;
            return now;
        }
        public void _deposit(double amount=0)
        {
            this.balance = this.deposit(amount);
        }
        public void _withdraw(double amount = 0)
        {
            this.balance = this.withdraw(amount);
        }
        public double withdraw(double arga)
        {
            double current = _balance();
            double temp = current - arga;
            if (temp < 0)
            {
                return current;
            }
            tinfo(1);
            return temp;
        }
        public void tinfo(int arga)
        {
            switch (arga)
            {
                case 1:
                    {
                        Console.WriteLine("Transaction Successful!\nYour current balance is now {0}", this._balance());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Transaction Failed!\nYour current balance is {0}", this._balance());
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Your current balance is {0}", this._balance());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error 404: Parameter not found!");
                        break;
                    }
            }
        }
    }
}
