using Dashboard.Data;
using Dashboard.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Core.Services
{
    public class TestGroupService
    {
        AppDBContext dbContext = new AppDBContext();

        public async Task AddTestGroup(TestGroup testGroup)
        {
            dbContext.TestGroup.Add(testGroup);
            await dbContext.SaveChangesAsync();
        }

        public TestGroup GetTestGroup(int id)
        {
            return dbContext.TestGroup.Single(testGroup => testGroup.Id == id);
        }

        public async Task<List<TestGroup>> GetAllTestGroups()
        {
            return await dbContext.TestGroup.AsNoTracking().ToListAsync();
        }
    }
}
