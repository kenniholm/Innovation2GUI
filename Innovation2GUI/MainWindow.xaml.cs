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

namespace Innovation2GUI
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

        private void ØkonomiBtn_Click(object sender, RoutedEventArgs e)
        {
            ØkonomiWindow øko = new ØkonomiWindow();
            øko.Show();
            this.Close();
        }

        private void Søg_Textbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Søg_Textbox.Clear();
        }
    }
}
