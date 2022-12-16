namespace WebApplication13.Models
{
    public class Exam
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public string? GroupName { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
