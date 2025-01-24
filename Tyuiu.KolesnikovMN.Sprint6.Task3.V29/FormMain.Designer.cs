namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask_KMN = new TextBox();
            textBoxOutPut_KMN = new TextBox();
            dataGridViewMatrix_KMN = new DataGridView();
            buttonDone_KMN = new Button();
            buttonHelp_KMN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KMN).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_KMN
            // 
            textBoxTask_KMN.BackColor = SystemColors.Menu;
            textBoxTask_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxTask_KMN.Location = new Point(13, 12);
            textBoxTask_KMN.Multiline = true;
            textBoxTask_KMN.Name = "textBoxTask_KMN";
            textBoxTask_KMN.Size = new Size(442, 280);
            textBoxTask_KMN.TabIndex = 0;
            textBoxTask_KMN.Text = resources.GetString("textBoxTask_KMN.Text");
            textBoxTask_KMN.TextChanged += textBox1_TextChanged;
            // 
            // textBoxOutPut_KMN
            // 
            textBoxOutPut_KMN.BackColor = SystemColors.Menu;
            textBoxOutPut_KMN.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutPut_KMN.Location = new Point(461, 12);
            textBoxOutPut_KMN.Multiline = true;
            textBoxOutPut_KMN.Name = "textBoxOutPut_KMN";
            textBoxOutPut_KMN.Size = new Size(327, 280);
            textBoxOutPut_KMN.TabIndex = 1;
            textBoxOutPut_KMN.Text = "Вывод данных\r\n\r\n    Результат:";
            textBoxOutPut_KMN.TextChanged += textBox1_TextChanged_1;
            // 
            // dataGridViewMatrix_KMN
            // 
            dataGridViewMatrix_KMN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KMN.Location = new Point(477, 63);
            dataGridViewMatrix_KMN.Name = "dataGridViewMatrix_KMN";
            dataGridViewMatrix_KMN.RowHeadersVisible = false;
            dataGridViewMatrix_KMN.Size = new Size(215, 215);
            dataGridViewMatrix_KMN.TabIndex = 2;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_KMN.Location = new Point(698, 63);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(79, 35);
            buttonDone_KMN.TabIndex = 3;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_KMN.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_KMN.Location = new Point(698, 104);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(79, 79);
            buttonHelp_KMN.TabIndex = 4;
            buttonHelp_KMN.Text = "?";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(buttonDone_KMN);
            Controls.Add(dataGridViewMatrix_KMN);
            Controls.Add(textBoxOutPut_KMN);
            Controls.Add(textBoxTask_KMN);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KMN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_KMN;
        private TextBox textBoxOutPut_KMN;
        private DataGridView dataGridViewMatrix_KMN;
        private Button buttonDone_KMN;
        private Button buttonHelp_KMN;
    }
}
