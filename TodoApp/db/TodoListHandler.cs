using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TodoApp.db
{
    public static class TodoListHandler
    {
        public static List<TodoList> getLists()
        {
            string query = "SELECT id,name FROM lists;";
            SqlCommand cmd = new SqlCommand(query);

            SqlDataReader reader = database.Query(cmd);

            List<TodoList> lists = new List<TodoList>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = (string)reader["name"];

                lists.Add(new TodoList(id, name, null));
            }
            return lists;

            // TODO: more specific exception
            throw new Exception();

        }

        public static TodoList getList(int id)
        {
            string query = "SELECT name FROM lists WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);

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

        public static bool updateList(TodoList list)
        {
            string query = "UPDATE lists SET name = @name WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", list.id);
            cmd.Parameters.AddWithValue("@name", list.name);

            return (database.NonQuery(cmd) == 1);
        }

        public static void newList(TodoList list)
        {
            string query = "INSERT INTO lists (name) VALUES(@name); ";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@name", list.name);

            database.NonQuery(cmd);
        }

        public static void deleteList(TodoList list)
        {
            string query = "DELETE FROM items WHERE list_id = @id; DELETE FROM lists WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", list.id);

            database.NonQuery(cmd);
        }
    }
}
