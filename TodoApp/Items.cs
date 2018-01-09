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
            updateList();
        }

        private void updateList()
        {
            lbx_items.DataSource = null;
            list = db.TodoListHandler.getList(this.list.id);
            if(cbx_show.Checked)
            {
                lbx_items.DataSource = list.items;
            }
            else
            {
                lbx_items.DataSource = list.items.Where(x => !x.done).ToList();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Item item = new Item(-1, "", false);
            ItemForm itemForm = new ItemForm(item);
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                db.ItemHandler.newItem(itemForm.result, this.list.id);
                updateList();
            }
            updateList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Item item = (Item)lbx_items.SelectedItem;
            ItemForm itemForm = new ItemForm(item);
            if (itemForm.ShowDialog() == DialogResult.OK)
            {
                bool success = db.ItemHandler.updateItem(itemForm.result);
                updateList();
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            Item item = (Item)lbx_items.SelectedItem;
            item.done = !item.done;
            bool success = db.ItemHandler.updateItem(item);
            updateList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Item item = (Item)lbx_items.SelectedItem;
            db.ItemHandler.deleteItem(item);
            updateList();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            lbl_list.Text = this.list.name;
        }

        private void cbx_show_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void lbx_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbx_items.SelectedIndex != -1)
            {
                btn_done.Text = ((Item)lbx_items.SelectedItem).done ? "Undo" : "Done";
            }
        }
    }
}
