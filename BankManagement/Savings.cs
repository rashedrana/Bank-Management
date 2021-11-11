using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Savings : Account
    {
        internal override string Id
        {
            set { base.Id = "S-" + value; }
        }
        internal Savings(string name, OpeningDate date, AddressFormat address, double balance) : base(name, date, address, balance)
        {

        }
        internal override void Information()
        {
            base.Information();
        }
    }
}