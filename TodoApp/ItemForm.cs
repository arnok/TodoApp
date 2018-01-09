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
    public partial class ItemForm : Form
    {
        public Item result;

        public ItemForm(Item item)
        {
            this.result = item;
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.result.name = tbx_name.Text;
            this.result.done = cbx_done.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            tbx_name.Text = this.result.name;
            cbx_done.Checked = this.result.done;
        }
    }
}
