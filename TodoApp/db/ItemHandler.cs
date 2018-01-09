using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TodoApp.db
{
    public static class ItemHandler
    {
        public static List<Item> getItems(int list_id)
        {
            string query = "SELECT id,name,done FROM items WHERE list_id = @list_id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@list_id", list_id);

            SqlDataReader reader = database.Query(cmd);

            List<Item> items = new List<Item>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = (string)reader["name"];
                bool done = (bool)reader["done"];

                items.Add(new Item(id, name, done));
            }
            return items;

            // TODO: more specific exception
            throw new Exception();
        }

        public static Item getItem(int id)
        {
            string query = "SELECT id,name,done FROM items WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = database.Query(cmd);

            reader.Read();

            string name = (string)reader["name"];
            bool done = (bool)reader["done"];

            return new Item(id, name, done);
        }

        public static bool updateItem(Item item)
        {
            string query = "UPDATE items SET name = @name, done = @done WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", item.id);
            cmd.Parameters.AddWithValue("@name", item.name);
            cmd.Parameters.AddWithValue("@done", item.done);

            return (database.NonQuery(cmd) == 1);
        }

        public static void newItem(Item item, int list_id)
        {
            string query = "INSERT INTO items (name, done, list_id) VALUES(@name, @done, @list_id);";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@name", item.name);
            cmd.Parameters.AddWithValue("@done", item.done);
            cmd.Parameters.AddWithValue("@list_id", list_id);

            database.NonQuery(cmd);
        }

        public static void deleteItem(Item item)
        {
            string query = "DELETE FROM items WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", item.id);

            database.NonQuery(cmd);
        }
    }
}
