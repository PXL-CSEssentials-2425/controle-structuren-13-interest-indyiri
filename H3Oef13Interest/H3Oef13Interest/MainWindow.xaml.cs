using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H3Oef13Interest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            initialCapitalTextBox.Clear();
            desiredFinalCapitalTextBox.Clear();
            interestTextBox.Clear();
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        StringBuilder sb = new StringBuilder();

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double initialCapital = 0.00;
            double desiredFinalCapital = 0.00;
            double interest = 0.00;
            int amountOfYears = 0;
            
            string inputInitialCapital = initialCapitalTextBox.Text;
            string inputDesiredFinalCapital = desiredFinalCapitalTextBox.Text;
            string inputInterest = interestTextBox.Text;

            bool isinputInitialCapitalValid = double.TryParse(inputInitialCapital, out initialCapital);
            bool isinputDesiredFinalCapitalValid = double.TryParse(inputDesiredFinalCapital, out desiredFinalCapital);
            bool isinputInterestValid = double.TryParse(inputInterest, out interest);

            if (isinputInitialCapitalValid && initialCapital > 0 && desiredFinalCapital > 0 && isinputDesiredFinalCapitalValid && isinputInterestValid && interest > 0 )
            {
                while (initialCapital < desiredFinalCapital)
                {
                    initialCapital *= (1 + (interest / 100));
                    amountOfYears++;

                    sb.AppendLine($"Waarde na {amountOfYears} jaren: €{Math.Round(initialCapital, 2)}");
                    
                    //resultTextBox.Text = $"Waarde na {amountOfYears} jaren: €{Math.Round(initialCapital, 2)}";
                }
                resultTextBox.Text = sb.ToString();
            }
            else if (!isinputInitialCapitalValid || !isinputDesiredFinalCapitalValid || !isinputInterestValid || interest <= 0) 
            {
                resultTextBox.Text = "Geef correcte waarden in: interest, begin- en eindkapitaal moeten getallen zijn groter dan 0";
            }
        }
    }
}