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
    public class FireStoreManager
    {
        private const string FIREBASE_PROJID = "oop-web-43901";
        private FirestoreDb _firestoreDb;
        //public string Login {  get; set; }

        public FireStoreManager(string projectId)
        {
            projectId = FIREBASE_PROJID;
            _firestoreDb = FirestoreDb.Create(projectId);
        }

        /*public void initFirestore()
        {
            FirebaseApp.Create();
            _firestoreDb = FirestoreDb.Create(FIREBASE_PROJID);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }*/

        //save data
        public async System.Threading.Tasks.Task SaveProjects(Project project, Dictionary<string, object> value)
        {
            CollectionReference collectionRef = _firestoreDb.Collection("project");
            DocumentReference docref = collectionRef.Document(project.Name.ToString());

            Dictionary<string, object> values = new Dictionary<string, object> 
            {
                { "Project.Name", project.Name}
            };

            await docref.SetAsync(value);
        }

        //restore data
        public async Task<Dictionary<string, object>> RestoreProjects(string project, string projectName)
        {
            DocumentReference docref = _firestoreDb.Collection("project").Document(projectName);
            DocumentSnapshot snapshot = await docref.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ToDictionary();
            }
            else
            {
                return null;
            }
        }
    }
}
