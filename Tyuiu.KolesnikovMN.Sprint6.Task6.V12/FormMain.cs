using Tyuiu.KolesnikovMN.Sprint6.Task6.V12.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_KMN_Click(object sender, EventArgs e)
        {
            openFileDialog_KMN.ShowDialog();
            openFilePath = openFileDialog_KMN.FileName;
            textBoxInPut_KMN.Text = File.ReadAllText(openFilePath);
            buttonDone_KMN.Enabled = true;
        }

        private void buttonDone_KMN_Click(object sender, EventArgs e)
        {
            textBoxOutPut_KMN.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы РППб-24-1 Колесников Матвей Николаевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
