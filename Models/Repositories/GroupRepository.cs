
using Microsoft.EntityFrameworkCore;

namespace ProiectIP.Models.Repositories
{
    public class GroupRepository : Repository<GroupModel>, IGroupRepository
    {
        public GroupRepository(ExamSchedulingDbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<GroupModel>> GetGroupsBySpecializationAsync(int specializationId)
        {
            return await _dbContext.Groups
            .Where(g => g.SpecializationId == specializationId)
            .ToListAsync();
        }
    }
}
