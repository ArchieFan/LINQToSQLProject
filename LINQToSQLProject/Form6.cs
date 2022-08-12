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
    public partial class Form6 : Form
    {
        CompanyDBDataContext db;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Form6_Load(object sender, EventArgs e)
        {
            db = new CompanyDBDataContext();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int? outEno = null;
            db.sp_Insert_Employee(textBox2.Text, textBox3.Text, decimal.Parse(textBox4.Text), textBox5.Text, ref outEno);
            textBox1.Text = outEno.ToString();  
        }
    }
}
