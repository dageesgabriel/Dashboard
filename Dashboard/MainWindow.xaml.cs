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

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Revenue revenue = new Revenue();
            DataContext = new RevenueViewModel(revenue);
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://www.gmail.com");
        }

        private void alerta_Click(object sender, RoutedEventArgs e)
        {
            string alerta = "Alerta ativado!";
            MessageBoxResult result = MessageBox.Show(alerta);
        }

        internal class RevenueViewModel
        {
            public List<Revenue> Revenue { get; private set; }

            public RevenueViewModel(Revenue revenue)
            {
                Revenue = new List<Revenue>();
                Revenue.Add(revenue);
            }
        }

        internal class Revenue
        {
            public string title { get; private set; }

            public int percentage { get; private set; }

            public Revenue()
            {
                title = "Last year percentage calculation...";
                percentage = CalculePercentage();
            }

            private int CalculePercentage()
            {
                return 89; //Percentage Calculation...
            }

        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://en.wikipedia.org/wiki/Hexagon");
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://en.wikipedia.org/wiki/Hexagon");
        }

        private void TextBlock_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://en.wikipedia.org/wiki/Hexagon");
        }
    }
}
