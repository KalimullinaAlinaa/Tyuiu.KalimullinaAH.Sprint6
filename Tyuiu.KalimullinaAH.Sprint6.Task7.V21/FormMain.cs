using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint6.Task7.V21.Lib;
namespace Tyuiu.KalimullinaAH.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            //разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            //выделите массив данных
            int[,] arrayValues = new int[rows, columns];

            //заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_KAH_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAH.ShowDialog();
            openFilePath = openFileDialogTask_KAH.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KAH.ColumnCount = columns;
            dataGridViewIn_KAH.RowCount = rows;
            dataGridViewOut_KAH.ColumnCount = columns;
            dataGridViewOut_KAH.RowCount = rows;

            //задаем ширину столбцов dataGridViewMatrix
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KAH.Columns[i].Width = 25;
                dataGridViewOut_KAH.Columns[i].Width = 25;
            }

            //Добавляем данные dataGridViewMatrix
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KAH.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KAH.Enabled = true;
        }

        private void buttonHelp_KAH_Click(object sender, EventArgs e)
        {
            FormAboutt formAbout = new FormAboutt();
            formAbout.ShowDialog();
        }

        private void buttonDone_KAH_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KAH.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KAH.Enabled = true;

        }

        private void buttonSave_KAH_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAH.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KAH.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAH.ShowDialog();

            string path = saveFileDialogMatrix_KAH.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KAH.RowCount;
            int columns = dataGridViewOut_KAH.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KAH.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KAH.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }


        }

        private void buttonOpenFile_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KAH.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KAH.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KAH.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_KAH.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KAH.ColumnCount = 50;
            dataGridViewOut_KAH.ColumnCount = 50;

            dataGridViewIn_KAH.RowCount = 50;
            dataGridViewOut_KAH.RowCount = 50;

            panelInPut_KAH.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KAH.Columns[i].Width = 25;
                dataGridViewOut_KAH.Columns[i].Width = 25;
            }
        }
    }
}
