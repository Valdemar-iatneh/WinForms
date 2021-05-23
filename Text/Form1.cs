using System;
using System.Drawing;
using System.Windows.Forms;

namespace Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            switch (comboBox1.Text)
            {
                case "Line":
                    MessageBox.Show("Line");
                    break;
                case "Circle":
                    MessageBox.Show("Circle");
                    break;
                case "Recragle":
                    MessageBox.Show("Recragle");
                    break;
                case "Square":
                    MessageBox.Show("Square");
                    break;
                case "Triagle":
                    MessageBox.Show("Triaglee");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //var fig = FigureFab.Make(lbFigures.SelectedItem as FiguresData);
           //if (fig != null)
           //    figures.Add(fig);
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.BackColor = colorDialog1.Color;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
