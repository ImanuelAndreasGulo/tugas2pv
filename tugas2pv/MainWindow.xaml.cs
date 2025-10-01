using System.Windows;
using System.Windows.Controls;

namespace tugas2pv
{
    public partial class MainWindow : Window
    {
        private double lastNumber, result;
        private SelectedOperator selectedOperator;
        private bool operatorClicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private enum SelectedOperator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            if (DisplayText.Text == "0" || operatorClicked)
            {
                DisplayText.Text = button.Content.ToString();
                operatorClicked = false;
            }
            else
            {
                DisplayText.Text += button.Content.ToString();
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            if (double.TryParse(DisplayText.Text, out lastNumber))
            {
                switch (button.Content.ToString())
                {
                    case "+":
                        selectedOperator = SelectedOperator.Addition;
                        break;
                    case "-":
                        selectedOperator = SelectedOperator.Subtraction;
                        break;
                    case "×":
                        selectedOperator = SelectedOperator.Multiplication;
                        break;
                    case "/":
                        selectedOperator = SelectedOperator.Division;
                        break;
                }
                operatorClicked = true;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(DisplayText.Text, out double newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = lastNumber + newNumber;
                        break;
                    case SelectedOperator.Subtraction:
                        result = lastNumber - newNumber;
                        break;
                    case SelectedOperator.Multiplication:
                        result = lastNumber * newNumber;
                        break;
                    case SelectedOperator.Division:
                        if (newNumber != 0)
                            result = lastNumber / newNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error");
                            return;
                        }
                        break;
                }
                DisplayText.Text = result.ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DisplayText.Text = "0";
            lastNumber = 0;
            result = 0;
            operatorClicked = false;
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            DisplayText.Text = "0";
            operatorClicked = false;
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!DisplayText.Text.Contains("."))
            {
                DisplayText.Text += ".";
            }
        }

        private void ChangeSign_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(DisplayText.Text, out double number))
            {
                number = -number;
                DisplayText.Text = number.ToString();
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Text.Length > 1)
            {
                DisplayText.Text = DisplayText.Text.Substring(0, DisplayText.Text.Length - 1);
            }
            else
            {
                DisplayText.Text = "0";
            }
        }
    }
}