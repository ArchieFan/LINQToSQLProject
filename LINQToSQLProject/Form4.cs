using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQLProject
{
    public partial class Form4 : Form
    {
        CompanyDBDataContext db;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
            }
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == false)
            {
                db = new CompanyDBDataContext();
                Employee emp = new Employee();
                emp.Eno = int.Parse(textBox1.Text);
                emp.Ename = textBox2.Text;
                emp.Job = textBox3.Text;
                emp.Salary = decimal.Parse(textBox4.Text);
                emp.Dname = textBox5.Text;
                db.Employees.InsertOnSubmit(emp);
                db.SubmitChanges();
                MessageBox.Show("Record Added");
            } else
            {
                btnClear.Enabled = false;
                btnSave.Text = "Update";
                db = new CompanyDBDataContext();
                Employee emp = db.Employees.SingleOrDefault(em => em.Eno == int.Parse(textBox1.Text));
                emp.Ename = textBox2.Text;
                emp.Job = textBox3.Text;
                emp.Salary = decimal.Parse(textBox4.Text);
                emp.Dname = textBox5.Text;
                db.SubmitChanges();
                MessageBox.Show("Record Updated");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
