using NavigationBar;
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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            bar.SelectedIndex = 2;
        }

        private void bar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = e;
            var bar1 = sender as MagicBar;

            content.Content = bar1.SelectedIndex switch
            {
                0 => new TextBox() { Text = bar1.SelectedItem.ToString() },
                1 => new TextBox() { Text = bar1.SelectedItem.ToString() },
                _=> new TextBox() { Text = bar1.SelectedItem.ToString() },
            };
        }
    }
}