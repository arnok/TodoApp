namespace TodoApp
{
    partial class ItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.cbx_done = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(64, 67);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(64, 12);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(135, 22);
            this.tbx_name.TabIndex = 2;
            // 
            // cbx_done
            // 
            this.cbx_done.AutoSize = true;
            this.cbx_done.Location = new System.Drawing.Point(64, 40);
            this.cbx_done.Name = "cbx_done";
            this.cbx_done.Size = new System.Drawing.Size(64, 21);
            this.cbx_done.TabIndex = 3;
            this.cbx_done.Text = "Done";
            this.cbx_done.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 99);
            this.Controls.Add(this.cbx_done);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemForm";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.CheckBox cbx_done;
    }
}