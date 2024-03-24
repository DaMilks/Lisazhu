using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisazhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumPoints = 200;
            double delta = 2 * Math.PI / NumPoints;
            double phaseX = 0.0, phaseY = 0.0;
            double freqX = Convert.ToDouble(textBox1.Text), freqY = Convert.ToDouble(textBox2.Text);
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < NumPoints; i++)
            {
                double x = Math.Sin(freqX * phaseX);
                double y =Math.Sin(freqY * phaseY);
                phaseX += delta;
                phaseY += delta;

                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
