using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal static class FinancialAccount
    {
        private static Account[] accounts = new Account[500];
        private static int count = 0;

        internal static void Add(Account u)
        {
            accounts[count] = u; 
            count++;
        }
        internal static void ShowInformation()
        {
            int index = 0;
            while (index < count)
            {
                accounts[index].Information();
                Console.WriteLine();
                index++;
            }
        }
    }
}