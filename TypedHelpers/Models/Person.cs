namespace TypedHelpers.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Password { get; set; } = "";
        public bool IsMaried { get; set; }
        public Country Country { get; set; } = new Country();
        public List<string> Languages { get; set; } = new List<string>();
        public string Info { get; set; } = "";
    }
}
