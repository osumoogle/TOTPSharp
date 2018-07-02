using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using TOTP.Example.Wpf.ViewModel;

namespace TOTP.Example.Wpf.Views
{
    public partial class Register
    {
        private RegisterViewModel _viewModel;

        public Register()
        {
            InitializeComponent();
            _viewModel = new RegisterViewModel { CloseCommand = new RelayCommand(Close) };
            DataContext = _viewModel;
        }

        private void Register_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
