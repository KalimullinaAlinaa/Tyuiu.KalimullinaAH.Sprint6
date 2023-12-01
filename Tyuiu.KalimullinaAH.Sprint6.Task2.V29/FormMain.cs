using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task2.V29.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonInfo_KAH_Click(object sender, EventArgs e)
        {
            
            
                MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);
            
        }

        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartFunction_KAH.Series[0].Points.Clear();
                this.dataGridViewFunction_KAH.Rows.Clear();

                int startValue = Convert.ToInt32(textBoxStartStep_KAH.Text);
                int stopValue = Convert.ToInt32(textBoxEndStep_KAH.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction_KAH.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_KAH.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_KAH_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KAH.BackColor = Color.Red;
        }

        private void buttonDone_KAH_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KAH.BackColor = Color.Green;
        }

        private void buttonDone_KAH_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KAH.BackColor = Color.Blue;
        }
    }
}
