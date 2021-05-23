using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DrawCore;

namespace DrawMain
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();

            shapes = new List<Shape>();
            canvas = pictureBox1.CreateGraphics();

            // Data grid view setup
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("Key", "Key");
            dataGridView1.Columns.Add("Value", "Value");
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[1].Resizable = DataGridViewTriState.False;
            //Change cell font
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.Font = comboBox1.Font;
            }

            // Figures ListBox Setup
            comboBox1.DataSource = ShapeFab.InitFiguresData();
        }

        // Заполнение строк DataGrid данными в зависимости от выбранной фигуры
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fig = comboBox1.SelectedItem as ShapeData;
            dataGridView1.Rows.Clear();
            foreach (var v in fig.Data)
            {
                dataGridView1.Rows.Add(v.Key, v.Value);
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            var fig = comboBox1.SelectedItem as ShapeData;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var key = row.Cells[0].Value.ToString();
                var val = row.Cells[1].Value.ToString();
                try
                {
                    fig.Data[key] = int.Parse(val);
                }
                catch (Exception)
                { }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           //var fig = FigureFab.Make(lbFigures.SelectedItem as FiguresData);
           //if (fig != null)
           //    figures.Add(fig);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            var fig = ShapeFab.Make(comboBox1.SelectedItem as ShapeData);

            if (fig != null)
            {
                var pen = new Pen(Color_btn.BackColor, (int)lineWidth.Value);
                fig.drawer = new WDrawer(pen, canvas);
                shapes.Add(fig);
            }

            Redraw();
        }

        // Перерисовка
        private void Redraw()
        {
            foreach (var f in shapes)
            {
                f.Draw();
            }
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Color_btn.BackColor = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {        
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                using (var sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    foreach (var fig in shapes)
                        sw.WriteLine(fig);
                   
                }
                Bitmap savedBit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(savedBit, pictureBox1.ClientRectangle);
                savedBit.Save(@"F:\123.bmp");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                using (var sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //canvas = Graphics.FromImage();
                    }
                }
            }
        }
    }
}
