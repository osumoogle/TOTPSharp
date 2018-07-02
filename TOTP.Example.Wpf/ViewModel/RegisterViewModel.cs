using System.Windows.Input;
using TOTP.Example.Wpf.Interfaces;

namespace TOTP.Example.Wpf.ViewModel
{
    public class RegisterViewModel : IClosable
    {
        public ICommand CloseCommand { get; set; }
    }
}
