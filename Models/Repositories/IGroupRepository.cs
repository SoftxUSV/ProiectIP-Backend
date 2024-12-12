namespace ProiectIP.Models.Repositories
{
    public interface IGroupRepository : IRepository<GroupModel>
    {
        Task<IEnumerable<GroupModel>> GetGroupsBySpecializationAsync(int specializationId);
    }
}
