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
            TodoList list = new TodoList(-1, "", null);
            List listForm = new List(list);
            if (listForm.ShowDialog() == DialogResult.OK)
            {
                db.TodoListHandler.newList(listForm.result);
                updateList();
            }
        }

        private void lists_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            cbx_lists.DataSource = null;
            cbx_lists.DataSource = db.TodoListHandler.getLists();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            int listId = ((TodoList)cbx_lists.SelectedItem).id;
            Items items = new Items(listId);
            items.Show();
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            TodoList list = (TodoList)cbx_lists.SelectedItem;
            List listForm = new List(list);
            if(listForm.ShowDialog() == DialogResult.OK)
            {
                bool success = db.TodoListHandler.updateList(listForm.result);
                updateList();
            }
        }
    }
}
