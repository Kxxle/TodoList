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
            checkBox.Font =new Font("Ariel",16);
            checkBox.Size = new Size(100, 30);
            //Initialize button
            Button button = new Button();
            button.Name = "deleteBtttn";
            button.Location = new Point(100, 130);
            button.Text = "Delete";
            button.Enabled = true;
            button.Visible = true;
            button.Font= new Font("Ariel",12);
            button.Size = new Size(50, 50);
            button.TabIndex = 0;
            button.ForeColor = Color.Red;
           
            panel.Controls.Add(checkBox);
            panel.Controls.Add(button);
            ToDo toDo = new ToDo();
            toDo.Controls.Add(panel);
            toDo.ShowDialog();
        }
    }
}
