namespace Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = ""; // ������� �������� �����.
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"; //������ ������ ��� ����������� ����, �� ���� ��� ������ ������ ��� �� ����������� ����� ����� ������.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("�� ���������� ����. ��������, ����������, ���� � ����������� .png|.jpeg|.bmp|.gif", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}