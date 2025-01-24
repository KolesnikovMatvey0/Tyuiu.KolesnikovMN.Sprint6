using Tyuiu.KolesnikovMN.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new();

        private void buttonDone_KMN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KMN.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KMN.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KMN.Titles.Add("f(x)");
                this.chartFunction_KMN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KMN.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KMN.Text = "";

                chartFunction_KMN.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KMN.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KMN.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonSave_KMN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V24.txt";
                File.WriteAllText(path, textBoxResult_KMN.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб-24-1 Колесников Матвей Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
