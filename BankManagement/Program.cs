using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancialAccount.Add(new Savings("Rashed Rana", new OpeningDate(06, 03, 2021), new AddressFormat(8, 6, "Dhaka", "Bangladesh"), 40000.50));
            FinancialAccount.Add(new Current("Shakib Al Hasan", new OpeningDate(15, 10, 2020), new AddressFormat(4, 6, "Chandpur", "Bangladesh"), 35000.0));
            FinancialAccount.Add(new Savings("Mashrafe Mortaza", new OpeningDate(5, 09, 2015), new AddressFormat(7, 30, "Chittagong", "Bangladesh"), 50000.75));
            FinancialAccount.Add(new Loan("Mushfiqur Rahim", new OpeningDate(13, 05, 2019), new AddressFormat(19, 4, "Cumilla", "Bangladesh"), 100000.0));
            FinancialAccount.Add(new Savings("Mahmudullah Riyad", new OpeningDate(25, 03, 2018), new AddressFormat(2, 1, "Dhaka", "Bangladesh"), 25000));
            FinancialAccount.Add(new Savings("Tamim Iqbal", new OpeningDate(7, 08, 2016), new AddressFormat(2, 1, "Munsiganj", "Bangladesh"), 22000));
            FinancialAccount.Add(new Savings("Nasir Hossain", new OpeningDate(13, 03, 2017), new AddressFormat(12, 7, "Dhaka", "Bangladesh"), 36000));
            FinancialAccount.Add(new Savings("Anamul Haque", new OpeningDate(17, 03, 2019), new AddressFormat(4, 10, "Barishal", "Bangladesh"), 42000));
            FinancialAccount.Add(new Savings("Mostafizur Rahman", new OpeningDate(23, 04, 2020), new AddressFormat(32, 3, "Dhaka", "Bangladesh"), 120000));
            FinancialAccount.Add(new Savings("Mominul Haque", new OpeningDate(27, 02, 2021), new AddressFormat(44, 15, "Barishal", "Bangladesh"), 450000));
            FinancialAccount.ShowInformation();
            
        }
    }
}
