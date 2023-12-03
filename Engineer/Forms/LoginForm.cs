using Engineer.Classes;
using Engineer.Forms;
using Google.Cloud.Firestore;
using Google.Type;
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
    public partial class LoginForm : Rozdzielczosc_cfg
    {
        
        int liczba = 0;
        int liczba2 = 0;
        public static string kluczFirmy; // sesja XD
        public static string _userid;
        public LoginForm(string parameter, string userid)
        {
           
            InitializeComponent();
            kluczFirmy = parameter;
            _userid = userid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(kluczFirmy);
            MessageBox.Show(_userid);
            Dane();
        }
        private async void Dane()
        {
            // Assuming this method is an event handler or an async entry point in your Windows Forms application.
            FirestoreHelper.SetEnvironmentVariable();
            var db = FirestoreHelper.Database;
            Google.Cloud.Firestore.DocumentReference CompanyKey = db.Collection("companies").Document(kluczFirmy);
            Google.Cloud.Firestore.CollectionReference usersCollection = CompanyKey.Collection("users");
            Google.Cloud.Firestore.DocumentReference userDoc = usersCollection.Document(_userid);

            var usersnapshot = await userDoc.GetSnapshotAsync();

            string GetCompanyKey = usersnapshot.GetValue<string>("Username");
            MessageBox.Show(GetCompanyKey);

            // Now you can use GetCompanyKey in your Windows Forms application.
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hide();
            Dodaj f = new Dodaj();
            f.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

       

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if(liczba == 0)
            {
                Login_TB.Clear();
                liczba++;
            }
            else
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (liczba2 == 0)
            {
                Haslo_TB.Clear();
                liczba2++;
            }
            else
            {

            }
        }

        private void Rejestracja_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
            Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Login = Login_TB.Text.Trim();
            string Haslo = Haslo_TB.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(Login);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if(data != null)
            {
                if(Haslo == data.Password)
                {
                    MessageBox.Show("udalo sie!");

                }
                else 
                {
                    MessageBox.Show("NIE udalo sie!");
                }
            }
            else
            {
                MessageBox.Show("NIE udalo sie!");

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dopasuj x = new Dopasuj();
            x.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kwadraty x = new Kwadraty();
            x.ShowDialog();
            this.Hide();
        }
    }
}
