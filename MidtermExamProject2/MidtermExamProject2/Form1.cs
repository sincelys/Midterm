using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MidtermExamProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Warning");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string task = textBox.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                listBox.Items.Add(task);
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Warning");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
}