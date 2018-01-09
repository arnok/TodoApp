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
    public partial class Items : Form
    {
        private TodoList list;

        public Items(int listId)
        {
            InitializeComponent();
            list = db.TodoListHandler.getList(listId);
            lbx_items.DataSource = list.items;
            lbl_list.Text = list.name;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
