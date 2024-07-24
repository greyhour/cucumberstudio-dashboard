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
            TestRunService testRunService = new TestRunService();

            Project project = new Project();

            project.ForeignId = 12642325;
            project.Name = "Project 1";

            await projectService.AddProject(project);




            TestRun testRun = new TestRun();

            testRun.ProjectId = project.Id;
            testRun.ForeignId = 1541542315;
            testRun.Name = "Test Run 1";
            testRun.PassedTests = 6;
            testRun.FailedTests = 5;
            testRun.OtherTests = 0;

            await testRunService.AddTestRun(testRun);
        }
    }
}
