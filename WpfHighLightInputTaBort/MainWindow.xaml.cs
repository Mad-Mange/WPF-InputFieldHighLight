using System.Windows;
using WpfHighLightInputTaBort.ViewModels;











namespace WpfHighLightInputTaBort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _main = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;
        }
    }
}
