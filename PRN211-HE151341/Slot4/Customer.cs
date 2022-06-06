using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class Customer
    {
        private int Id;
        public int CustomerID {
            get { 
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public String CustomerName { get; set; } = "New Customer";
        public void Print() {
            Console.WriteLine($"ID:{CustomerID} , Name:{CustomerName}");  
          }
    }
}
