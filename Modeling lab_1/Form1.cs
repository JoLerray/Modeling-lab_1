using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modeling_lab_1
{
    public partial class Form1 : Form
    {
        Series series;
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = System.Convert.ToDouble(this.textBox1.Text.ToString()), b = System.Convert.ToDouble(this.textBox2.Text.ToString());
            int N = System.Convert.ToInt32(this.textBox3.Text.ToString());
            Series _series = new Series();
            _series.ChartType = SeriesChartType.Point;
            this.chart1.Series.Add(_series);
            series = chart1.Series[number];
            
     
            
            for (int i = 0; i < N; i++)
            {
                var value = Distribution.Weibull(c, b);
                series.Points.AddXY(value[0],value[1]);
            }
            this.label4.Text = "M(X) = " + Distribution.getMx(c,b);
            this.label5.Text = "D(X) = " + Distribution.getDx(c, b);
            number++;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.label4.Text = "M(X) = ?";
            this.label5.Text = "D(X) = ?";
            number = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
