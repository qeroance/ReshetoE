using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;



namespace ReshetoE
{
    public partial class Algorithm : Form
    {
        public Algorithm()
        {
            InitializeComponent();
            input_number.Controls[0].Visible = false;
        }

        private void Algorithm_Load(object sender, EventArgs e)
        {

        }

        private void input_number_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Decision_button_Click(object sender, EventArgs e)
        {
            var ALG = new TheSieveOfEratosthenes();
            int Numbers = (int)input_number.Value;
            ALG.LimitNumbers(Numbers);
            var NumbersList = ALG.ResultGrid(); //Решето
            int LastNumber = NumbersList[NumbersList.Count - 1];
            int ColumnsCount = 14; // Столбцы
            int RowsCount = (int)(LastNumber / ColumnsCount) + 1; //Количество строк
            FillGridView(RowsCount, ColumnsCount, LastNumber, NumbersList); //Данные для сетки (начинка)
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillGridView(int rowsCount, int columnsCount, int lastNumber, List<int> numbers)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowCount = rowsCount;
            dataGridView.ColumnCount = columnsCount;
            // выставляем ширину ячеек
            for (int i = 0; i < columnsCount; i++)
            {
                dataGridView.Columns[i].Width = 44;
            }
            // Убирает сортировку столбцов
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //заполнение ячеек
            int k = 0;
            int count = 1; //значения ячеек
            bool flag = false; //показатель, что нужные ячейки заполнены
            for (int i = 0; i < rowsCount && !flag; i++)
            {
                for (int j = 0; j < columnsCount && !flag; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = count; //заполнение ячеек цифрами
                    if (count == numbers[k])
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                        k++;
                    }

                    else
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    dataGridView.Rows[i].Cells[j].ReadOnly = true; //Убирает ввод со стороны пользователя
                    if (count == lastNumber)
                    {
                        flag = true;
                    }
                    else count++;
                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            int chislo = (int)input_number.Value;
            int i = 0;
            int j = 0;
            if (chislo > 39)
            {
                i = 400;
                j = 350;
            }
            else
            {
                if (chislo > 29)
                {
                    i = 400;
                    j = 250;
                }
                else
                {
                    if (chislo > 19)
                    {
                        i = 370;
                        j = 180;
                    }
                    else
                    {
                        i = 320;
                        j = 120;
                    }
                }
            }
            Bitmap image = new Bitmap(i, j);
            GroupBox groupBox = groupBox1;
            groupBox.DrawToBitmap(image, groupBox.ClientRectangle);//отрисовываем таблицу
            SaveFileDialog saveDialog = new SaveFileDialog(); //заносим параметры в
            saveDialog.Title = "Сохранить картинку как...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "Image Files(*.PNG)|*.PNG";
            saveDialog.ShowHelp = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveDialog.FileName; //запись пути
                    image.Save(path, ImageFormat.Png); //сохранение рисунка в заданном формате по пути
                }
                catch
                {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
