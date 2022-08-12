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
    public partial class Form2 : Form
    {
        CompanyDBDataContext db;
        List<Employee> emps;
        int rno = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new CompanyDBDataContext();
            emps = db.Employees.ToList();
        }

        private void ShowData()
        {
            textBox1.Text = emps[rno].Eno.ToString();
            textBox2.Text = emps[rno].Ename.ToString();
            textBox3.Text = emps[rno].Job.ToString();
            textBox4.Text = emps[rno].Salary.ToString();
            textBox5.Text = emps[rno].Dname.ToString();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            rno -= 1;
            if (rno <= 0) rno = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rno += 1;
            if (rno > emps.Count -1) rno = emps.Count - 1;
            ShowData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
