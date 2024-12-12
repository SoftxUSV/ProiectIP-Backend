namespace ProiectIP.Models
{
    public class FacultySpecializationsViewModel
    {
        public FacultyModel Faculty { get; set; }
        public IEnumerable<SpecializationModel> Specializations { get; set; }
    }
}
