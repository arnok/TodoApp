﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TodoApp.db
{
    public static class ItemHandler
    {
        public static List<Item> getItems(int listId)
        {
            string query = "SELECT id,name,done FROM items WHERE list_id = @list_id;";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@list_id", listId);

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

    }
}
