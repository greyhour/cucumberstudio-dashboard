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
            TestGroupService testGroupService = new TestGroupService();

            Project project = new Project();
            project.ForeignId = 12642325;
            project.Name = "Project 1";
            await projectService.AddProject(project);

            TestRun testRun = new TestRun();
            testRun.ProjectId = project.Id;
            testRun.ForeignId = 1541542315;
            testRun.Name = "Test Run 1";
            await testRunService.AddTestRun(testRun);

            TestGroup testGroupOne = new TestGroup();
            testGroupOne.TestRunId = testRun.Id;
            testGroupOne.TestType = TestType.Passed;
            testGroupOne.TestCount = 8;
            await testGroupService.AddTestGroup(testGroupOne);

            TestGroup testGroupTwo = new TestGroup();
            testGroupTwo.TestRunId = testRun.Id;
            testGroupTwo.TestType = TestType.Failed;
            testGroupTwo.TestCount = 4;
            await testGroupService.AddTestGroup(testGroupTwo);

            TestGroup testGroupThree = new TestGroup();
            testGroupThree.TestRunId = testRun.Id;
            testGroupThree.TestType = TestType.Other;
            testGroupThree.TestCount = 2;
            await testGroupService.AddTestGroup(testGroupThree);


            // https://studio.cucumber.io/api/projects/<project_id>/test_runs/<test_run_id>
        }
    }
}
