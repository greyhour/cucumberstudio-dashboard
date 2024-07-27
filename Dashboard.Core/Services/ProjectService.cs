using Dashboard.Data;
using Dashboard.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Core.Services
{
    public class ProjectService
    {
        AppDBContext dbContext = new AppDBContext();

        public async Task AddProject(Project project)
        {
            dbContext.Project.Add(project);
            await dbContext.SaveChangesAsync();
        }

        public Project GetProject(int id)
        {
            return dbContext.Project.Single(project => project.Id == id);
        }

        public async Task<List<Project>> GetAllProjects()
        {
            List<Project> projects = await dbContext.Project.AsNoTracking().ToListAsync();
            foreach (var project in projects)
            {
                List<TestGroup> testGroups = await dbContext.TestGroup.AsNoTracking().ToListAsync();

                foreach(TestType type in Enum.GetValues<TestType>())
                {
                    List<TestGroup> filteredTestGroups = testGroups.Where(g => g.TestType == type).ToList();
                    int totalTests = filteredTestGroups.Sum(g => g.TestCount);
                    project.TestGroups.Add(new TestGroup(type, totalTests));
                }
            }
            return projects;
        }
    }
}
