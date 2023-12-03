using Engineer.Classes;
using Firebase.Auth;
using Firebase_auth.WPF.Classes;
using Firebase_auth.WPF.Viewmodels;
using Firebase_auth.WPF.Views;
using Google.Cloud.Firestore;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Firebase_auth.WPF.Commands
{
    public class RegisterCompanyCommand : AsyncCommandBase
    {
        private readonly CompanyNameViewModel _CompanyNameViewModel;
        private readonly FirebaseAuthProvider _firebaseAuthProvider;
        private readonly string _companyKey;
        private CompanyNameView companyNameView;
        private FirebaseAuthProvider firebaseAuthProvider;
        private readonly INavigationService _navigationService;


        public RegisterCompanyCommand(CompanyNameViewModel companyNameViewModel, FirebaseAuthProvider firebaseAuthProvider, INavigationService navigationService)
        {
            this._CompanyNameViewModel = companyNameViewModel;
            this._firebaseAuthProvider = firebaseAuthProvider;
            this._navigationService = navigationService;
        }
       
        
        private CompanyNameInfo MakeCompany(string companyname)
        {
            return new CompanyNameInfo()
            {
                CompanyName = companyname,
            };
        }

        private CompanyKeyInfo MakeKey(string cmpnykey)
        {
            return new CompanyKeyInfo()
            {
                 CompanyKey = cmpnykey,
            };
        }
        protected override async Task ExecuteAsync(object parameter)
        {
            var db = FirestoreHelper.Database;
            string companyname = _CompanyNameViewModel.CompanyName;
            string tomakekey = App.Klucz;
            CollectionReference path = db.Collection("companies");
            DocumentReference path2 = path.Document(App.Klucz);
            DocumentReference path3 = path.Document(App.Klucz);
          //  await path2.SetAsync(MakeKey(tomakekey));
            await path3.SetAsync(MakeCompany(companyname), SetOptions.MergeAll);
            _navigationService.Navigate();


        }
    }
}
