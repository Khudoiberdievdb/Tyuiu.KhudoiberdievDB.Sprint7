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
using Tyuiu.KhudoiberdievDB.Sprint7.Project.V5.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        string openFilePath;
        private string[,] gridData;
        public static string path = @"C:\Project\InPutDataFileTask7V11.csv";


        private void buttonAddFile_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_HDB.ShowDialog();
                openFilePath = openFileDialogTask_HDB.FileName;

                gridData = ds.LoadFromDataFile(openFilePath);

                rows = gridData.GetLength(0);
                columns = gridData.GetLength(1);

                dataGridView_HDB.RowCount = rows + 1;
                dataGridView_HDB.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_HDB.Rows[i].Cells[j].Value = gridData[i, j];
                    }
                }
                dataGridView_HDB.AutoResizeColumns();
                dataGridView_HDB.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonSaveFile_HDB_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_HDB.FileName = ".csv";
            saveFileDialogTask_HDB.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_HDB.ShowDialog();
            string path = saveFileDialogTask_HDB.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridView_HDB.RowCount;
            int col = dataGridView_HDB.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridView_HDB.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridView_HDB.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonAddProduct_HDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCodeProduct_HDB.Text) ||
            string.IsNullOrWhiteSpace(textBoxNameOfPro_HDB.Text) ||
            string.IsNullOrWhiteSpace(textBoxCountPro_HDB.Text) ||
            string.IsNullOrWhiteSpace(textBoxPrice_HDB.Text) ||
            string.IsNullOrWhiteSpace(textBoxInfoPro_HDB.Text))

            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string[,] DataTable = ds.GetMatrix(path);
                if (!ColumnsExist(dataGridView_HDB))
                {
                    dataGridView_HDB.Columns.Add("Column0", "Код товара");
                    dataGridView_HDB.Columns.Add("Column1", "Название товара");
                    dataGridView_HDB.Columns.Add("Column2", "Количество");
                    dataGridView_HDB.Columns.Add("Column3", "Стоимость кг\\ед.");
                    dataGridView_HDB.Columns.Add("Column4", "Примечания");

                }
                int lastRowIndex = dataGridView_HDB.Rows.Add();
                if (lastRowIndex >= 0)
                {
                    dataGridView_HDB.Rows[lastRowIndex].Cells[0].Value = Convert.ToInt32(lastRowIndex + 1);
                    dataGridView_HDB.Rows[lastRowIndex].Cells[1].Value = textBoxCodeProduct_HDB.Text;
                    dataGridView_HDB.Rows[lastRowIndex].Cells[2].Value = textBoxNameOfPro_HDB.Text;
                    dataGridView_HDB.Rows[lastRowIndex].Cells[3].Value = textBoxCountPro_HDB.Text;
                    dataGridView_HDB.Rows[lastRowIndex].Cells[4].Value = textBoxPrice_HDB.Text;
                    dataGridView_HDB.Rows[lastRowIndex].Cells[5].Value = textBoxInfoPro_HDB.Text;

                }
                textBoxInfoPro_HDB.Text = "";
                textBoxPrice_HDB.Text = "";
                textBoxNameOfPro_HDB.Text = "";
                textBoxCountPro_HDB.Text = "";
                textBoxCodeProduct_HDB.Text = "";

                MessageBox.Show("Товар занесен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ColumnsExist(DataGridView dataGridView)
        {
            return dataGridView.Columns.Count > 0;
        }

        private void buttonSum_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double[] values = new double[rows];

                for (int i = 0; i < rows; i++)
                {
                    if (dataGridView_HDB.Rows[i].Visible)
                    {
                        double cellValue;
                        if (double.TryParse(gridData[i, 3], out cellValue))
                        {
                            values[visibleRowCount] = cellValue;
                            visibleRowCount++;
                        }
                    }
                }

                if (visibleRowCount > 0)
                {
                    double res = ds.CalculateSum(values);
                    textBoxSum_HDB.Text = Math.Round(res, 2).ToString();
                }
                else
                {
                    textBoxSum_HDB.Text = "Нет данных для подсчета";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvCost_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double sumVisibleValues = 0;
                double[] valuesAv = new double[rows];

                for (int i = 0; i < rows; i++)
                {
                    if (dataGridView_HDB.Rows[i].Visible)
                    {
                        double valuesAverage;
                        if (double.TryParse(gridData[i, 4], out valuesAverage))
                        {
                            valuesAv[visibleRowCount] = valuesAverage;
                            sumVisibleValues += valuesAverage;
                            visibleRowCount++;
                        }
                    }
                }

                if (visibleRowCount > 0)
                {
                    double average = ds.CalculateAverage(valuesAv, visibleRowCount);
                    textBoxAvCost_HDB.Text = Math.Round(average, 2).ToString();
                }
                else
                {
                    textBoxAvCost_HDB.Text = "Нет данных для подсчета";
                }

            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMinCost_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 4;
                bool foundValue = false;
                double minValue = double.MaxValue;

                for (int i = 0; i < rows; i++)
                {
                    if (dataGridView_HDB.Rows[i].Visible)
                    {
                        if (!string.IsNullOrWhiteSpace(gridData[i, columnIndex]))
                        {
                            double currentValue;
                            if (double.TryParse(gridData[i, columnIndex], out currentValue))
                            {
                                foundValue = true;
                                if (currentValue < minValue)
                                {
                                    minValue = currentValue;
                                }
                            }
                        }
                    }
                }

                if (foundValue)
                {
                    textBoxMinCost_HDB.Text = minValue.ToString();
                }
                else
                {
                    textBoxMinCost_HDB.Text = "Нет данных для нахождения минимума";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMaxCost_HDB_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values = new double[gridData.GetLength(0)];

                for (int i = 0; i < gridData.GetLength(0); i++)
                {
                    if (dataGridView_HDB.Rows[i].Visible)
                    {
                        double valuesMax;
                        if (double.TryParse(gridData[i, 4], out valuesMax))
                        {
                            values[i] = valuesMax;
                        }
                    }
                }
                double max = ds.FindMaximumValue(values);
                textBoxMaxCost_HDB.Text = max.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGraph_HDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChart chart = new FormChart();
            chart.Show();
        }
    }
}
