using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task1.V19.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KAH.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_KAH.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;

                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_KAH.Text = "";
                textBoxResult_KAH.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult_KAH.AppendText("|    X     |    F(x)   |" + Environment.NewLine);
                textBoxResult_KAH.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++) 
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_KAH.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KAH.AppendText("+----------+-----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);
        }

        private void labelStopStep_KAH_Click(object sender, EventArgs e)
        {

        }
    }

}

