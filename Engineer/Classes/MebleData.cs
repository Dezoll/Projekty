using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineer.Classes
{
    [FirestoreData]
    internal class MebleData
    {
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
       // public string Description { get; set; }
       // [FirestoreProperty]
        public string Type { get; set; }
        [FirestoreProperty]
      
        public string Color { get; set; }
        [FirestoreProperty]
        //public Bitmap Image { get; set; }
        //[FirestoreProperty]

        public int Value { get; set; }
        




    }
}
