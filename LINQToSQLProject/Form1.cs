using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            //dataGridView1.DataSource = db.Employees;
            Table<Employee> table = db.Employees;
            dataGridView1.DataSource = table;
        }
    }
}
