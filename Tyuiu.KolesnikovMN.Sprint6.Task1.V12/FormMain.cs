using Tyuiu.KolesnikovMN.Sprint6.Task1.V12.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_KMN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KMN.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KMN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KMN.Text = "";
                textBoxResult_KMN.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_KMN.AppendText("|     X      |    F(x)    |" + Environment.NewLine);
                textBoxResult_KMN.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_KMN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KMN.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataService ds = new();
        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-24-1 Колесников Матвей Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStartStep_KMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopStep_KMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStartStep_KMN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
