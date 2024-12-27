using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KhudoiberdievDB.Sprint7.Project.V5.Lib;

namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        private string[,] gridChartData;
        DataService ds = new DataService();






        private void buttonBackToMM_HDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void buttonAddFileChart_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTaskChart_HDB.ShowDialog();
                openFilePath = openFileDialogTaskChart_HDB.FileName;

                gridChartData = ds.LoadFromDataFile(openFilePath);

                rows = gridChartData.GetLength(0);
                columns = gridChartData.GetLength(1);

                dataGridViewChart_HDB.RowCount = rows + 1;
                dataGridViewChart_HDB.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewChart_HDB.Rows[i].Cells[j].Value = gridChartData[i, j];
                    }
                }
                dataGridViewChart_HDB.AutoResizeColumns();
                dataGridViewChart_HDB.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFileChart_HDB_Click(object sender, EventArgs e)
        {
            saveFileDialogTaskChart_HDB.FileName = ".csv";
            saveFileDialogTaskChart_HDB.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTaskChart_HDB.ShowDialog();
            string path = saveFileDialogTaskChart_HDB.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewChart_HDB.RowCount;
            int col = dataGridViewChart_HDB.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewChart_HDB.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewChart_HDB.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonGraphChart_HDB_Click(object sender, EventArgs e)
        {
            chart_HDB.Series[0].Points.AddXY(352,27);
            chart_HDB.Series[0].Points.AddXY(773,99);
            chart_HDB.Series[0].Points.AddXY(902,53);
            chart_HDB.Series[0].Points.AddXY(102,76);
            chart_HDB.Series[0].Points.AddXY(211,56);

        }
    }
}
