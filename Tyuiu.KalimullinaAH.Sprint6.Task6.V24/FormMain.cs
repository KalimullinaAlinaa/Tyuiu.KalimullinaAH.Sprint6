using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task6.V24.Lib;
using System.IO;
namespace Tyuiu.KalimullinaAH.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_KAH_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAH.ShowDialog();
            openFilePath = openFileDialogTask_KAH.FileName;
            textBoxLoadFile_KAH.Text = File.ReadAllText(openFilePath);
            groupBoxLoadFile_KAH.Text = groupBoxLoadFile_KAH.Text + " " + openFileDialogTask_KAH.FileName;
            buttonDone_KAH.Enabled = true;
        }
        private void buttonOpenFile_KAH_Click_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KAH.FlatStyle = FlatStyle.Flat;
            buttonDone_KAH.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDone_KAH.FlatAppearance.BorderSize = 2;
        }
        private void buttonHelp_KAH_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonHelp_KAH_Click_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_KAH.FlatStyle = FlatStyle.Flat;
            buttonHelp_KAH.FlatAppearance.BorderColor = Color.DarkGray;
            buttonHelp_KAH.FlatAppearance.BorderSize = 2;
        }
        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult_KAH.Text = ds.CollectTextFromFile(str,openFilePath);
        }
        private void buttonDone_KAH_Click_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_KAH.FlatStyle = FlatStyle.Flat;
            buttonDone_KAH.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDone_KAH.FlatAppearance.BorderSize = 2;
        }

        private void groupBoxResult_KAH_Enter(object sender, EventArgs e)
        {

        }
    }
}
