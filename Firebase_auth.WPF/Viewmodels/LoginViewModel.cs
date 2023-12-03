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
	public class LoginViewModel : ViewModelBase
	{
		private string _email;
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
				OnPropertyChanged(nameof(Email));
			}
		}


		private string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

        private string _CompanyKey;

        public string CompanyKey
        {
            get { return _CompanyKey; }
            set
            {
                _CompanyKey = value;
                OnPropertyChanged(nameof(CompanyKey));
            }
        }
        public ICommand SubmitCommand { get; }

		public ICommand NavigateRegisterCommand { get; }

		public LoginViewModel(FirebaseAuthProvider firebaseAuthProvider, INavigationService registerNavigationService)
		{
			SubmitCommand = new LoginCommand(this, firebaseAuthProvider);
			NavigateRegisterCommand = new NavigateCommand(registerNavigationService);
		}

	}
}
