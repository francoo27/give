namespace Give.Domain.Models
{
    public class Campaña : EntityBase
    {
        public string Name { get; set; }
        public Campaña(int id, DateTime createdDate, DateTime modifiedDate, string createdBy, string modifiedBy, string name)
            : base(id, createdDate, modifiedDate, createdBy, modifiedBy)
        {
            Name = name;
        }
    }
}
