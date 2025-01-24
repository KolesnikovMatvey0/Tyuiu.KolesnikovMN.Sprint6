namespace Tyuiu.KolesnikovMN.Sprint6.Task2.V21
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxTask_KMN = new TextBox();
            textBoxInPut_KMN = new TextBox();
            textBoxStartStep_KMN = new TextBox();
            textBoxStopStep_KMN = new TextBox();
            buttonHelp_KMN = new Button();
            buttonDone_KMN = new Button();
            textBox1 = new TextBox();
            dataGridViewFunction_KMN = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Function = new DataGridViewTextBoxColumn();
            chartFunction_KMN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KMN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMN).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_KMN
            // 
            textBoxTask_KMN.BackColor = SystemColors.Menu;
            textBoxTask_KMN.BorderStyle = BorderStyle.None;
            textBoxTask_KMN.Location = new Point(13, 8);
            textBoxTask_KMN.Multiline = true;
            textBoxTask_KMN.Name = "textBoxTask_KMN";
            textBoxTask_KMN.Size = new Size(389, 276);
            textBoxTask_KMN.TabIndex = 0;
            textBoxTask_KMN.Text = " Условие\r\nПротабулировать функцию на заданном диапозоне.\r\nРезультат вывести в DataGrindView и построить график функции.";
            // 
            // textBoxInPut_KMN
            // 
            textBoxInPut_KMN.BackColor = SystemColors.Menu;
            textBoxInPut_KMN.Location = new Point(13, 325);
            textBoxInPut_KMN.Multiline = true;
            textBoxInPut_KMN.Name = "textBoxInPut_KMN";
            textBoxInPut_KMN.Size = new Size(277, 113);
            textBoxInPut_KMN.TabIndex = 1;
            textBoxInPut_KMN.Text = "Вывод данных\r\n\r\n       Старт шага:                           Конец шага:";
            // 
            // textBoxStartStep_KMN
            // 
            textBoxStartStep_KMN.Location = new Point(32, 376);
            textBoxStartStep_KMN.Name = "textBoxStartStep_KMN";
            textBoxStartStep_KMN.Size = new Size(85, 23);
            textBoxStartStep_KMN.TabIndex = 2;
            textBoxStartStep_KMN.TextChanged += textBox1_TextChanged;
            textBoxStartStep_KMN.KeyPress += textBoxStartStep_KMN_KeyPress;
            // 
            // textBoxStopStep_KMN
            // 
            textBoxStopStep_KMN.Location = new Point(178, 376);
            textBoxStopStep_KMN.Name = "textBoxStopStep_KMN";
            textBoxStopStep_KMN.Size = new Size(85, 23);
            textBoxStopStep_KMN.TabIndex = 3;
            textBoxStopStep_KMN.KeyPress += textBoxStopStep_KMN_KeyPress;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.DeepSkyBlue;
            buttonHelp_KMN.Location = new Point(296, 376);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(106, 62);
            buttonHelp_KMN.TabIndex = 4;
            buttonHelp_KMN.Text = "Справка";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_KMN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KMN.Location = new Point(296, 326);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(106, 44);
            buttonDone_KMN.TabIndex = 5;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(426, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 426);
            textBox1.TabIndex = 6;
            textBox1.Text = "Вывод данных\r\n\r\n     Результат:";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // dataGridViewFunction_KMN
            // 
            dataGridViewFunction_KMN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KMN.Columns.AddRange(new DataGridViewColumn[] { X, Function });
            dataGridViewFunction_KMN.Location = new Point(443, 64);
            dataGridViewFunction_KMN.Name = "dataGridViewFunction_KMN";
            dataGridViewFunction_KMN.RowHeadersVisible = false;
            dataGridViewFunction_KMN.Size = new Size(153, 256);
            dataGridViewFunction_KMN.TabIndex = 7;
            dataGridViewFunction_KMN.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 75;
            // 
            // Function
            // 
            Function.HeaderText = "F(x)";
            Function.Name = "Function";
            Function.Width = 75;
            // 
            // chartFunction_KMN
            // 
            chartFunction_KMN.BorderlineColor = Color.Black;
            chartArea1.Name = "ChartArea1";
            chartFunction_KMN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KMN.Legends.Add(legend1);
            chartFunction_KMN.Location = new Point(614, 64);
            chartFunction_KMN.Name = "chartFunction_KMN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KMN.Series.Add(series1);
            chartFunction_KMN.Size = new Size(373, 256);
            chartFunction_KMN.TabIndex = 8;
            chartFunction_KMN.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(chartFunction_KMN);
            Controls.Add(dataGridViewFunction_KMN);
            Controls.Add(textBox1);
            Controls.Add(buttonDone_KMN);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(textBoxStopStep_KMN);
            Controls.Add(textBoxStartStep_KMN);
            Controls.Add(textBoxInPut_KMN);
            Controls.Add(textBoxTask_KMN);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KMN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_KMN;
        private TextBox textBoxInPut_KMN;
        private TextBox textBoxStartStep_KMN;
        private TextBox textBoxStopStep_KMN;
        private Button buttonHelp_KMN;
        private Button buttonDone_KMN;
        private TextBox textBox1;
        private DataGridView dataGridViewFunction_KMN;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Function;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMN;
    }
}
