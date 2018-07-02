using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using TOTP.Example.Wpf.Interfaces;

namespace TOTP.Example.Wpf.ViewModels
{
    public class RegistrationViewModel : IClosable
    {
        public ICommand CloseCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public RegistrationViewModel()
        {
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            
        }
    }
}
