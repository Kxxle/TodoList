using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoList
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            System.DateTime dateTime = new DateTime();
            dateTime = DateTime.Today;
            
            dayLbl.Text = DateTime.Today.ToString("dddd");
            dateLbl.Text = DateTime.Today.ToString("d");
            timeLbl.Text = DateTime.Today.ToString("t");
            //Initialization of the items of the TodoList
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.None;
            panel.Name = "panelx";
            panel.BackColor = Color.Blue;
            panel.Location = new System.Drawing.Point(10, 130);
            panel.Size = new System.Drawing.Size(780, 50);
            panel.TabIndex = 0;
            RadioButton radioButton = new RadioButton();
            radioButton.Name = "radioBttn1";
            radioButton.Location = new Point(10, 10);
            radioButton.Text = Values.itemname;
            radioButton.Enabled = true;
            radioButton.Checked = false;
            radioButton.Size = new Size(100, 30);
            panel.Controls.Add(radioButton);
            Controls.Add(panel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dayLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            
            
            ItemAdd itemAdd = new ItemAdd();
            itemAdd.ShowDialog();
        }
    }
}
