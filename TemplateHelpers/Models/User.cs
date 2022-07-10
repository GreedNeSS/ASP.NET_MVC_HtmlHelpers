namespace TemplateHelpers.Models
{
    public record class User(string Name, int Age)
    {
        public Guid Id { get; set; }
    }
}
