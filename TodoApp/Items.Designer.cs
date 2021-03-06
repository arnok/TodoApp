﻿namespace TodoApp
{
    partial class Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_list = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.lbx_items = new System.Windows.Forms.ListBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbx_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(12, 12);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(0, 17);
            this.lbl_list.TabIndex = 13;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(138, 184);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(111, 23);
            this.btn_done.TabIndex = 12;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // lbx_items
            // 
            this.lbx_items.FormattingEnabled = true;
            this.lbx_items.ItemHeight = 16;
            this.lbx_items.Location = new System.Drawing.Point(12, 38);
            this.lbx_items.Name = "lbx_items";
            this.lbx_items.Size = new System.Drawing.Size(237, 132);
            this.lbx_items.TabIndex = 11;
            this.lbx_items.SelectedIndexChanged += new System.EventHandler(this.lbx_items_SelectedIndexChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 213);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(111, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(138, 213);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 184);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbx_show
            // 
            this.cbx_show.AutoSize = true;
            this.cbx_show.Location = new System.Drawing.Point(147, 11);
            this.cbx_show.Name = "cbx_show";
            this.cbx_show.Size = new System.Drawing.Size(102, 21);
            this.cbx_show.TabIndex = 14;
            this.cbx_show.Text = "Show Done";
            this.cbx_show.UseVisualStyleBackColor = true;
            this.cbx_show.CheckedChanged += new System.EventHandler(this.cbx_show_CheckedChanged);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 248);
            this.Controls.Add(this.cbx_show);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.lbx_items);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Items";
            this.Text = "items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.ListBox lbx_items;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckBox cbx_show;
    }
}