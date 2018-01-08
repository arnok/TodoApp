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
                int id = (int)reader["Id"];
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
    }
}
