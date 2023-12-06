using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_System_ProjectDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.bank_System_ProjectDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            customersBindingSource.EndEdit();
            customersTableAdapter.Update(bank_System_ProjectDataSet.Customers);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }
    }
}
