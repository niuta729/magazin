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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(SearchTB.Text))
            {
                MessageBox.Show("Введите поиск");
            }
            MainForm main = this.Owner as MainForm;
            
            if (main != null)
            {
                if (main.tabControl1.SelectedIndex == 0)
                {
                    for (int i = 0; i < main.dataGridView1.RowCount; i++)
                    {
                        main.dataGridView1.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                            if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchTB.Text))
                                {
                                    main.dataGridView1.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }
                else if (main.tabControl1.SelectedIndex == 1)
                {
                    for (int i = 0; i < main.dataGridView8.RowCount; i++)
                    {
                        main.dataGridView8.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView8.ColumnCount; j++)
                            if (main.dataGridView8.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView8.Rows[i].Cells[j].Value.ToString().Contains(SearchTB.Text))
                                {
                                    main.dataGridView8.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }
                else if (main.tabControl1.SelectedIndex == 2)
                {
                    for (int i = 0; i < main.dataGridView2.RowCount; i++)
                    {
                        main.dataGridView2.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView2.ColumnCount; j++)
                            if (main.dataGridView2.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(SearchTB.Text))
                                {
                                    main.dataGridView2.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }
                else if (main.tabControl1.SelectedIndex == 3)
                {
                    for (int i = 0; i < main.dataGridView3.RowCount; i++)
                    {
                        main.dataGridView3.Rows[i].Selected = false;
                        for (int j = 0; j < main.dataGridView3.ColumnCount; j++)
                            if (main.dataGridView3.Rows[i].Cells[j].Value != null)
                                if (main.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(SearchTB.Text))
                                {
                                    main.dataGridView3.Rows[i].Selected = true;
                                    break;
                                }
                    }
                }
            }
        }
    }
}
