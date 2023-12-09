using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string path = @"C:\DataSprint6\InPutFileTask5V14.txt";
        DataService ds = new DataService();
        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KAH.ColumnCount = 2;
            dataGridViewResult_KAH.Columns[0].Width = 20;
            dataGridViewResult_KAH.Columns[1].Width = 50;

            this.chartGraph_KAH.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph_KAH.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraph_KAH.Series[0].Points.Clear();
            dataGridViewResult_KAH.Rows.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KAH.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartGraph_KAH.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
    
