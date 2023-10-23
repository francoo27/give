namespace Give.Domain.Abstractions
{
    public interface ICreateable : IIdentifiable
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
    }
}
