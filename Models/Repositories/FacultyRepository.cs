
using Microsoft.EntityFrameworkCore;

namespace ProiectIP.Models.Repositories
{
    public class FacultyRepository : Repository<FacultyModel>, IFacultyRepository
    {
        public FacultyRepository(ExamSchedulingDbContext dbContext) : base(dbContext) {}

        public async Task<IEnumerable<FacultyModel>> GetFacultiesWithSpecializationAsync()
        {
            return await _dbContext.Faculties.Include(f => f.Specializations).ToListAsync();
        }
    }
}
