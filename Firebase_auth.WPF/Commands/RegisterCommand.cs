using Engineer.Classes;
using Firebase.Auth;
using Firebase_auth.WPF.Classes;
using Firebase_auth.WPF.Viewmodels;
using MVVMEssentials.Commands;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Google.Protobuf.WellKnownTypes;
using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks.Sources;
using MVVMEssentials.Services;
using System.Windows.Navigation;
using Firebase_auth.WPF.Views;
using System.Windows.Controls;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;

namespace Firebase_auth.WPF.Commands
{
    public class RegisterCommand : AsyncCommandBase
    {
        // odpowiada za rejestracje uzytkownika
        // bierze wszystkie dane ktore uzytkownik podał w widoku
        private readonly RegisterViewModel _registerViewModel;

        private readonly FirebaseAuthProvider _firebaseAuthProvider;
        private readonly string _userId;
        private RegisterViewModel registerViewModel;
        private FirebaseAuthProvider firebaseAuthProvider;
        private CompanyNameViewModel _CompanyNameViewModel;
        private CompanyNameView _CompanyNameView;
        private string _companykey;
        private readonly INavigationService _navigationService;

        
        public RegisterCommand(RegisterViewModel registerViewModel, FirebaseAuthProvider firebaseAuthProvider, INavigationService navigationService)
        {
            this._registerViewModel = registerViewModel;
            this._firebaseAuthProvider = firebaseAuthProvider;
            this._navigationService = navigationService;
        }
        private CompanyKeyInfo MakeCompanyKey(string y)
        {
            return new CompanyKeyInfo()
            {
                CompanyKey = y,
            };
        }
        private CompanyData GetWriteData(string name, string x, string y)
		{
			MessageBox.Show( name.ToString() + x.ToString()+ y.ToString());
            return new CompanyData()
            {
                Username = name,
                Email = x,
                CompanyKey = y,
			};
		}
        private UserId MakeUserKey(string userid)
        {
            return new UserId()
            {
                Id = userid,
            };
        }
        protected override async Task ExecuteAsync(object parameter)
        {
            string name = _registerViewModel.Username;
            string password = _registerViewModel.Password;
            string cofnirmpassword = _registerViewModel.ConfirmPassword;
            string companykey = _registerViewModel.CompanyKey;
            App.Klucz = companykey;

            if (password != cofnirmpassword) 
            {
                MessageBox.Show("Hasla nie sa takie same");
                return;
            }
            try
            {
                var UserInfo = await _firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(
               _registerViewModel.Email, password, _registerViewModel.Username);
                string userId = UserInfo.User.LocalId;
                // ponizej przekazanie userId do drugiej klasy o nazwie RegisterCompanyCommand
                var registerCompanyCommand = new RegisterCompanyCommand(_CompanyNameViewModel, _firebaseAuthProvider, _navigationService);

                MessageBox.Show(userId);

                var mail = _registerViewModel.Email;
                var kluczFirmy = _registerViewModel.CompanyKey;
				var db = FirestoreHelper.Database;
                var data = GetWriteData(name, mail, kluczFirmy);
                var companyKeyData = MakeCompanyKey(kluczFirmy);
                var userIdData = new UserId { Id = userId };
                Google.Cloud.Firestore.DocumentReference CompanyKey = db.Collection("companies").Document(kluczFirmy);
                //jezeli klucz nie istnieje podajesz nazwe firmy i sprawdzasz czy nazwa firmy juz istnieje 
                var snapshot = await CompanyKey.GetSnapshotAsync();
                if (snapshot.Exists == false) //jezeli CompanyKey nie istnieje to go dopisz i dodaj nazwe firmy w kolejnym widoku (Navigate)
                {
                    // jezeli nie istnieje to trzeba nadać nazwe firmy oraz stworzyc ten klucz.
                    await CompanyKey.SetAsync(companyKeyData);
                    //ParameterNavigationService<string, CompanyNameViewModel> 
                    _navigationService.Navigate();

                }
                Google.Cloud.Firestore.CollectionReference kolorListCollection = CompanyKey.Collection("KolorList");
                Google.Cloud.Firestore.CollectionReference usersCollection = CompanyKey.Collection("users");
                Google.Cloud.Firestore.DocumentReference userDoc = usersCollection.Document(userIdData.Id);
                // JEST POPRAWNIEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE (mozna dzialac elegancko)
                await userDoc.SetAsync(data);

                try
                {
                    var kolorListDocuments = await kolorListCollection.ListDocumentsAsync().ToListAsync();
                    if (kolorListDocuments.Count == 0) // sprawdzenie czy dokument zawiera dane (jezeli nie zawiera to nie istnieje)
                    {
                        await kolorListCollection.AddAsync(new { });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking or creating KolorList collection: {ex.Message}");
                    throw;
                }
               // await usersCollection.AddAsync(data); //tworzenie kolekcji users(pustej)
                Google.Cloud.Firestore.CollectionReference users = db.Collection("users"); // odwolanie do pustej kolekcji stworzonej linijke wyzej
                await users.AddAsync(userIdData); //dodanie userID do kolekcji "users"

                Google.Cloud.Firestore.DocumentReference docref = db.Collection("users").Document(userId); // wczytanie dokumentu od funkcji MakeUserKey()
                await docref.SetAsync(data); // dodawanie danych uzytkownika do tabeli users (tej nie w kolekcji companies)
                MessageBox.Show("pomyslnie zarejestrowano");



            }
            catch (Exception ex)
            {

                if(ex.Message.Contains("EMAIL_EXISTS"))
                {
                    MessageBox.Show("Adres e-mail jest już w użyciu.");
                    return;
                }
                MessageBox.Show("rejestracja nie powiodla sie");

            }
           
        }

       
    }
}
