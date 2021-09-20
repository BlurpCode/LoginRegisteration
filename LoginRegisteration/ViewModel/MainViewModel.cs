using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisteration.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        public ViewModelBase CurrentViewModel = new ViewModelBase();

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
        }
    }
}
