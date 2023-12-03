using Firebase.Auth;
using Firebase_auth.WPF.Viewmodels;
using MVVMEssentials.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Engineer;
using System.Windows.Interop;
using System.Diagnostics;
using MVVMEssentials.Services;
using Engineer.Classes;
using Google.Cloud.Firestore;
using System.Printing;
using System.ComponentModel.Design;
using Google.Cloud.Firestore.V1;
using static Grpc.Core.Metadata;
using Firebase_auth.WPF.Views;
using System.Windows.Navigation;

namespace Firebase_auth.WPF.Commands
{
    public class LoginCommand : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly FirebaseAuthProvider _firebaseAuthProvider;
        public LoginCommand(LoginViewModel loginViewModel, FirebaseAuthProvider firebaseAuthProvider)
        {
            _loginViewModel = loginViewModel;
            _firebaseAuthProvider = firebaseAuthProvider;
        }
        protected override  async Task ExecuteAsync(object parameter)
        {
            try
            {
                //kod danej firmy dodac do logowania
                var UserInfo = await _firebaseAuthProvider.SignInWithEmailAndPasswordAsync(_loginViewModel.Email, _loginViewModel.Password);
                //dany user istnieje ale trzeba go jeszcze sprawdzic do ktorej company nalezy XD
                string userId = UserInfo.User.LocalId;
                //najpierw czy companykey istnieje
                var db = FirestoreHelper.Database;
                var companykey = _loginViewModel.CompanyKey;
                Google.Cloud.Firestore.DocumentReference CompanyKey = db.Collection("companies").Document(companykey);
                Google.Cloud.Firestore.DocumentReference UserIdentify = db.Collection("users").Document(userId);
                var snapshot = await CompanyKey.GetSnapshotAsync();
                var usersnapshot = await UserIdentify.GetSnapshotAsync();
                if (snapshot.Exists == true)
                {
                    //dokoncz tu sprawdzanie czy companykey istnieje potem czy user jest w danej company i tak dalej
                    if (usersnapshot.Exists == true ) 
                    {
                        string GetCompanyKey = usersnapshot.GetValue<string>("CompanyKey");
                        if(GetCompanyKey == companykey) 
                        {
                            MessageBox.Show("Zalogowano.", "Logowanie");
                            App.Klucz = companykey;
                            Application.Current.MainWindow.Close();

                            var loginHandler = new Engineer.Classes.LoginFormHandler();
                            loginHandler.HandleLogin(App.Klucz, userId);

                            // LoginForm loginForm = new LoginForm(App.Klucz, userId);
                            //loginForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Blad.", "Sprawdz poprawnosc danch logowania");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Blad.", "Sprawdz poprawnosc danch logowania");
                    }                    
                }
                else
                {
                    MessageBox.Show("Blad.", "Sprawdz poprawnosc danch logowania");

                }
                /*  Google.Cloud.Firestore.DocumentReference CompanyKeys = db.Collection("companies").Document();
                  DocumentSnapshot doc = await CompanyKeys.GetSnapshotAsync();
                  var l = doc.Id;
                  MessageBox.Show(doc.Id);
                */
                // var collectionRef = db.Collection("companies");
                /*
                QuerySnapshot querySnapshot = await collectionRef.GetSnapshotAsync();
                
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    MessageBox.Show($"Document data for {documentSnapshot.Id} document:");

                    Dictionary<string, object> data = documentSnapshot.ToDictionary();

                    foreach (KeyValuePair<string, object> pair in data)
                    {
                        MessageBox.Show($"{pair.Key}: {pair.Value}");
                    }
                }
                */
                /*
                Query companies = y;
                QuerySnapshot proba = await companies.GetSnapshotAsync();
                foreach(  var companyKey in proba)
                {
                    var companyId = companyKey.Id;
                    MessageBox.Show($"Company ID: {companyId}");
                }
                */
                /*
                QuerySnapshot querySnapshot = await companies.GetSnapshotAsync();
                List<string> nonEmptyCompanyIds = new List<string>();

                MessageBox.Show($"Liczba dokumentów w kolekcji: {querySnapshot.Count}");

                foreach (var mainDocumentSnapshot in querySnapshot)
                {
                    if (mainDocumentSnapshot.ToDictionary().Any())
                    {
                        var companyId = mainDocumentSnapshot.Id;
                        nonEmptyCompanyIds.Add(companyId);
                        MessageBox.Show($"Company ID: {companyId}");
                    }


                }

                */
                /*
                                foreach (DocumentSnapshot mainDocumentSnapshot in querySnapshot.Documents)
                                {
                                    MessageBox.Show(mainDocumentSnapshot.Id);
                                }
                */
                //potem jak istnieje to przeszukać users czy jest dany mail
                // MessageBox.Show(_loginViewModel.CompanyKey);
            }
            catch (Exception)
            {
                MessageBox.Show("logowanie nie powiodlo sie. Sprawdz poprawnosc emaila oraz hasla.", "Blad");
                throw;
            }

           
        }
        
    }
}
