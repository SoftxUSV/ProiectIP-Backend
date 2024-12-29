
using Microsoft.EntityFrameworkCore;

namespace ProiectIP.Models.Repositories
{
    public class ExamRepository : Repository<ExamModel>, IExamRepository
    {
        public ExamRepository(ExamSchedulingDbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<ExamModel>> GetExamsByGroupAsync(int groupId)
        {
            return await _dbContext.Exams
            .Where(e => e.GroupId == groupId)
            .ToListAsync();
        }
    }
}
