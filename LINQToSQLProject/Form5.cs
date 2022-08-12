using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToSQLProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();

            //List<sp_getAllEmployeesResult> list = db.sp_getAllEmployees(null).OrderBy(c => c.Eno).ToList();
            //SortableBindingList<sp_getAllEmployeesResult> sbl = new SortableBindingList<sp_getAllEmployeesResult>(list);
            //dataGridView1.DataSource = sbl;

            ISingleResult<sp_getAllEmployeesResult> list = db.sp_getAllEmployees("D001");
            dataGridView1.DataSource = list;
        }



        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            //DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            //ListSortDirection direction;

            //// If oldColumn is null, then the DataGridView is not sorted.
            //if (oldColumn != null)
            //{
            //    // Sort the same column again, reversing the SortOrder.
            //    if (oldColumn == newColumn &&
            //        dataGridView1.SortOrder == SortOrder.Ascending)
            //    {
            //        direction = ListSortDirection.Descending;
            //    }
            //    else
            //    {
            //        // Sort a new column and remove the old SortGlyph.
            //        direction = ListSortDirection.Ascending;
            //        oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
            //    }
            //}
            //else
            //{
            //    direction = ListSortDirection.Ascending;
            //}

            //// Sort the selected column.
            //dataGridView1.Sort(newColumn, direction);
            //newColumn.HeaderCell.SortGlyphDirection =
            //    direction == ListSortDirection.Ascending ?
            //    SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //// Put each of the columns into programmatic sort mode.
            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.Programmatic;
            //}
        }
    }
}
