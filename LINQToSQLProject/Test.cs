using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static LINQToSQLProject.Test;
using System.ComponentModel;

namespace LINQToSQLProject
{
    public partial class Test : Form
    {
        private BindingList<MyObject> myList;

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            myList = new BindingList<MyObject>();
            myList.Add(new MyObject(1, "Outdoor"));
            myList.Add(new MyObject(2, "Hardware"));
            myList.Add(new MyObject(3, "Tools"));
            myList.Add(new MyObject(4, "Books"));
            myList.Add(new MyObject(5, "Appliances"));
            dataGridView1.DataSource = myList;
        }





    }
}
