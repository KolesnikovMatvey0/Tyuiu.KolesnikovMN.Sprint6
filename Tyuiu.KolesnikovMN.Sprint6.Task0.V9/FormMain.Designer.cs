namespace Tyuiu.KolesnikovMN.Sprint6.Task0.V9
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
            textBoxCondition_KMN = new TextBox();
            pictureBoxFormula_KMN = new PictureBox();
            textBoxGroup_KMN = new TextBox();
            textBoxVarX_KMN = new TextBox();
            textBoxResult_KMN = new TextBox();
            buttonDone_KMN = new Button();
            buttonHelp_KMN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KMN).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_KMN
            // 
            textBoxCondition_KMN.BackColor = SystemColors.Menu;
            textBoxCondition_KMN.BorderStyle = BorderStyle.None;
            textBoxCondition_KMN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxCondition_KMN.Location = new Point(14, 12);
            textBoxCondition_KMN.Multiline = true;
            textBoxCondition_KMN.Name = "textBoxCondition_KMN";
            textBoxCondition_KMN.Size = new Size(360, 128);
            textBoxCondition_KMN.TabIndex = 0;
            textBoxCondition_KMN.Text = "Условие\r\nВычислить значение выражения по формуле";
            // 
            // pictureBoxFormula_KMN
            // 
            pictureBoxFormula_KMN.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFormula_KMN.Image = Properties.Resources.Снимок_экрана__1_;
            pictureBoxFormula_KMN.Location = new Point(403, 12);
            pictureBoxFormula_KMN.Name = "pictureBoxFormula_KMN";
            pictureBoxFormula_KMN.Size = new Size(105, 65);
            pictureBoxFormula_KMN.TabIndex = 1;
            pictureBoxFormula_KMN.TabStop = false;
            pictureBoxFormula_KMN.Click += pictureBoxFormula_KMN_Click;
            // 
            // textBoxGroup_KMN
            // 
            textBoxGroup_KMN.AccessibleRole = AccessibleRole.None;
            textBoxGroup_KMN.BackColor = SystemColors.MenuBar;
            textBoxGroup_KMN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxGroup_KMN.Location = new Point(14, 146);
            textBoxGroup_KMN.Multiline = true;
            textBoxGroup_KMN.Name = "textBoxGroup_KMN";
            textBoxGroup_KMN.Size = new Size(490, 75);
            textBoxGroup_KMN.TabIndex = 2;
            textBoxGroup_KMN.Text = "     Ввод данных                                     Вывод данных\r\n     Переменная X:                                   Результат:";
            // 
            // textBoxVarX_KMN
            // 
            textBoxVarX_KMN.BackColor = SystemColors.Window;
            textBoxVarX_KMN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxVarX_KMN.Location = new Point(35, 186);
            textBoxVarX_KMN.Name = "textBoxVarX_KMN";
            textBoxVarX_KMN.Size = new Size(111, 23);
            textBoxVarX_KMN.TabIndex = 3;
            textBoxVarX_KMN.TextAlign = HorizontalAlignment.Center;
            textBoxVarX_KMN.KeyPress += textBoxVarX_KMN_KeyPress;
            // 
            // textBoxResult_KMN
            // 
            textBoxResult_KMN.Location = new Point(265, 186);
            textBoxResult_KMN.Name = "textBoxResult_KMN";
            textBoxResult_KMN.Size = new Size(109, 23);
            textBoxResult_KMN.TabIndex = 4;
            // 
            // buttonDone_KMN
            // 
            buttonDone_KMN.BackColor = SystemColors.ButtonFace;
            buttonDone_KMN.Location = new Point(403, 151);
            buttonDone_KMN.Name = "buttonDone_KMN";
            buttonDone_KMN.Size = new Size(94, 35);
            buttonDone_KMN.TabIndex = 5;
            buttonDone_KMN.Text = "Выполнить";
            buttonDone_KMN.UseVisualStyleBackColor = false;
            buttonDone_KMN.Click += buttonResult_KMN_Click;
            // 
            // buttonHelp_KMN
            // 
            buttonHelp_KMN.BackColor = SystemColors.ButtonFace;
            buttonHelp_KMN.Location = new Point(470, 192);
            buttonHelp_KMN.Name = "buttonHelp_KMN";
            buttonHelp_KMN.Size = new Size(27, 26);
            buttonHelp_KMN.TabIndex = 6;
            buttonHelp_KMN.Text = "?";
            buttonHelp_KMN.UseVisualStyleBackColor = false;
            buttonHelp_KMN.Click += buttonHelp_KMN_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 230);
            Controls.Add(buttonHelp_KMN);
            Controls.Add(buttonDone_KMN);
            Controls.Add(textBoxResult_KMN);
            Controls.Add(textBoxVarX_KMN);
            Controls.Add(textBoxGroup_KMN);
            Controls.Add(pictureBoxFormula_KMN);
            Controls.Add(textBoxCondition_KMN);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KMN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_KMN;
        private PictureBox pictureBoxFormula_KMN;
        private TextBox textBoxGroup_KMN;
        private TextBox textBoxVarX_KMN;
        private TextBox textBoxResult_KMN;
        private Button buttonDone_KMN;
        private Button buttonHelp_KMN;
    }
}
