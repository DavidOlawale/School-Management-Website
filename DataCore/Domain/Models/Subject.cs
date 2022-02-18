namespace DataCore.Models
{
    public class Subject
    {
        public Subject(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
