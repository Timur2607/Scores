using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scores
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public string Module1ScoreText
        {
            get => Module1Score.Text;
            set => Module1Score.Text = value;
        }

        public string Module2ScoreText
        {
            get => Module2Score.Text;
            set => Module2Score.Text = value;
        }

        public string Module3ScoreText
        {
            get => Module3Score.Text;
            set => Module3Score.Text = value;
        }

        public string LastMessage { get; private set; }

        private void ShowMessage(string message)
        {
            LastMessage = message;
            MessageBox.Show(message);
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int module1 = Convert.ToInt32(Module1Score.Text);
                int module2 = Convert.ToInt32(Module2Score.Text);
                int module3 = Convert.ToInt32(Module3Score.Text);

                if (module1 < 0 || module1 > 22 || module2 < 0 || module2 > 38 || module3 < 0 || module3 > 20)
                {
                    MessageBox.Show("Ошибка: баллы должны быть в допустимом диапазоне!");
                    return;
                }

                int total = module1 + module2 + module3;
                string grade = GetGrade(total);

                TotalScoreText.Text = $"Общая сумма баллов: {total}";
                GradeText.Text = $"Оценка: {grade}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите числовые значения!");
            }
        }

        public string GetGrade(int total)
        {
            if (total >= 56) return "5 (отлично)";
            if (total >= 32) return "4 (хорошо)";
            if (total >= 16) return "3 (удовлетворительно)";
            return "2 (неудовлетворительно)";
        }
    }
}

