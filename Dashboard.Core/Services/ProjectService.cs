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
            return await dbContext.Project.AsNoTracking().ToListAsync();
        }
    }
}
