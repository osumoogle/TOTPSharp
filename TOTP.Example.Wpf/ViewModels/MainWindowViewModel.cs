using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using TOTP.Example.Wpf.Interfaces;
using TOTP.Example.Wpf.Views;

namespace TOTP.Example.Wpf.ViewModels
{
    public class MainWindowViewModel : IClosable
    {
        public ICommand RegisterCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        public MainWindowViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
        }

        private static void Register()
        {
            var dialog = new Register();
            dialog.ShowDialog();
        }
    }
}
