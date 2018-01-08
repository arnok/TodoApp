using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TodoApp.db
{
    public static class TodoListHandler
    {
        public static TodoList getList(int id)
        {
            string query = "SELECT name FROM lists WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = id;

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
