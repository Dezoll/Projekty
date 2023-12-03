using Firebase.Auth;
using Firebase_auth.WPF.Commands;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Firebase_auth.WPF.Viewmodels
{
   public class CompanyNameViewModel : ViewModelBase
    {
        private string _companyname;
        public string CompanyName
        {
            get
            {
                return _companyname;
            }
            set
            {
                _companyname = value;
                OnPropertyChanged(nameof(CompanyName));
            }
        }
       
        public ICommand SubmittCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public CompanyNameViewModel(FirebaseAuthProvider firebaseAuthProvider, INavigationService NavigationService, INavigationService loginnavigationService)
        {
            SubmittCommand = new RegisterCompanyCommand(this, firebaseAuthProvider, loginnavigationService);
            NavigateLoginCommand = new NavigateCommand(NavigationService);
        }
    }
}
