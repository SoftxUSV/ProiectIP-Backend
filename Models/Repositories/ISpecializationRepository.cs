namespace ProiectIP.Models.Repositories
{
    public interface ISpecializationRepository : IRepository<SpecializationModel>
    {
        Task<IEnumerable<SpecializationModel>> GetSpecializationsByFacultyAsync(int facultyId);
    }
}
