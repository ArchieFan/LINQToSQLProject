using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LINQToSQLProject
{
    public partial class Form3 : Form
    {
        CompanyDBDataContext db;
        public Form3()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            db = new CompanyDBDataContext();
            Table<Employee> table = db.Employees;
            dataGridView1.DataSource = table;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form4 frm = new Form4();
                frm.textBox1.ReadOnly = true;
                frm.textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                frm.textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                frm.textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                frm.textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                frm.textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                frm.ShowDialog();
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this record?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee emp = db.Employees.SingleOrDefault(em => em.Eno == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    db.Employees.DeleteOnSubmit(emp);
                    db.SubmitChanges();
                    MessageBox.Show("Record Deleted");
                }
            }
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
            LoadData();
        }
    }
}
