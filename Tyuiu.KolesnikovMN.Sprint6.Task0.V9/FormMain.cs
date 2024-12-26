using Tyuiu.KolesnikovMN.Sprint6.Task0.V9.Lib;

namespace Tyuiu.KolesnikovMN.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonResult_KMN_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KMN.Text = ds.Calculate(Convert.ToInt32(textBoxVarX_KMN.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_KMN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 ���������� ������ ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
