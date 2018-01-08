using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.db
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
    }
}
