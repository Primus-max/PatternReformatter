using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PatternReformatter
{
    public partial class Form1 : Form
    {
        private List<string> linesFromFile = new List<string>();
        private string bannerImageUrl;
        private string redirectUrl;

        public Form1()
        {
            InitializeComponent();
            FetchResourcesAndDisplayBanner();

            this.Load += new EventHandler(this.AirForm1_Load);
            AppDomain.CurrentDomain.UnhandledException += HandleGlobalException;           
        }

        private void HandleGlobalException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Произошла неустановленная ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AirForm1_Load(object sender, EventArgs e)
        {
            // Конечная дата для проверки
            DateTime expirationDate = new DateTime(2024, 06, 03);

            // Текущая дата
            DateTime currentDate = DateTime.Now;

            // Проверка текущей даты с конечной датой
            if (currentDate > expirationDate)
            {
                MessageBox.Show("Срок действия программы истек. Пожалуйста, свяжитесь с разработчиком.", "Срок действия истек", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private async void FetchResourcesAndDisplayBanner()
        {
            try
            {
                var resourcesFetcher = new ResourcesFetcher();
                (bannerImageUrl, redirectUrl) = await resourcesFetcher.FetchResources();
                DisplayBanner();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching resources: {ex.Message}");
            }
        }

        private void DisplayBanner()
        {
            if (!string.IsNullOrEmpty(bannerImageUrl))
            {
                pictureBox1.Load(bannerImageUrl);
                pictureBox1.Click += PictureBox1_Click;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(redirectUrl))
            {
                System.Diagnostics.Process.Start(redirectUrl);
            }
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Select a text file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    linesFromFile = File.ReadAllLines(filePath).ToList();
                    InputDataTextBox.Text = string.Join(Environment.NewLine, linesFromFile);
                    if (linesFromFile.Count == 0)
                        MessageBox.Show("Из файла не удалось ничего прочитать, проверьте его", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputFormat = InputFormatTextBox.Text;
            if (string.IsNullOrEmpty(inputFormat))
            {
                MessageBox.Show("Проверьте формат для строк, возможно вы его не указали", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            List<int> formatIndexes = inputFormat.Split(':').Select(int.Parse).ToList();

            List<string> inputLines = new List<string>();

            inputLines = linesFromFile.Any()
                ? linesFromFile
                : InputDataTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            List<string> formattedLines = new List<string>();

            foreach (var line in inputLines)
            {
                var parts = line.Split(':');
                List<string> formattedParts = new List<string>();

                foreach (var index in formatIndexes)
                {
                    if (index - 1 < parts.Length)
                    {
                        formattedParts.Add(parts[index - 1]);
                    }
                }

                formattedLines.Add(string.Join(":", formattedParts));
            }

            OutputDataTextBox.Text = string.Join(Environment.NewLine, formattedLines);

            if (ToggleButton.Toggled)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                    saveFileDialog.Title = "Save formatted text file";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = saveFileDialog.FileName;
                        File.WriteAllLines(savePath, formattedLines);
                        MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void OpenInfoPopup_Click(object sender, EventArgs e)
        {
            InfoPopup infoPopup = new InfoPopup();
            infoPopup.Show();
        }
    }
}
