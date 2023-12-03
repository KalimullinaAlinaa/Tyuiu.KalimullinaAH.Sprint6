using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task3.V16.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] valueArray = {
                { 14, 1, -3, 1, 10 },
                { 7, -3, 5, -4, 0 },
                { 0, -3, 5, 0, 0 },
                { -2, -2, -16, 2, -17 },
                { -16, 9, 5, -10, 16}
            };
      

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

            private void buttonDone_Click(object sender, EventArgs e)
            {
                int[,] result = ds.Calculate(valueArray);

                int rows = result.GetUpperBound(0) + 1;
                int columns = result.Length / rows;

                dataGridViewMatrix_KAH.ColumnCount = columns;
                dataGridViewMatrix_KAH.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMatrix_KAH.Columns[i].Width = 25;
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_KAH.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                    }
                }
            }
      

        private void dataGridViewMatrix_KAH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_KAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);

        }

        private void labelResult_KAH_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KAH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

