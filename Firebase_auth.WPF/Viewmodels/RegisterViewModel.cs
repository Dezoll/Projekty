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
using System.Windows.Data;
using System.Windows.Input;

namespace Firebase_auth.WPF.Viewmodels
{
	public class RegisterViewModel : ViewModelBase
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

		private string _username;
		public string Username
		{
			get { return _username; }
			set
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
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



		private string _confirmPassword;
		public string ConfirmPassword
		{
			get { return _confirmPassword; }
			set
			{
				_confirmPassword = value;
				OnPropertyChanged(nameof(ConfirmPassword));
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
		public ICommand NavigateLoginCommand { get; }

		public ICommand NavCompanyName {  get; }
		//public INavigationService CompanynavigationService { get; }


        public RegisterViewModel(FirebaseAuthProvider firebaseAuthProvider, INavigationService loginNavigationService, INavigationService CompanynavigationService)
		{
			SubmitCommand = new RegisterCommand(this, firebaseAuthProvider, CompanynavigationService);
			NavigateLoginCommand = new NavigateCommand(loginNavigationService);
			//NavCompanyName = new NavigateCommand(CompanynavigationService);
		}
	}
}
