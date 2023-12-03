using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase_auth.WPF.Classes
{
    [FirestoreData]
    class CompanyNameInfo
    {
        [FirestoreProperty]
        public string CompanyName { get; set; }
    }
}
