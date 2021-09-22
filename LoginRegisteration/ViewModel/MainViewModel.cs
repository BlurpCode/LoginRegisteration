using LoginRegisteration.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginRegisteration.ViewModel
{
    //This view model will control the navigation between viewModels
    public class MainViewModel:ViewModelBase
    {
        private ViewModelBase _currentViewModel = new LoginViewModel();
        public ViewModelBase currentViewModel
        {
            get { return _currentViewModel; }
            set { 
                _currentViewModel = value;
                OnPropertyChanged(nameof(currentViewModel));
                
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel() {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
