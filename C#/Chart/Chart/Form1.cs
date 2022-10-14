using System;
using System.Windows.Forms;

namespace Chart
{
    public partial class FormOfChart : Form
    {
        public FormOfChart()
        {
            InitializeComponent();
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            try
            {
                // По умолчанию легенда всех графиков скрыта
                chart.Series[0].IsVisibleInLegend = false;
                chart.Series[1].IsVisibleInLegend = false;
                chart.Series[2].IsVisibleInLegend = false;

                // Переменные
                double a, b, h, x, y;

                // Конвертация
                a = Convert.ToDouble(tbA.Text);
                b = Convert.ToDouble(tbB.Text);
                h = Convert.ToDouble(tbH.Text);

                // Очистка графика
                this.chart.Series[0].Points.Clear();
                this.chart.Series[1].Points.Clear();
                this.chart.Series[2].Points.Clear();
                x = a;

                // y1 = Sin(x)
                if (cbSin.Checked)
                {
                    x = a;
                    this.chart.Series[0].Points.Clear();
                    while (x <= b)
                    {
                        y = Math.Sin(x);
                        this.chart.Series[0].Points.AddXY(x, y);
                        x += h;
                        chart.Series[0].IsVisibleInLegend = true;
                    }
                }

                // y2 = Cos(x)
                if (cbCos.Checked)
                {
                    x = a;
                    this.chart.Series[1].Points.Clear();
                    while (x <= b)
                    {
                        y = Math.Cos(x);
                        this.chart.Series[1].Points.AddXY(x, y);
                        x += h;
                        chart.Series[1].IsVisibleInLegend = true;
                    }
                }

                // y3 = Sin(x) + Cos(x)
                if (cbSinCos.Checked)
                {
                    x = a;
                    this.chart.Series[2].Points.Clear();
                    while (x <= b)
                    {
                        y = Math.Cos(x) + Math.Sin(x);
                        this.chart.Series[2].Points.AddXY(x, y);
                        x += h;
                        chart.Series[2].IsVisibleInLegend = true;
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Видимо, вы ввели недопустимые значения\nПроверьте введёные данные,\nвы могли вместо запятой указать точку десятичной дроби");
                this.chart.Series[0].Points.Clear();
                this.chart.Series[1].Points.Clear();
                this.chart.Series[2].Points.Clear();
            }
        }
    }
}
