using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginRegisteration.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        public string WelcomeMessage = "Login";
        public ICommand NavigateAccountCommand { get; }
    }
}
