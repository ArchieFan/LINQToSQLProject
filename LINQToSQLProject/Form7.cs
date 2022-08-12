using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LINQToSQLProject
{
    public partial class Form7 : Form
    {
        CompanyDBDataContext db;
        bool flag = false;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //var tab = from E in db.Employees select E;
            //var tab2 = from E in db.Employees where E.Job == "Job001" select E;
            //var tab3 = from E in db.Employees where E.Dname == "D001" select new { E.Eno, E.Ename, E.Dname };
            db = new CompanyDBDataContext();
            var tab = from E in db.Emps select E;
            dataGridView1.DataSource = tab;

            var tab2 = from E in db.Emps select new { E.Job };
            comboBox1.DataSource = tab2.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;
            flag = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                dataGridView1.DataSource = from E in db.Emps where E.Job == comboBox1.Text select E;
            }
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flag)
            {
                dataGridView1.DataSource = from E in db.Emps where E.Job.Contains(comboBox1.Text) select E;
            }
        }

        private void btnOrderBySalAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps orderby E.Salary select E;
        }

        private void btnOrderByEnameDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps orderby E.Ename descending select E;
        }

        private void btnGetSelectedColumn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps
                                       select new { EmpID = E.Eno, EmpName = E.Ename, E.Job, E.Salary , E.Deptno };
        }

        private void btnEmpCountGroupByDeptno_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps 
                                       group E by E.Deptno into G
                                       where G.Count() > 1  //Having clause
                                       select new { Deptno = G.Key, EmpCount = G.Count() };
        }

        private void btnEmpCountGroupByJob_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps
                                       group E by new { E.Job, E.Deptno } into G
                                       select new { Job = G.Key.Job, Deptno = G.Key.Deptno, EmpCount = G.Count() };

        }

        private void btnMultipleClausesInAQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps
                                       where E.Job == "jyyy"
                                       group E by E.Deptno into G
                                       orderby G.Key descending
                                       select new { Deptno = G.Key, EmpCount = G.Count() };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps
                                       group E by E.Deptno into G
                                       select new { Deptno = G.Key, MaxSal = G.Max(E => E.Salary) };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps
                                       group E by E.Job into G
                                       select new { Job = G.Key, MaxSal = G.Max(E => E.Salary) };

        }
    }
}
