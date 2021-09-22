using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginRegisteration.ViewModel;

namespace LoginRegisteration.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Register")
            {
                viewModel.currentViewModel = new RegistrationViewModel();
            }
            else if (parameter.ToString() == "Login")
            {
                viewModel.currentViewModel = new LoginViewModel();
            }
        }
    }
}
