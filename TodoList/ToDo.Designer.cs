namespace TodoList
{
    partial class ToDo
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
            this.toDoListLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dayLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.addBttn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toDoListLbl
            // 
            this.toDoListLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toDoListLbl.AutoSize = true;
            this.toDoListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toDoListLbl.Location = new System.Drawing.Point(308, 12);
            this.toDoListLbl.Name = "toDoListLbl";
            this.toDoListLbl.Size = new System.Drawing.Size(108, 25);
            this.toDoListLbl.TabIndex = 0;
            this.toDoListLbl.Text = "To-do List";
            this.toDoListLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toDoListLbl);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 48);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addBttn);
            this.panel2.Controls.Add(this.timeLbl);
            this.panel2.Controls.Add(this.dateLbl);
            this.panel2.Controls.Add(this.dayLbl);
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 56);
            this.panel2.TabIndex = 2;
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayLbl.Location = new System.Drawing.Point(23, 13);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(70, 25);
            this.dayLbl.TabIndex = 0;
            this.dayLbl.Text = "label2";
            this.dayLbl.Click += new System.EventHandler(this.dayLbl_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLbl.Location = new System.Drawing.Point(193, 17);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(51, 20);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "label1";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLbl.Location = new System.Drawing.Point(309, 17);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(51, 20);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "label1";
            // 
            // addBttn
            // 
            this.addBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBttn.Location = new System.Drawing.Point(616, 9);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(92, 39);
            this.addBttn.TabIndex = 3;
            this.addBttn.Text = "Add";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ToDo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label toDoListLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
    }
}

