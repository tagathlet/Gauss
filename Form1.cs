using GaussLib;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int MAXSIZE = 6;
        System.Windows.Forms.TextBox[,] A = new System.Windows.Forms.TextBox[MAXSIZE, MAXSIZE + 1];
        System.Windows.Forms.Label[,] L = new System.Windows.Forms.Label[MAXSIZE, MAXSIZE];
        EquationSystem es;

        private void Form1_Load(object sender, EventArgs e)
        {
            draw_coef(2);
        }

        private void draw_coef(int n)
        {
            int vertical_padding = 50;
            int horizontal_padding = 80;
            int width = 40;
            int height = 20;
            int left = 25;
            int top = 70;

            for (int i = 0; i < MAXSIZE; i++)
            {
                for (int j = 0; j < MAXSIZE + 1; j++)
                {
                    if (A[i, j] != null)
                    {
                        this.Controls.Remove(A[i, j]);
                        A[i, j].Dispose();
                    }
                    if (j == MAXSIZE) break;
                    if (L[i, j] != null)
                    {
                        this.Controls.Remove(L[i, j]);
                        L[i, j].Dispose();
                    }
                }
            }

            int y = top;
            for (int i = 0; i < n; i++)
            {
                int x = left;
                for (int j = 0; j < n + 1; j++)
                {

                    System.Windows.Forms.TextBox t = new System.Windows.Forms.TextBox();
                    t.Location = new System.Drawing.Point(x, y);
                    t.Size = new System.Drawing.Size(width, height);
                    A[i, j] = t;
                    this.Controls.Add(A[i, j]);

                    x += width;

                    if (j == n) break;
                    Label l = new Label();
                    L[i, j] = l;
                    l.AutoSize = true;
                    l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    l.Location = new System.Drawing.Point(x, y);
                    l.Size = new System.Drawing.Size(width, height);
                    if (j == n - 1)
                    {
                        l.Text = "x" + (j + 1) + " =";
                    }
                    else
                    {
                        l.Text = "x" + (j + 1) + " +";
                    }
                    this.Controls.Add(l);
                    x += width;
                }
                y += vertical_padding;
            }
        }
        private void number_of_equations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Int32.Parse(number_of_equations.SelectedItem.ToString());
            draw_coef(n);

        }

        private void solution_button_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(number_of_equations.SelectedItem.ToString());
            Double[,] M = new Double[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    try
                    {
                        M[i, j] = Double.Parse(A[i, j].Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Введите вещественные числа");
                        return;
                    }
                }
            }
            es = new EquationSystem(M, n);
            solutionTB.Text = es.Solve();
            solutionTB.Text += "\nВремя: " + es.getTime();
        }

        private void save_in_file_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (es == null || es.getResult() == null || es.getResult() == "")
                {
                    MessageBox.Show("Сначала нажмите решить.");
                    return;
                }
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Выберите файл для сохранения";
                saveFileDialog.FileName = "myfile.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        string filePath = saveFileDialog.FileName;
                        es.writeToFile(filePath);
                        MessageBox.Show("Текст успешно записан в файл.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при записи файла: {ex.Message}");
                    }
                }
            }
        }

        private void SaveToDB_Click(object sender, EventArgs e)
        {
            if (es == null || es.getResult() == null || es.getResult() == "")
            {
                MessageBox.Show("Сначала нажмите решить.");
                return;
            }
            try
            {
                es.writeToDB();
                MessageBox.Show("Успешно! Результаты записаны в БД");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи: {ex.Message}");
            }


        }
    }

}
