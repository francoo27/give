namespace Give.Domain.Models
{
    public class Campaign : EntityBase
    {
        public string Name { get; set; }
        public Campaign(int id, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate, string name)
            : base(id, createdBy, createdDate, updatedBy, updatedDate)
        {
            Name = name;
        }
    }
}
