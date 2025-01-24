namespace Tyuiu.KolesnikovMN.Sprint6.Task5.V4
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
            groupBoxTask_KMN = new GroupBox();
            textBoxTask_KMN = new TextBox();
            groupBoxOutPut_KMN = new GroupBox();
            dataGridViewResult_KMN = new DataGridView();
            chartResult_KMN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_KMN = new Button();
            buttonOpen_KMN = new Button();
            buttonHelp_KMN = new Button();
            groupBoxTask_KMN.SuspendLayout();
            groupBoxOutPut_KMN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_KMN).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KMN
            // 
            groupBoxTask_KMN.Controls.Add(textBoxTask_KMN);
            groupBoxTask_KMN.Location = new Point(12, 12);
            groupBoxTask_KMN.Name = "groupBoxTask_KMN";
            groupBoxTask_KMN.Size = new Size(436, 61);
            groupBoxTask_KMN.TabIndex = 0;
            groupBoxTask_KMN.TabStop = false;
            groupBoxTask_KMN.Text = "Условие";
            // 
            // textBoxTask_KMN
            // 
            textBoxTask_KMN.BackColor = SystemColors.Menu;
            textBoxTask_KMN.BorderStyle = BorderStyle.None;
            textBoxTask_KMN.Dock = DockStyle.Fill;
            textBoxTask_KMN.Location = new Point(3, 19);
            textBoxTask_KMN.Multiline = true;
            textBoxTask_KMN.Name = "textBoxTask_KMN";
            textBoxTask_KMN.Size = new Size(430, 39);
            textBoxTask_KMN.TabIndex = 0;
            textBoxTask_KMN.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.. Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutPut_KMN
            // 
            groupBoxOutPut_KMN.Controls.Add(dataGridViewResult_KMN);
            groupBoxOutPut_KMN.Location = new Point(12, 76);
            groupBoxOutPut_KMN.Name = "groupBoxOutPut_KMN";
            groupBoxOutPut_KMN.Size = new Size(190, 362);
            groupBoxOutPut_KMN.TabIndex = 1;
            groupBoxOutPut_KMN.TabStop = false;
            groupBoxOutPut_KMN.Text = "Вывод данных";
            // 
            // dataGridViewResult_KMN
            // 
            dataGridViewResult_KMN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KMN.Dock = DockStyle.Fill;
            dataGridViewResult_KMN.Location = new Point(3, 19);
            dataGridViewResult_KMN.Name = "dataGridViewResult_KMN";
            dataGridViewResult_KMN.RowHeadersVisible = false;
            dataGridViewResult_KMN.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_KMN.Size = new Size(184, 340);
            dataGridViewResult_KMN.TabIndex = 0;
            // 
            // chartResult_KMN
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_KMN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_KMN.Legends.Add(legend1);
            chartResult_KMN.Location = new Point(212, 89);
            chartResult_KMN.Name = "chartResult_KMN";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_KMN.Series.Add(series1);
            chartResult_KMN.Size = new Size(573, 346);
            chartResult_KMN.TabIndex = 2;
            chartResult_KMN.Text = "chart1";
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.LimeGreen;
            buttonDone_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KMN.Location = new Point(488, 8);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(89, 76);
            buttonDone_KMN.TabIndex = 3;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // buttonOpen_KMN
            // 
            buttonOpen_KMN.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpen_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpen_KMN.Location = new Point(592, 7);
            buttonOpen_KMN.Name = "buttonOpen_KMN";
            buttonOpen_KMN.Size = new Size(89, 76);
            buttonOpen_KMN.TabIndex = 4;
            buttonOpen_KMN.Text = "Открыть файл";
            buttonOpen_KMN.UseVisualStyleBackColor = false;
            buttonOpen_KMN.Click += buttonOpen_KMN_Click;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.Orchid;
            buttonHelp_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KMN.Location = new Point(696, 8);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(89, 76);
            buttonHelp_KMN.TabIndex = 4;
            buttonHelp_KMN.Text = "Справка";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(buttonOpen_KMN);
            Controls.Add(buttonDone_KMN);
            Controls.Add(chartResult_KMN);
            Controls.Add(groupBoxOutPut_KMN);
            Controls.Add(groupBoxTask_KMN);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask_KMN.ResumeLayout(false);
            groupBoxTask_KMN.PerformLayout();
            groupBoxOutPut_KMN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KMN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_KMN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KMN;
        private TextBox textBoxTask_KMN;
        private GroupBox groupBoxOutPut_KMN;
        private DataGridView dataGridViewResult_KMN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KMN;
        private Button buttonDone_KMN;
        private Button buttonOpen_KMN;
        private Button buttonHelp_KMN;
    }
}
