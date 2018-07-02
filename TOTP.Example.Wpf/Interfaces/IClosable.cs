using System.Windows.Input;

namespace TOTP.Example.Wpf.Interfaces
{
    public interface IClosable
    {
        ICommand CloseCommand { get; set; }
    }
}