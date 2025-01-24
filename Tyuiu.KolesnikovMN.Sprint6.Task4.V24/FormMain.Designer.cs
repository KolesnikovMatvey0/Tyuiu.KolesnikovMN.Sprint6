namespace Tyuiu.KolesnikovMN.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxTask_KMN = new TextBox();
            textBoxInPut_KMN = new TextBox();
            textBoxStartStep_KMN = new TextBox();
            textBoxStopStep_KMN = new TextBox();
            buttonDone_KMN = new Button();
            buttonSave_KMN = new Button();
            chartFunction_KMN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxOutPut_KMN = new TextBox();
            textBoxResult_KMN = new TextBox();
            buttonHelp_KMN = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMN).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_KMN
            // 
            textBoxTask_KMN.BackColor = SystemColors.Menu;
            textBoxTask_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxTask_KMN.Location = new Point(18, 9);
            textBoxTask_KMN.Multiline = true;
            textBoxTask_KMN.Name = "textBoxTask_KMN";
            textBoxTask_KMN.Size = new Size(440, 88);
            textBoxTask_KMN.TabIndex = 0;
            textBoxTask_KMN.Text = "Условие\r\n\r\nПротабулировать функцию на заданном диапозоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V24.txt по нажатию кнопки.";
            // 
            // textBoxInPut_KMN
            // 
            textBoxInPut_KMN.BackColor = SystemColors.Menu;
            textBoxInPut_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxInPut_KMN.Location = new Point(464, 9);
            textBoxInPut_KMN.Multiline = true;
            textBoxInPut_KMN.Name = "textBoxInPut_KMN";
            textBoxInPut_KMN.Size = new Size(251, 88);
            textBoxInPut_KMN.TabIndex = 1;
            textBoxInPut_KMN.Text = "Ввод данных\r\n\r\n    Старт шага:                  Конец шага:";
            // 
            // textBoxStartStep_KMN
            // 
            textBoxStartStep_KMN.Location = new Point(476, 57);
            textBoxStartStep_KMN.Name = "textBoxStartStep_KMN";
            textBoxStartStep_KMN.Size = new Size(105, 23);
            textBoxStartStep_KMN.TabIndex = 2;
            // 
            // textBoxStopStep_KMN
            // 
            textBoxStopStep_KMN.Location = new Point(594, 57);
            textBoxStopStep_KMN.Name = "textBoxStopStep_KMN";
            textBoxStopStep_KMN.Size = new Size(105, 23);
            textBoxStopStep_KMN.TabIndex = 3;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KMN.Location = new Point(721, 9);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(88, 88);
            buttonDone_KMN.TabIndex = 4;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // buttonSave_KMN
            // 
            buttonSave_KMN.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_KMN.Location = new Point(814, 9);
            buttonSave_KMN.Name = "buttonSave_KMN";
            buttonSave_KMN.Size = new Size(88, 88);
            buttonSave_KMN.TabIndex = 5;
            buttonSave_KMN.Text = "Сохранить";
            buttonSave_KMN.UseVisualStyleBackColor = false;
            buttonSave_KMN.Click += buttonSave_KMN_Click;
            // 
            // chartFunction_KMN
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_KMN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_KMN.Legends.Add(legend2);
            chartFunction_KMN.Location = new Point(271, 107);
            chartFunction_KMN.Name = "chartFunction_KMN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_KMN.Series.Add(series2);
            chartFunction_KMN.Size = new Size(725, 389);
            chartFunction_KMN.TabIndex = 6;
            chartFunction_KMN.Text = "chart1";
            // 
            // textBoxOutPut_KMN
            // 
            textBoxOutPut_KMN.BackColor = SystemColors.Menu;
            textBoxOutPut_KMN.BorderStyle = BorderStyle.None;
            textBoxOutPut_KMN.Location = new Point(18, 107);
            textBoxOutPut_KMN.Multiline = true;
            textBoxOutPut_KMN.Name = "textBoxOutPut_KMN";
            textBoxOutPut_KMN.Size = new Size(247, 22);
            textBoxOutPut_KMN.TabIndex = 7;
            textBoxOutPut_KMN.Text = "Вывод данных";
            // 
            // textBoxResult_KMN
            // 
            textBoxResult_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_KMN.Location = new Point(18, 127);
            textBoxResult_KMN.Multiline = true;
            textBoxResult_KMN.Name = "textBoxResult_KMN";
            textBoxResult_KMN.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KMN.Size = new Size(247, 369);
            textBoxResult_KMN.TabIndex = 8;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.MediumOrchid;
            buttonHelp_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KMN.Location = new Point(908, 9);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(88, 88);
            buttonHelp_KMN.TabIndex = 9;
            buttonHelp_KMN.Text = "Справка";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 508);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(textBoxResult_KMN);
            Controls.Add(textBoxOutPut_KMN);
            Controls.Add(chartFunction_KMN);
            Controls.Add(buttonSave_KMN);
            Controls.Add(buttonDone_KMN);
            Controls.Add(textBoxStopStep_KMN);
            Controls.Add(textBoxStartStep_KMN);
            Controls.Add(textBoxInPut_KMN);
            Controls.Add(textBoxTask_KMN);
            MinimumSize = new Size(1032, 547);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunction_KMN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_KMN;
        private TextBox textBoxInPut_KMN;
        private TextBox textBoxStartStep_KMN;
        private TextBox textBoxStopStep_KMN;
        private Button buttonDone_KMN;
        private Button buttonSave_KMN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KMN;
        private TextBox textBoxOutPut_KMN;
        private TextBox textBoxResult_KMN;
        private Button buttonHelp_KMN;
    }
}
