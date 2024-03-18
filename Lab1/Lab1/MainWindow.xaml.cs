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
using Lab1.bibliotekaDataSetTableAdapters;

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AuthorsTableAdapter authors = new AuthorsTableAdapter();
        private Window1 secondWindow;
        public MainWindow()
        {
            InitializeComponent();
            AuthorsDateGrid.ItemsSource = authors.GetData();
            AuthorsComboBox.ItemsSource = authors.GetData();
            AuthorsComboBox.DisplayMemberPath = "Name";
        }
        private void OpenSecond(object sender, RoutedEventArgs e)
        {
            if (secondWindow == null || !secondWindow.IsVisible)
            {
                secondWindow = new Window1();
                secondWindow.Show();
            }
        }
    }
}
