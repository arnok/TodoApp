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
    public partial class List : Form
    {
        public TodoList result;

        public List(TodoList list)
        {
            this.result = list;
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.result.name = tbx_name.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void List_Load(object sender, EventArgs e)
        {
            tbx_name.Text = this.result.name;
        }
    }
}
