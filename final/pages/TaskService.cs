namespace DemoDotnet8BlazorQuickGrid.Pages
{
    public class TaskService
    {
        public Dictionary<int, List<TaskDetail>> ProjectTasks { get; set; } = new();

        public List<TaskDetail> GetTasks(int projectId)
        {
            if (!ProjectTasks.ContainsKey(projectId))
            {
                ProjectTasks[projectId] = new List<TaskDetail>();
            }
            return ProjectTasks[projectId];
        }
    }

    public class TaskDetail
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TeamsAssigned { get; set; }
        public string Progress { get; set; }
        public bool IsEditing { get; set; } = false;
    }

}
