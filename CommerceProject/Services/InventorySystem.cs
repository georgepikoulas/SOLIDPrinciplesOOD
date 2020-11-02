using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceProject.Services
{
    public class InventorySystem
    {
        public void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}
