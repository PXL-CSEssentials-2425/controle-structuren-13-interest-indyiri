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
            initialCapitalTextBox.Clear();
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}