using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class AddFormSh : Form
    {
        public AddFormSh()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet1.Tables[1].NewRow();
                int rc = main.dataGridView2.RowCount;
                nRow[0] = rc;
                nRow[1] = NameTB.Text;
                nRow[2] = AddressTB.Text;
                nRow[3] = PnTB.Text;
                nRow[4] = CapitalTB.Text;
                nRow[5] = ProfileTB.Text;
                nRow[6] = OwnerTB.Text;
                nRow[7] = ContTB.Text;
                nRow[8] = SupTB.Text;
                nRow[9] = CostTB.Text;
                main.databaseDataSet1.Tables[1].Rows.Add(nRow);
                main.shopTableAdapter1.Update(main.databaseDataSet1.Shop);
                main.databaseDataSet1.Tables[1].AcceptChanges();
                main.dataGridView2.Refresh();
                NameTB.Text = "";
                AddressTB.Text = "";
                PnTB.Text = "";
                CapitalTB.Text = "";
                ProfileTB.Text = "";
                OwnerTB.Text = "";
                ContTB.Text = "";
                SupTB.Text = "";
                CostTB.Text = "";
            }

        }
    }
}
