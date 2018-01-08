using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.db
{
    public static class ItemHandler
    {
        public static List<Item> getItems(int listId)
        {
            string query = "SELECT name FROM items WHERE listId = @listId;";
            SqlCommand cmd = new SqlCommand(query);
            SqlDataReader reader = database.Query(cmd);

            while (reader.Read())
            {
                string name = (string)reader["name"];
                List<Item> items = ItemHandler.getItems(id);

                return new TodoList(id, name, items);
            }

            // TODO: more specific exception
            throw new Exception();
        }

    }
}
