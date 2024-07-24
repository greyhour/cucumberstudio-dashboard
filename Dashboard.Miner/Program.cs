using Dashboard.Data.Data;
using Dashboard.Core.Services;

namespace Dashboard.Miner
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ProjectService projectService = new ProjectService();

            Project project = new Project();
            project.Name = "Test";
            project.ForeignId = 12642325;

            await projectService.AddProject(project);
        }
    }
}
