namespace LINQToSQLProject
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrderBySalAsc = new System.Windows.Forms.Button();
            this.btnOrderByEnameDesc = new System.Windows.Forms.Button();
            this.btnGetSelectedColumn = new System.Windows.Forms.Button();
            this.btnEmpCountGroupByDeptno = new System.Windows.Forms.Button();
            this.btnEmpCountGroupByJob = new System.Windows.Forms.Button();
            this.btnMultipleClausesInAQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 79);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(258, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnMultipleClausesInAQuery);
            this.panel2.Controls.Add(this.btnEmpCountGroupByJob);
            this.panel2.Controls.Add(this.btnEmpCountGroupByDeptno);
            this.panel2.Controls.Add(this.btnGetSelectedColumn);
            this.panel2.Controls.Add(this.btnOrderByEnameDesc);
            this.panel2.Controls.Add(this.btnOrderBySalAsc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(829, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 550);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(829, 550);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnOrderBySalAsc
            // 
            this.btnOrderBySalAsc.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderBySalAsc.Location = new System.Drawing.Point(24, 21);
            this.btnOrderBySalAsc.Name = "btnOrderBySalAsc";
            this.btnOrderBySalAsc.Size = new System.Drawing.Size(305, 35);
            this.btnOrderBySalAsc.TabIndex = 0;
            this.btnOrderBySalAsc.Text = "Order by Sal Asc";
            this.btnOrderBySalAsc.UseVisualStyleBackColor = true;
            this.btnOrderBySalAsc.Click += new System.EventHandler(this.btnOrderBySalAsc_Click);
            // 
            // btnOrderByEnameDesc
            // 
            this.btnOrderByEnameDesc.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderByEnameDesc.Location = new System.Drawing.Point(24, 75);
            this.btnOrderByEnameDesc.Name = "btnOrderByEnameDesc";
            this.btnOrderByEnameDesc.Size = new System.Drawing.Size(305, 35);
            this.btnOrderByEnameDesc.TabIndex = 1;
            this.btnOrderByEnameDesc.Text = "Order by Ename Desc";
            this.btnOrderByEnameDesc.UseVisualStyleBackColor = true;
            this.btnOrderByEnameDesc.Click += new System.EventHandler(this.btnOrderByEnameDesc_Click);
            // 
            // btnGetSelectedColumn
            // 
            this.btnGetSelectedColumn.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetSelectedColumn.Location = new System.Drawing.Point(24, 127);
            this.btnGetSelectedColumn.Name = "btnGetSelectedColumn";
            this.btnGetSelectedColumn.Size = new System.Drawing.Size(305, 35);
            this.btnGetSelectedColumn.TabIndex = 2;
            this.btnGetSelectedColumn.Text = "Get Selected Column";
            this.btnGetSelectedColumn.UseVisualStyleBackColor = true;
            this.btnGetSelectedColumn.Click += new System.EventHandler(this.btnGetSelectedColumn_Click);
            // 
            // btnEmpCountGroupByDeptno
            // 
            this.btnEmpCountGroupByDeptno.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmpCountGroupByDeptno.Location = new System.Drawing.Point(24, 185);
            this.btnEmpCountGroupByDeptno.Name = "btnEmpCountGroupByDeptno";
            this.btnEmpCountGroupByDeptno.Size = new System.Drawing.Size(305, 35);
            this.btnEmpCountGroupByDeptno.TabIndex = 3;
            this.btnEmpCountGroupByDeptno.Text = "Emp Count GroupBy Deptno";
            this.btnEmpCountGroupByDeptno.UseVisualStyleBackColor = true;
            this.btnEmpCountGroupByDeptno.Click += new System.EventHandler(this.btnEmpCountGroupByDeptno_Click);
            // 
            // btnEmpCountGroupByJob
            // 
            this.btnEmpCountGroupByJob.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmpCountGroupByJob.Location = new System.Drawing.Point(24, 246);
            this.btnEmpCountGroupByJob.Name = "btnEmpCountGroupByJob";
            this.btnEmpCountGroupByJob.Size = new System.Drawing.Size(305, 35);
            this.btnEmpCountGroupByJob.TabIndex = 4;
            this.btnEmpCountGroupByJob.Text = "Emp Count GroupBy Job";
            this.btnEmpCountGroupByJob.UseVisualStyleBackColor = true;
            this.btnEmpCountGroupByJob.Click += new System.EventHandler(this.btnEmpCountGroupByJob_Click);
            // 
            // btnMultipleClausesInAQuery
            // 
            this.btnMultipleClausesInAQuery.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultipleClausesInAQuery.Location = new System.Drawing.Point(24, 302);
            this.btnMultipleClausesInAQuery.Name = "btnMultipleClausesInAQuery";
            this.btnMultipleClausesInAQuery.Size = new System.Drawing.Size(305, 35);
            this.btnMultipleClausesInAQuery.TabIndex = 5;
            this.btnMultipleClausesInAQuery.Text = "Multiple Clauses In A Query";
            this.btnMultipleClausesInAQuery.UseVisualStyleBackColor = true;
            this.btnMultipleClausesInAQuery.Click += new System.EventHandler(this.btnMultipleClausesInAQuery_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(24, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Max Sal group by deptno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(24, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Max Sal group by Job";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderBySalAsc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOrderByEnameDesc;
        private System.Windows.Forms.Button btnGetSelectedColumn;
        private System.Windows.Forms.Button btnEmpCountGroupByDeptno;
        private System.Windows.Forms.Button btnEmpCountGroupByJob;
        private System.Windows.Forms.Button btnMultipleClausesInAQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}