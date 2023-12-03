using Engineer.Classes;
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
    public partial class Dodaj : Form
    {
        private FirestoreDb database;
        public Dodaj()
        {
            InitializeComponent();
            
           // FirestoreHelper.SetEnvironmentVariable();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void CenaL_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {


            // Dokument_dodany_autoID();

            Dodajelement();
            
        }

        private void Dodaj_Load(object sender, EventArgs e)
        {
            
        }

        //void Dokument_dodany_autoID()
        //{
        //    string Nazwa = NazwaTB.Text;
        //    string Cena = CenaTB.Text;
        //    CollectionReference coll = database.Collection("Dokument_dodany_autoID");
        //    Dictionary<string, object> data1 = new Dictionary<string, object>()
        //    {
        //        {"Nazwa", Nazwa },
        //        {"Cena", Cena}
        //    };
        //    coll.AddAsync(data1);
        //    MessageBox.Show("dane dodano poprawnie :)");
        //}


        private MebleData GetWriteData()
        {

            string Nazwa = NazwaTB.Text.Trim();
            int Cena = int.Parse(CenaTB.Text); 
            string Rodzaj = RodzajTB.Text.Trim();
            string Kolor = KolorTB.Text.Trim();
           
            return new MebleData()
            {
                Name = Nazwa,
                Value = Cena,
                Type = Rodzaj,
                Color = Kolor
             
            };
        }


        //private bool CzyIstniejeKomponent()
        //{
        //    string Nazwa = NazwaTB.Text.Trim();
        //    string Rodzaj = RodzajTB.Text.Trim();
        //    string Kolor = KolorTB.Text.Trim();

        //    var db = FirestoreHelper.Database;
        //    DocumentReference docRef = db.Collection("UserData").Document(Nazwa + "_" + Rodzaj + "_" + Kolor);
        //    MebleData data = docRef.GetSnapshotAsync().Result.ConvertTo<MebleData>();

        //    if (Nazwa != null && Rodzaj != null && Kolor != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        void Dodajelement()
        {
            var db = FirestoreHelper.Database;
            //if (CzyIstniejeKomponent())
            //{
            //    MessageBox.Show("Podaj wszystkie dane");
            //    return;
            //}
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("MeblePRO").Document(data.Name+"_"+data.Type+"_"+data.Color);
            docRef.SetAsync(data);
            MessageBox.Show(data.Name + "_" + data.Type + "_" + data.Color);
           
            
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}