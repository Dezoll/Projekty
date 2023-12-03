using Engineer.Classes;
using FireSharp;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineer
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();

        }
        private UserData GetWriteData()
        {
            string Login = TBR1.Text.Trim();
            string Haslo = TBR2.Text.Trim();
           // string Powtorz = TBR3.Text.Trim();
           // dodac warunek ze jezeli haslo nie rowne powtorz to zeby pokazywalo ze musza sie zgadzac
                return new UserData()
                {
                    Username = Login,
                    Password = Haslo,
                };
        }
        private void Zaloguj_Click(object sender, EventArgs e)
        { 
            var db = FirestoreHelper.Database;
            if (CzyIstniejeUser())
            {
                MessageBox.Show("uzytkownik juz istnieje");
                return;
            }
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("udalo sie!");

            MessageBox.Show(data.Username + data.Password);

            /*
                        CollectionReference coll = database.Collection("Uzytkownicy");
                        Dictionary<string, object> data1 = new Dictionary<string, object>()
                        {
                            {"Login", Login },
                            {"Haslo", Haslo}
                        };
                        coll.AddAsync(data1);
                        MessageBox.Show("dane dodano poprawnie :)");
            */
        }
        private bool CzyIstniejeUser()
        {
            string Login = TBR1.Text.Trim();
            

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(Login);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TBR1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBR2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
