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
    public partial class AddFormOw : Form
    {
        public AddFormOw()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount+1;
                nRow[0] = rc;
                nRow[1] = FioTB.Text;
                nRow[2] = AddressTB.Text;
                nRow[3] = PnTB.Text;
                nRow[4] = NumRegTB.Text;
                nRow[5] = dateTimePicker1.Text;
                nRow[6] = dateTimePicker2.Text;
                main.databaseDataSet1.Tables[0].Rows.Add(nRow);
                main.ownersTableAdapter1.Update(main.databaseDataSet1.Owners);
                main.databaseDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                FioTB.Text = "";
                AddressTB.Text = "";
                PnTB.Text = "";
                NumRegTB.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
