namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            solution_button = new Button();
            solutionTB = new RichTextBox();
            number_of_equations = new ComboBox();
            save_in_file = new Button();
            SaveToDB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 28);
            label1.TabIndex = 0;
            label1.Text = "Количество неизвестных величин в системе";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(898, 62);
            label2.Name = "label2";
            label2.Size = new Size(141, 41);
            label2.TabIndex = 1;
            label2.Text = "Решение";
            // 
            // solution_button
            // 
            solution_button.Location = new Point(268, 544);
            solution_button.Name = "solution_button";
            solution_button.Size = new Size(94, 29);
            solution_button.TabIndex = 2;
            solution_button.Text = "Решить";
            solution_button.UseVisualStyleBackColor = true;
            solution_button.Click += solution_button_Click;
            // 
            // solutionTB
            // 
            solutionTB.Location = new Point(851, 118);
            solutionTB.Name = "solutionTB";
            solutionTB.Size = new Size(235, 313);
            solutionTB.TabIndex = 3;
            solutionTB.Text = "";
            // 
            // number_of_equations
            // 
            number_of_equations.FormattingEnabled = true;
            number_of_equations.Items.AddRange(new object[] { "2", "3", "4", "5", "6" });
            number_of_equations.Location = new Point(449, 13);
            number_of_equations.Name = "number_of_equations";
            number_of_equations.Size = new Size(57, 28);
            number_of_equations.TabIndex = 4;
            number_of_equations.Text = "2";
            number_of_equations.SelectedIndexChanged += number_of_equations_SelectedIndexChanged;
            // 
            // save_in_file
            // 
            save_in_file.Location = new Point(886, 437);
            save_in_file.Name = "save_in_file";
            save_in_file.Size = new Size(164, 29);
            save_in_file.TabIndex = 5;
            save_in_file.Text = "Сохранить в файл";
            save_in_file.UseVisualStyleBackColor = true;
            save_in_file.Click += save_in_file_Click;
            // 
            // SaveToDB
            // 
            SaveToDB.Location = new Point(886, 472);
            SaveToDB.Name = "SaveToDB";
            SaveToDB.Size = new Size(164, 29);
            SaveToDB.TabIndex = 6;
            SaveToDB.Text = "Сохранить в базу";
            SaveToDB.UseVisualStyleBackColor = true;
            SaveToDB.Click += SaveToDB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 611);
            Controls.Add(SaveToDB);
            Controls.Add(save_in_file);
            Controls.Add(number_of_equations);
            Controls.Add(solutionTB);
            Controls.Add(solution_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button solution_button;
        private RichTextBox solutionTB;
        private ComboBox number_of_equations;
        private Button save_in_file;
        private Button SaveToDB;
    }
}
