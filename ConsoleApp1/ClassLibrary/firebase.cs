
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebaseAdmin;
using Google.Cloud.Firestore;

namespace ClassLibrary
{
    public class FirebaseService
    {
        private const string FIREBASE_PROJID = "project-oop2";
        private FirestoreDb db;

        public async Task InitFirestoreAsync()
        {
            FirebaseApp.Create();
            db = FirestoreDb.Create(FIREBASE_PROJID);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }

        public async Task SaveProjectAsync(Project project)
        {
            CollectionReference collectionRef = db.Collection("projects");
            DocumentReference docRef = collectionRef.Document(project.Name);
            Dictionary<string, object> projectData = new Dictionary<string, object>
            {
                { "Description", project.Description },
                { "Cost", project.Cost },
                { "Date", project.Date } // Date is in UTC
            };
            await docRef.SetAsync(projectData);
        }

        public async Task SaveTaskAsync(ProjectTask task)
        {
            CollectionReference collectionRef = db.Collection("tasks");
            DocumentReference docRef = collectionRef.Document(task.TaskName);
            Dictionary<string, object> taskData = new Dictionary<string, object>
            {
                { "TaskDescription", task.TaskDescription },
                { "Status", task.Status.ToString() },
                { "AssignedDate", task.AssignedDate }, // AssignedDate is in UTC
                { "AssignedTo", task.TeamMember?.memberName }
            };
            await docRef.SetAsync(taskData);
        }

        public async Task GetProjectsAsync()
        {
            CollectionReference collectionRef = db.Collection("projects");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            Console.WriteLine("\nProjects in Firebase:");
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Console.WriteLine($"Project Name: {document.Id}");
                Console.WriteLine($"Description: {document.GetValue<string>("Description")}");
                Console.WriteLine($"Cost: {document.GetValue<double>("Cost")}");
                Console.WriteLine($"Date: {document.GetValue<Timestamp>("Date").ToDateTime()}");
                Console.WriteLine();
            }
        }

        public async Task GetTasksAsync()
        {
            CollectionReference collectionRef = db.Collection("tasks");
            QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

            Console.WriteLine("\nTasks in Firebase:");
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Console.WriteLine($"Task Name: {document.Id}");
                Console.WriteLine($"Description: {document.GetValue<string>("TaskDescription")}");
                Console.WriteLine($"Status: {document.GetValue<string>("Status")}");
                Console.WriteLine($"Assigned Date: {document.GetValue<Timestamp>("AssignedDate").ToDateTime()}");
                Console.WriteLine($"Assigned To: {document.GetValue<string>("AssignedTo")}");
                Console.WriteLine();
            }
        }
    }
}

