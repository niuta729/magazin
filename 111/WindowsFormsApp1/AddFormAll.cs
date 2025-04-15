using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddFormAll : Form
    {
        public AddFormAll()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;

            if (main != null)
            {
                DataRow nRow = main.databaseDataSet1.Tables[2].NewRow();
                int rc = main.dataGridView8.RowCount;
                nRow[0] = rc;
                nRow[1] = FioTB.Text;
                nRow[2] = AddressTB.Text;
                nRow[3] = PnTB.Text;
                nRow[4] = CostTB.Text;
                nRow[5] = ProfileTB.Text;
                main.databaseDataSet1.Tables[2].Rows.Add(nRow);
                main.shopsTableAdapter.Update(main.databaseDataSet1.Shops);
                main.databaseDataSet1.Tables[2].AcceptChanges();
                main.dataGridView8.Refresh();
                FioTB.Text = "";
                AddressTB.Text = "";
                PnTB.Text = "";
                CostTB.Text = "";
                ProfileTB.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
