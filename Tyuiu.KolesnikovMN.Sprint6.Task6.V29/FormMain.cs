using Tyuiu.KolesnikovMN.Sprint6.Task6.V29.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new();
        int[,] matrix = { { -2, -13, -15, -9, -17 },

                            { 13, -20, -15,  27, 18 },

                            { -12, -1, -20, 13, 0 },

                            { 15, 32, 18, -12, -18 },

                            { 16, 5, 3, -5, - 8 } };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonDone_KMN_Click(object sender, EventArgs e)
        {
            int[,] matrx = ds.Calculate(matrix);
            int rows = matrx.GetLength(0);
            int columns = matrx.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix_KMN.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KMN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб-24-1 Колесников Матвей Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrix_KMN.RowCount = rows;
            dataGridViewMatrix_KMN.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix_KMN.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KMN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
