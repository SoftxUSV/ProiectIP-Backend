
using Microsoft.EntityFrameworkCore;

namespace ProiectIP.Models.Repositories
{
    public class SpecializationRepository : Repository<SpecializationModel>, ISpecializationRepository
    {
        public SpecializationRepository(ExamSchedulingDbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<SpecializationModel>> GetSpecializationsByFacultyAsync(int facultyId)
        {
            return await _dbContext.Specializations
                .Where(s => s.FacultyId == facultyId)
                .Include(s => s.Groups) // Include groups if needed
                .ToListAsync();
        }
    }
}
