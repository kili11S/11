
namespace Bio
{
    partial class Form1
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
            this.btResult = new System.Windows.Forms.Button();
            this.btAnalitic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbMounth = new System.Windows.Forms.RadioButton();
            this.rbChoice = new System.Windows.Forms.RadioButton();
            this.dtpick2 = new System.Windows.Forms.DateTimePicker();
            this.dtpick1 = new System.Windows.Forms.DateTimePicker();
            this.dtpickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btResult
            // 
            this.btResult.BackColor = System.Drawing.Color.Black;
            this.btResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btResult.ForeColor = System.Drawing.Color.White;
            this.btResult.Location = new System.Drawing.Point(38, 306);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(655, 28);
            this.btResult.TabIndex = 0;
            this.btResult.Text = "Построить биоритмы";
            this.btResult.UseVisualStyleBackColor = false;
            this.btResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAnalitic
            // 
            this.btAnalitic.BackColor = System.Drawing.Color.Black;
            this.btAnalitic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnalitic.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnalitic.ForeColor = System.Drawing.Color.White;
            this.btAnalitic.Location = new System.Drawing.Point(38, 348);
            this.btAnalitic.Name = "btAnalitic";
            this.btAnalitic.Size = new System.Drawing.Size(655, 28);
            this.btAnalitic.TabIndex = 1;
            this.btAnalitic.Text = "Выдать анализ";
            this.btAnalitic.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(860, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип биоритма:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Эмоциональный";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Физический";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Интеллектуальный";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(6, 29);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(73, 21);
            this.rbWeek.TabIndex = 4;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Неделя";
            this.rbWeek.UseVisualStyleBackColor = true;
            // 
            // rbMounth
            // 
            this.rbMounth.AutoSize = true;
            this.rbMounth.Location = new System.Drawing.Point(6, 52);
            this.rbMounth.Name = "rbMounth";
            this.rbMounth.Size = new System.Drawing.Size(66, 21);
            this.rbMounth.TabIndex = 5;
            this.rbMounth.TabStop = true;
            this.rbMounth.Text = "Месяц";
            this.rbMounth.UseVisualStyleBackColor = true;
            // 
            // rbChoice
            // 
            this.rbChoice.AutoSize = true;
            this.rbChoice.Location = new System.Drawing.Point(6, 89);
            this.rbChoice.Name = "rbChoice";
            this.rbChoice.Size = new System.Drawing.Size(128, 21);
            this.rbChoice.TabIndex = 7;
            this.rbChoice.TabStop = true;
            this.rbChoice.Text = "Указать период:";
            this.rbChoice.UseVisualStyleBackColor = true;
            // 
            // dtpick2
            // 
            this.dtpick2.Location = new System.Drawing.Point(3, 188);
            this.dtpick2.Name = "dtpick2";
            this.dtpick2.Size = new System.Drawing.Size(146, 23);
            this.dtpick2.TabIndex = 8;
            // 
            // dtpick1
            // 
            this.dtpick1.Location = new System.Drawing.Point(3, 151);
            this.dtpick1.Name = "dtpick1";
            this.dtpick1.Size = new System.Drawing.Size(146, 23);
            this.dtpick1.TabIndex = 8;
            // 
            // dtpickerBirth
            // 
            this.dtpickerBirth.Location = new System.Drawing.Point(860, 30);
            this.dtpickerBirth.Name = "dtpickerBirth";
            this.dtpickerBirth.Size = new System.Drawing.Size(146, 20);
            this.dtpickerBirth.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(857, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата рождения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWeek);
            this.groupBox2.Controls.Add(this.rbMounth);
            this.groupBox2.Controls.Add(this.dtpick1);
            this.groupBox2.Controls.Add(this.dtpick2);
            this.groupBox2.Controls.Add(this.rbChoice);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(860, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 234);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Период";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkTurquoise;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Goldenrod;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.ForeColor = System.Drawing.SystemColors.WindowText;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Тип биоритма:";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 24);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.LegendText = "Интеллектуальный";
            series1.Name = "Series1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.LegendText = "Физический";
            series2.Name = "Series2";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Yellow;
            series3.LabelBorderWidth = 3;
            series3.Legend = "Legend1";
            series3.LegendText = "Эмоциональный";
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(766, 266);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.checkBox4.Location = new System.Drawing.Point(763, 325);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 21);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpickerBirth);
            this.Controls.Add(this.btAnalitic);
            this.Controls.Add(this.btResult);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btAnalitic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbMounth;
        private System.Windows.Forms.RadioButton rbChoice;
        private System.Windows.Forms.DateTimePicker dtpick2;
        private System.Windows.Forms.DateTimePicker dtpick1;
        private System.Windows.Forms.DateTimePicker dtpickerBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

