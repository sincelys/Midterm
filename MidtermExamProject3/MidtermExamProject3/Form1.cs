using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidtermExamProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ColorDisplay();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ColorDisplay();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            ColorDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ColorDisplay()
        {
            int red = trackBar.Value;
            int green = hScrollBar.Value;
            int blue = vScrollBar.Value;

            Color color = Color.FromArgb(red, green, blue);
            label.BackColor = color;
            label.Text = $"RGB: ({red}, {green}, {blue})";
        }

    }
}