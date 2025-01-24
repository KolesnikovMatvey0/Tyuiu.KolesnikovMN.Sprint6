namespace Tyuiu.KolesnikovMN.Sprint6.Task1.V12
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
            textBoxResult_KMN = new TextBox();
            textBoxInPut_KMN = new TextBox();
            textBoxStartStep_KMN = new TextBox();
            textBoxStopStep_KMN = new TextBox();
            textBoxTask_KMN = new TextBox();
            textBoxOutPut_KMN = new TextBox();
            buttonDone_KMN = new Button();
            buttonHelp_KMN = new Button();
            SuspendLayout();
            // 
            // textBoxResult_KMN
            // 
            textBoxResult_KMN.BackColor = SystemColors.Menu;
            textBoxResult_KMN.Location = new Point(488, 73);
            textBoxResult_KMN.Multiline = true;
            textBoxResult_KMN.Name = "textBoxResult_KMN";
            textBoxResult_KMN.Size = new Size(182, 223);
            textBoxResult_KMN.TabIndex = 0;
            // 
            // textBoxInPut_KMN
            // 
            textBoxInPut_KMN.BackColor = SystemColors.Menu;
            textBoxInPut_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxInPut_KMN.Location = new Point(27, 226);
            textBoxInPut_KMN.Multiline = true;
            textBoxInPut_KMN.Name = "textBoxInPut_KMN";
            textBoxInPut_KMN.Size = new Size(280, 72);
            textBoxInPut_KMN.TabIndex = 1;
            textBoxInPut_KMN.Text = "Ввод данных\r\n\r\n  Старт шага:               Конец шага:";
            // 
            // textBoxStartStep_KMN
            // 
            textBoxStartStep_KMN.Location = new Point(35, 273);
            textBoxStartStep_KMN.Name = "textBoxStartStep_KMN";
            textBoxStartStep_KMN.Size = new Size(90, 23);
            textBoxStartStep_KMN.TabIndex = 2;
            textBoxStartStep_KMN.TextChanged += textBoxStartStep_KMN_TextChanged;
            textBoxStartStep_KMN.KeyPress += textBoxStartStep_KMN_KeyPress;
            // 
            // textBoxStopStep_KMN
            // 
            textBoxStopStep_KMN.Location = new Point(146, 273);
            textBoxStopStep_KMN.Name = "textBoxStopStep_KMN";
            textBoxStopStep_KMN.Size = new Size(90, 23);
            textBoxStopStep_KMN.TabIndex = 3;
            textBoxStopStep_KMN.TextChanged += textBoxStartStep_KMN_TextChanged;
            textBoxStopStep_KMN.KeyPress += textBoxStopStep_KMN_KeyPress;
            // 
            // textBoxTask_KMN
            // 
            textBoxTask_KMN.BackColor = SystemColors.Menu;
            textBoxTask_KMN.BorderStyle = BorderStyle.None;
            textBoxTask_KMN.Location = new Point(27, 12);
            textBoxTask_KMN.Multiline = true;
            textBoxTask_KMN.Name = "textBoxTask_KMN";
            textBoxTask_KMN.Size = new Size(455, 204);
            textBoxTask_KMN.TabIndex = 4;
            textBoxTask_KMN.Text = "Условие\r\nПротабулировать функцию на заданном диапозоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // textBoxOutPut_KMN
            // 
            textBoxOutPut_KMN.BackColor = SystemColors.Menu;
            textBoxOutPut_KMN.BorderStyle = BorderStyle.None;
            textBoxOutPut_KMN.Location = new Point(488, 12);
            textBoxOutPut_KMN.Multiline = true;
            textBoxOutPut_KMN.Name = "textBoxOutPut_KMN";
            textBoxOutPut_KMN.Size = new Size(182, 55);
            textBoxOutPut_KMN.TabIndex = 5;
            textBoxOutPut_KMN.Text = "Вывод данных\r\n\r\nРезультат:";
            textBoxOutPut_KMN.TextChanged += textBox2_TextChanged;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.LimeGreen;
            buttonDone_KMN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KMN.Location = new Point(313, 226);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(92, 72);
            buttonDone_KMN.TabIndex = 6;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.FromArgb(255, 255, 192);
            buttonHelp_KMN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KMN.Location = new Point(411, 226);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(70, 70);
            buttonHelp_KMN.TabIndex = 7;
            buttonHelp_KMN.Text = "?";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 308);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(buttonDone_KMN);
            Controls.Add(textBoxOutPut_KMN);
            Controls.Add(textBoxTask_KMN);
            Controls.Add(textBoxStopStep_KMN);
            Controls.Add(textBoxStartStep_KMN);
            Controls.Add(textBoxInPut_KMN);
            Controls.Add(textBoxResult_KMN);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_KMN;
        private TextBox textBoxInPut_KMN;
        private TextBox textBoxStartStep_KMN;
        private TextBox textBoxStopStep_KMN;
        private TextBox textBoxTask_KMN;
        private TextBox textBoxOutPut_KMN;
        private Button buttonDone_KMN;
        private Button buttonHelp_KMN;
    }
}
