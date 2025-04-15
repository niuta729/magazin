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
    public partial class AddFormSu : Form
    {
        public AddFormSu()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;

            if (main != null)
            {
                DataRow nRow = main.databaseDataSet1.Tables[3].NewRow();
                int rc = main.dataGridView3.RowCount;
                nRow[0] = rc;
                nRow[1] = FioTB.Text;
                nRow[2] = AddressTB.Text;
                nRow[3] = PnTB.Text;
                nRow[4] = CostTB.Text;
                main.databaseDataSet1.Tables[3].Rows.Add(nRow);
                main.suppliersTableAdapter1.Update(main.databaseDataSet1.Suppliers);
                main.databaseDataSet1.Tables[3].AcceptChanges();
                main.dataGridView3.Refresh();
                FioTB.Text = "";
                AddressTB.Text = "";
                PnTB.Text = "";
                CostTB.Text = "";
            }
        }

        private void AddFormPol_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
