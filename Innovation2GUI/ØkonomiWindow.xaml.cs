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
using System.Windows.Shapes;
using Innovation2GUI.ØkonomiPages;

namespace Innovation2GUI
{
    /// <summary>
    /// Interaction logic for ØkonomiWindow.xaml
    /// </summary>
    public partial class ØkonomiWindow : Window
    {
        public ØkonomiWindow()
        {
            InitializeComponent();
            Default def = new Default();
            ØkonomiFrame.Navigate(def);

        }

        private void TilbageBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void BudgetBtn_Click(object sender, RoutedEventArgs e)
        {
            Budget bpage = new Budget();
            ØkonomiFrame.Navigate(bpage);
        }

        private void LønOgSkatBtn_Click(object sender, RoutedEventArgs e)
        {
            SkatPage spage = new SkatPage();
            ØkonomiFrame.Navigate(spage);
        }
    }
}
