using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase_auth.WPF.Classes
{
    [FirestoreData]
    class CompanyKeyInfo
    {
        [FirestoreProperty]

        public string CompanyKey { get; set; }

    }
}
