namespace Give.Domain.Models
{
    public class Campaign : EntityBase
    {
        public string Name { get; set; }
        public Campaign(int id, DateTime createdDate, DateTime modifiedDate, string createdBy, string modifiedBy, string name)
            : base(id, createdDate, modifiedDate, createdBy, modifiedBy)
        {
            Name = name;
        }
    }
}
