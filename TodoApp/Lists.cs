using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Lists : Form
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void lists_Load(object sender, EventArgs e)
        {
            cbx_lists.DataSource = db.TodoListHandler.getLists();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            int listId = ((TodoList)cbx_lists.SelectedItem).id;
            Items items = new Items(listId);
            items.Show();
        }
    }
}
