using Tyuiu.KolesnikovMN.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new();

        string path = @"C:\DataSprint6\InPutDataFileTask5V4.txt";
        private void buttonDone_KMN_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KMN.ColumnCount = 2;
            dataGridViewResult_KMN.Columns[0].Width = 30;
            dataGridViewResult_KMN.Columns[1].Width = 70;

            this.chartResult_KMN.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_KMN.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartResult_KMN.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_KMN.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartResult_KMN.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonOpen_KMN_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб-24-1 Колесников Матвей Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
