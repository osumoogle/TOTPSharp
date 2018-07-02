using TOTP.Example.Wpf.ViewModels;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace TOTP.Example.Wpf
{
    public partial class MainWindow
    {
        public MainWindowViewModel ViewModel{ get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel {CloseCommand = new RelayCommand(Close)};
            DataContext = ViewModel;
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
