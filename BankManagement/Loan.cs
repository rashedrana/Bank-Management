using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Loan : Account
    {
        internal override string Id
        {
            set { base.Id = "L-" + value; }
        }
        internal Loan(string name, OpeningDate date, AddressFormat address, double balance) : base(name, date, address, balance)
        {
        }
        internal override void Information()
        {
            base.Information();
        }
    }
}
