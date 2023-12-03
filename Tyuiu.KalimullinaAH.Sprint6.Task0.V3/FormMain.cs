using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task0.V3.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KAH.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KAH.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

            private void buttonHelp_KAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-23-1 Калимуллина Алина Халимовна", "Сообщение", MessageBoxButtons.OK);
        }



















        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBoxResult_KAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_KAH_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
