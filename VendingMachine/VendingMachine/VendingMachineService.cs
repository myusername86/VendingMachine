using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachineService : IVending
    {
        public string Details(int productId)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, int> EndTransaction()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(int amount)
        {
            throw new NotImplementedException();
        }

        public Product Purchase(int productId)
        {
            throw new NotImplementedException();
        }

        public List<string> ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}
