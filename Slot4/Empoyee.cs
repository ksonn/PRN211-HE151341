using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class Empoyee
    {
        private int id;
        private String name;
        public Empoyee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
