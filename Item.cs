using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Item
    {
        public int id;
        public string name;
        public bool done;

        public Item(int id, string name, bool done)
        {
            this.id = id;
            this.name = name;
            this.done = done;
        }
    }
}
