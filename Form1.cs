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

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Выбрать файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    linesFromFile = File.ReadAllLines(filePath).ToList();                    
                    MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormatButton_Click(object sender, EventArgs e)
        {
            string inputFormat = InputFormatTextBox.Text;
            List<int> formatIndexes = inputFormat.Split(':').Select(int.Parse).ToList();

            List<string> inputLines = new List<string>();

            if (linesFromFile.Any())
            {
                inputLines = linesFromFile;
            }
            else
            {
                inputLines = InputDataTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            }

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

            OutputDataListBox.Items.Clear();
            OutputDataListBox.Items.AddRange(formattedLines.ToArray());

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
    }
}
