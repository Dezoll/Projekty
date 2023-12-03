using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase_auth.WPF.Classes
{

    [FirestoreData]
    internal class CompanyData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]

        public string Email { get; set; }
        [FirestoreProperty]

        public string CompanyKey { get; set; }


    }
}
