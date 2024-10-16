using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace ClassLibrary
{
    public class Index
    {
        private const string FIREBASE_PROJID = "oop-web-43901";
        private FirestoreDb db;
        public string Login {  get; set; }

        public Index() {}

        public void initFirestore()
        {
            FirebaseApp.Create();
            db = FirestoreDb.Create(FIREBASE_PROJID);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }

        public async System.Threading.Tasks.Task SaveProject(Project project)
        {
            CollectionReference collectionRef = db.Collection("project");
            DocumentReference docref = collectionRef.Document(project.Name.ToString());

            Dictionary<string, object> value = new Dictionary<string, object>
            {
                {"Name", project.Name.ToString() }

            };

            await docref.SetAsync(value);
        }
    }
}
