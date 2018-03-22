using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoList
    {
        public int id;
        public string name;
        public List<Item> items;

        public TodoList(int id, string name, List<Item> items)
        {
            this.id = id;
            this.name = name;
            this.items = items;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string ToString(string format)
        {
            return String.Format(format, this.name);
        }
    }
}
