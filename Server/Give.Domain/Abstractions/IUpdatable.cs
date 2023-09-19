namespace Give.Domain.Abstractions
{
    public interface IUpdatable : ICreateable
    {
        DateTime UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}
