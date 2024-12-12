namespace ProiectIP.Models.Repositories
{
    public interface IFacultyRepository : IRepository<FacultyModel>
    {
        Task<IEnumerable<FacultyModel>> GetFacultiesWithSpecializationAsync();
    }
}
