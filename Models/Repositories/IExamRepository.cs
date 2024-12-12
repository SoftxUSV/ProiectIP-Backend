namespace ProiectIP.Models.Repositories
{
    public interface IExamRepository : IRepository<ExamModel>
    {
        Task<IEnumerable<ExamModel>> GetExamsByGroupAsync(int groupId);
    }
}
