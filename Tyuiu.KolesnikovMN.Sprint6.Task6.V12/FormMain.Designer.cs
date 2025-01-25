namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V12
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
            groupBoxTask_KMN = new GroupBox();
            textBoxTask_KMN = new TextBox();
            groupBoxInPut_KMN = new GroupBox();
            textBoxInPut_KMN = new TextBox();
            groupBoxOutPut_KMN = new GroupBox();
            textBoxOutPut_KMN = new TextBox();
            buttonHelp_KMN = new Button();
            buttonOpen_KMN = new Button();
            buttonDone_KMN = new Button();
            openFileDialog_KMN = new OpenFileDialog();
            groupBoxTask_KMN.SuspendLayout();
            groupBoxInPut_KMN.SuspendLayout();
            groupBoxOutPut_KMN.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KMN
            // 
            groupBoxTask_KMN.Controls.Add(textBoxTask_KMN);
            groupBoxTask_KMN.Location = new Point(12, 85);
            groupBoxTask_KMN.Name = "groupBoxTask_KMN";
            groupBoxTask_KMN.Size = new Size(776, 86);
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
            textBoxTask_KMN.Size = new Size(770, 64);
            textBoxTask_KMN.TabIndex = 0;
            textBoxTask_KMN.Text = resources.GetString("textBoxTask_KMN.Text");
            // 
            // groupBoxInPut_KMN
            // 
            groupBoxInPut_KMN.Controls.Add(textBoxInPut_KMN);
            groupBoxInPut_KMN.Location = new Point(12, 177);
            groupBoxInPut_KMN.Name = "groupBoxInPut_KMN";
            groupBoxInPut_KMN.Size = new Size(376, 268);
            groupBoxInPut_KMN.TabIndex = 1;
            groupBoxInPut_KMN.TabStop = false;
            groupBoxInPut_KMN.Text = "Ввод:";
            // 
            // textBoxInPut_KMN
            // 
            textBoxInPut_KMN.BorderStyle = BorderStyle.None;
            textBoxInPut_KMN.Dock = DockStyle.Fill;
            textBoxInPut_KMN.Location = new Point(3, 19);
            textBoxInPut_KMN.Multiline = true;
            textBoxInPut_KMN.Name = "textBoxInPut_KMN";
            textBoxInPut_KMN.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_KMN.Size = new Size(370, 246);
            textBoxInPut_KMN.TabIndex = 0;
            // 
            // groupBoxOutPut_KMN
            // 
            groupBoxOutPut_KMN.Controls.Add(textBoxOutPut_KMN);
            groupBoxOutPut_KMN.Location = new Point(409, 177);
            groupBoxOutPut_KMN.Name = "groupBoxOutPut_KMN";
            groupBoxOutPut_KMN.Size = new Size(379, 267);
            groupBoxOutPut_KMN.TabIndex = 2;
            groupBoxOutPut_KMN.TabStop = false;
            groupBoxOutPut_KMN.Text = "Вывод:";
            // 
            // textBoxOutPut_KMN
            // 
            textBoxOutPut_KMN.BorderStyle = BorderStyle.None;
            textBoxOutPut_KMN.Dock = DockStyle.Fill;
            textBoxOutPut_KMN.Location = new Point(3, 19);
            textBoxOutPut_KMN.Multiline = true;
            textBoxOutPut_KMN.Name = "textBoxOutPut_KMN";
            textBoxOutPut_KMN.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_KMN.Size = new Size(373, 245);
            textBoxOutPut_KMN.TabIndex = 0;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = Color.FromArgb(255, 128, 0);
            buttonHelp_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KMN.Location = new Point(696, 4);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(89, 75);
            buttonHelp_KMN.TabIndex = 3;
            buttonHelp_KMN.Text = "Справка";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // buttonOpen_KMN
            // 
            buttonOpen_KMN.BackColor = Color.RoyalBlue;
            buttonOpen_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpen_KMN.Location = new Point(12, 4);
            buttonOpen_KMN.Name = "buttonOpen_KMN";
            buttonOpen_KMN.Size = new Size(87, 75);
            buttonOpen_KMN.TabIndex = 3;
            buttonOpen_KMN.Text = "Открыть файл";
            buttonOpen_KMN.UseVisualStyleBackColor = false;
            buttonOpen_KMN.Click += buttonOpen_KMN_Click;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KMN.Location = new Point(105, 4);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(96, 75);
            buttonDone_KMN.TabIndex = 4;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonDone_KMN_Click;
            // 
            // openFileDialog_KMN
            // 
            openFileDialog_KMN.FileName = "openFileDialog";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KMN);
            Controls.Add(buttonOpen_KMN);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(groupBoxOutPut_KMN);
            Controls.Add(groupBoxInPut_KMN);
            Controls.Add(groupBoxTask_KMN);
            Name = "FormMain";
            Text = "FormMain";
            groupBoxTask_KMN.ResumeLayout(false);
            groupBoxTask_KMN.PerformLayout();
            groupBoxInPut_KMN.ResumeLayout(false);
            groupBoxInPut_KMN.PerformLayout();
            groupBoxOutPut_KMN.ResumeLayout(false);
            groupBoxOutPut_KMN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KMN;
        private TextBox textBoxTask_KMN;
        private GroupBox groupBoxInPut_KMN;
        private TextBox textBoxInPut_KMN;
        private GroupBox groupBoxOutPut_KMN;
        private TextBox textBoxOutPut_KMN;
        private Button buttonHelp_KMN;
        private Button buttonOpen_KMN;
        private Button buttonDone_KMN;
        private OpenFileDialog openFileDialog_KMN;
    }
}
