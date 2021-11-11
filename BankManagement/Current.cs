using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Current : Account
    {
        internal override string Id
        {
            set { base.Id = "C-" + value; }
        }
        internal Current(string name, OpeningDate date, AddressFormat address, double balance) : base(name, date, address, balance)
        {

        }
        internal override void Information()
        {
            base.Information();
        }
    }
}
