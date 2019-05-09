using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok51
{
    class smartphone
    {
        private string merk, owner, warranty, status;
        private double price;
        public smartphone() {}
        public smartphone(string merk, string owner, string warranty, double price, string status) {
            this._merk(merk);
            this._owner(owner);
            this._warranty(warranty);
            this._price(price);
            this._status(status);
        }
        public string merk_()
        {
            return this.merk;
        }
        public string owner_()
        {
            return this.owner;
        }
        public string warranty_()
        {
            return this.warranty;
        }
        public Double price_()
        {
            return this.price;
        }
        public string status_()
        {
            return this.status;
        }
        public void _merk(string merk)
        {
            this.merk = merk;
        }
        public void _owner(string owner)
        {
            this.owner = owner;
        }
        public void _warranty(string warranty)
        {
            this.warranty = warranty;
        }
        public void _price(double price)
        {
            this.price = price;
        }
        public void _status(string status)
        {
            this.status = status;
        }
        public void print(string a)
        {
            Console.WriteLine(a);
        }
    }
}
