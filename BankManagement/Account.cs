using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal struct OpeningDate
    {
        private byte day;
        private byte month;
        private ushort year;

        internal OpeningDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        internal void PrintDate()
        {
            Console.WriteLine("Opening Date: {0}-{1}-{2}", day, month, year);
        }
    }
    struct AddressFormat
    {
        private byte apartmentNumber;
        private byte roadNumber;
        private string district;
        private string country;

        public AddressFormat(byte apartmentNumber, byte roadNumber, string district, string country)
        {
            this.apartmentNumber = apartmentNumber;
            this.roadNumber = roadNumber;
            this.district = district;
            this.country = country;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Appartment No: {0}", this.apartmentNumber);
            Console.WriteLine("Road No: {0}", this.roadNumber);
            Console.WriteLine("District: {0}", this.district);
            Console.WriteLine("Country: {0}", this.country);
        }
    }
    class Account
    {
        private string name;
        private string id;
        private OpeningDate date;
        private AddressFormat address;
        private double balance;
        private static int serialNo = 0;


        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "A" + value; }
        }
     

        internal OpeningDate Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        internal Account(string name, OpeningDate date, AddressFormat address, double balance)
        {
            this.Name = name;
            this.Id = (++serialNo).ToString();
            this.Date = date;
            this.Address = address;
            this.Balance = balance;
        }
        internal virtual void Information()
        {
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            this.Date.PrintDate();
            this.Address.PrintAddress();
            Console.WriteLine("Balance: {0}", this.Balance);

            
        }
    }
}
 