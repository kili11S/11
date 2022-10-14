
namespace Chart
{
    partial class FormOfChart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfChart));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btResult = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.cbSin = new System.Windows.Forms.CheckBox();
            this.cbCos = new System.Windows.Forms.CheckBox();
            this.cbSinCos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BorderSkin.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(28, 12);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "y1 = Sin(x)";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "y2 = Cos(x)";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.LegendText = "y3 = Sin(x) + Sin(x)";
            series3.Name = "Series3";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(801, 342);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btResult
            // 
            this.btResult.BackColor = System.Drawing.Color.DimGray;
            this.btResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btResult.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResult.Location = new System.Drawing.Point(28, 377);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(801, 44);
            this.btResult.TabIndex = 1;
            this.btResult.Text = "Результат";
            this.btResult.UseVisualStyleBackColor = false;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.DimGray;
            this.tbA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbA.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.ForeColor = System.Drawing.Color.White;
            this.tbA.Location = new System.Drawing.Point(849, 22);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(55, 27);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.DimGray;
            this.tbB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbB.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.ForeColor = System.Drawing.Color.White;
            this.tbB.Location = new System.Drawing.Point(927, 22);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(55, 27);
            this.tbB.TabIndex = 3;
            // 
            // tbH
            // 
            this.tbH.BackColor = System.Drawing.Color.DimGray;
            this.tbH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbH.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbH.ForeColor = System.Drawing.Color.White;
            this.tbH.Location = new System.Drawing.Point(1004, 22);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(55, 27);
            this.tbH.TabIndex = 4;
            // 
            // cbSin
            // 
            this.cbSin.AutoSize = true;
            this.cbSin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSin.Location = new System.Drawing.Point(849, 65);
            this.cbSin.Name = "cbSin";
            this.cbSin.Size = new System.Drawing.Size(107, 23);
            this.cbSin.TabIndex = 5;
            this.cbSin.Text = "y1 = sin(x)";
            this.cbSin.UseVisualStyleBackColor = true;
            // 
            // cbCos
            // 
            this.cbCos.AutoSize = true;
            this.cbCos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCos.Location = new System.Drawing.Point(849, 94);
            this.cbCos.Name = "cbCos";
            this.cbCos.Size = new System.Drawing.Size(111, 23);
            this.cbCos.TabIndex = 6;
            this.cbCos.Text = "y2 = cos(x)";
            this.cbCos.UseVisualStyleBackColor = true;
            // 
            // cbSinCos
            // 
            this.cbSinCos.AutoSize = true;
            this.cbSinCos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSinCos.Location = new System.Drawing.Point(849, 123);
            this.cbSinCos.Name = "cbSinCos";
            this.cbSinCos.Size = new System.Drawing.Size(172, 23);
            this.cbSinCos.TabIndex = 7;
            this.cbSinCos.Text = "y3 = sin(x) + cos(x)";
            this.cbSinCos.UseVisualStyleBackColor = true;
            // 
            // FormOfChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.cbSinCos);
            this.Controls.Add(this.cbCos);
            this.Controls.Add(this.cbSin);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOfChart";
            this.Text = "График функции";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.CheckBox cbSin;
        private System.Windows.Forms.CheckBox cbCos;
        private System.Windows.Forms.CheckBox cbSinCos;
    }
}

