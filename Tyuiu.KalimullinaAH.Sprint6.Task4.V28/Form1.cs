using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KalimullinaAH.Sprint6.Task4.V28.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task4.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_KAH.Text);
                int stopValue = Convert.ToInt32(textBoxEndStep_KAH.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] arrResult = new double[len];

                arrResult = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_KAH.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KAH.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KAH.Text = "";
                chartResult_KAH.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartResult_KAH.Series[0].Points.AddXY(startValue, arrResult[i]);
                    textBoxResult_KAH.AppendText(arrResult[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);

        }

        private void chartResult_KAH_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V28.txt";
                File.WriteAllText(path, textBoxResult_KAH.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxEndStep_KAH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

