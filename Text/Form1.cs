﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //string selectedState = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedState);
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
    }
}
