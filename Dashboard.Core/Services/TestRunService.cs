using Dashboard.Data;
using Dashboard.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Core.Services
{
    public class TestRunService
    {
        AppDBContext dbContext = new AppDBContext();

        public async Task AddTestRun(TestRun testRun)
        {
            dbContext.TestRun.Add(testRun);
            await dbContext.SaveChangesAsync();
        }

        public TestRun GetTestRun(int id)
        {
            return dbContext.TestRun.Single(testRun => testRun.Id == id);
        }

        public async Task<List<TestRun>> GetAllTestRuns()
        {
            return await dbContext.TestRun.AsNoTracking().ToListAsync();
        }
    }
}
