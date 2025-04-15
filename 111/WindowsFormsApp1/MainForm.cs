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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Запрос_4". При необходимости она может быть перемещена или удалена.
            this.запрос_4TableAdapter1.Fill(this.databaseDataSet1.Запрос_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Запрос_3". При необходимости она может быть перемещена или удалена.
            this.запрос_3TableAdapter1.Fill(this.databaseDataSet1.Запрос_3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Запрос_2". При необходимости она может быть перемещена или удалена.
            this.запрос_2TableAdapter1.Fill(this.databaseDataSet1.Запрос_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Запрос_1". При необходимости она может быть перемещена или удалена.
            this.запрос_1TableAdapter1.Fill(this.databaseDataSet1.Запрос_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter1.Fill(this.databaseDataSet1.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter1.Fill(this.databaseDataSet1.Shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Shops". При необходимости она может быть перемещена или удалена.
            this.shopsTableAdapter.Fill(this.databaseDataSet1.Shops);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Owners". При необходимости она может быть перемещена или удалена.
            this.ownersTableAdapter1.Fill(this.databaseDataSet1.Owners);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Запрос_4". При необходимости она может быть перемещена или удалена.
            this.запрос_4TableAdapter.Fill(this.databaseDataSet.Запрос_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Запрос_3". При необходимости она может быть перемещена или удалена.
            this.запрос_3TableAdapter.Fill(this.databaseDataSet.Запрос_3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Запрос_2". При необходимости она может быть перемещена или удалена.
            this.запрос_2TableAdapter.Fill(this.databaseDataSet.Запрос_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Запрос_1". При необходимости она может быть перемещена или удалена.
            this.запрос_1TableAdapter.Fill(this.databaseDataSet.Запрос_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.databaseDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.databaseDataSet.Shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Owners". При необходимости она может быть перемещена или удалена.
            this.ownersTableAdapter.Fill(this.databaseDataSet.Owners);           
        }
       
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ownersTableAdapter1.Update(databaseDataSet1.Owners);
            shopTableAdapter1.Update(databaseDataSet1.Shop);
            suppliersTableAdapter1.Update(databaseDataSet1.Suppliers);
            shopsTableAdapter.Update(databaseDataSet1.Shops);
            dataGridView1.Refresh();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                AddFormSh af = new AddFormSh();
                af.Owner = this;
                af.ShowDialog();
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                AddFormOw af = new AddFormOw();
                af.Owner = this;
                af.ShowDialog();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                AddFormSu af = new AddFormSu();
                af.Owner = this;
                af.ShowDialog();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                AddFormAll af = new AddFormAll();
                af.Owner = this;
                af.ShowDialog();
            }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void airPlaneBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
