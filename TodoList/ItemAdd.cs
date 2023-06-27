using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.None;
            panel.Name = "panelx";
            panel.BackColor = Color.Blue;
            panel.Location = new System.Drawing.Point(10, 130);
            panel.Size = new System.Drawing.Size(780, 50);
            panel.TabIndex = 0;
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "radioBttn1";
            checkBox.Location = new Point(10, 10);
            checkBox.Text = textBox1.Text;
            checkBox.Enabled = true;
            checkBox.Checked = false;
            checkBox.Size = new Size(100, 30);
            panel.Controls.Add(checkBox);
            ToDo toDo = new ToDo();
            toDo.Controls.Add(panel);
            toDo.ShowDialog();
        }
    }
}
