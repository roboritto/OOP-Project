using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseAdmin;
using Google.Cloud.Firestore;
using ClassLibrary;

namespace OOPAliya
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FirebaseService firebaseService = new FirebaseService();
            await firebaseService.InitFirestoreAsync();

            Console.WriteLine("1. Project Details");
            Console.WriteLine("2. Task Details");
            Console.WriteLine("3. Team Details");
            Console.WriteLine("4. Team Members Details");

            Console.Write("Please choose: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter The Project Details:");

                    string name;
                    while (true)
                    {
                        Console.Write("Project Name: ");
                        name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Error: Project name cannot be empty. Please try again.");
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Cost: ");
                    double cost;
                    while (!double.TryParse(Console.ReadLine(), out cost))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid cost.");
                        Console.Write("Cost: ");
                    }

                    DateTime date = DateTime.UtcNow; // Convert to UTC
                    Project project = new Project(name, description, cost, date);

                    await firebaseService.SaveProjectAsync(project);

                    Console.WriteLine("\nYour Project Details have been saved to Firebase.");
                    Console.WriteLine("Retrieving saved projects...");
                    await firebaseService.GetProjectsAsync();
                    break;

                case "2":
                    string taskName;
                    string taskDescription;
                    DateTime assignedDate = DateTime.UtcNow; // Convert to UTC

                    while (true)
                    {
                        Console.Write("Enter task name: ");
                        taskName = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(taskName))
                        {
                            Console.WriteLine("Error: Task name cannot be empty. Please try again.");
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.Write("Enter task description: ");
                    taskDescription = Console.ReadLine();

                    ProjectTask task = new ProjectTask(taskName, taskDescription, assignedDate);

                    Console.Write("Enter team member's name to assign the task: ");
                    string memberName = Console.ReadLine();
                    TeamMember teamMember = new TeamMember(memberName);
                    task.AssignTo(teamMember);

                    await firebaseService.SaveTaskAsync(task);

                    Console.WriteLine("\nTask Details have been saved to Firebase.");
                    Console.WriteLine("Retrieving saved tasks...");
                    await firebaseService.GetTasksAsync();
                    break;

                case "3":
                    Team team = new Team();
                    string confirmation;

                    while (true)
                    {
                        Console.Write("Enter the team name: ");
                        team.Name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(team.Name))
                        {
                            Console.WriteLine("Error: Team name cannot be empty. Please try again.");
                            continue;
                        }

                        Console.WriteLine($"You entered: {team.Name}");
                        Console.Write("Is this correct? (Y/N): ");
                        confirmation = Console.ReadLine().ToLower();

                        if (confirmation == "y")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter your team name again");
                        }
                    }

                    Console.WriteLine($"Team name confirmed: {team.Name}");
                    break;

                case "4":
                    bool addition = true;
                    do
                    {
                        TeamMember teamMemberDetails = new TeamMember();

                        Console.Write("Name: ");
                        teamMemberDetails.memberName = Console.ReadLine();
                        Console.Write("Role: ");
                        teamMemberDetails.memberRole = Console.ReadLine();
                        Console.Write("Email: ");
                        teamMemberDetails.memberEmail = Console.ReadLine();

                        Console.WriteLine("Your Team details:");
                        Console.WriteLine(teamMemberDetails.GetMemberDetails());
                        Console.Write("Do you want to add more Team Members? (Y/N): ");
                        string response = Console.ReadLine().ToLower();

                        addition = response == "y";

                    } while (addition);

                    break;
            }

            await Task.CompletedTask;
        }
    }
}



