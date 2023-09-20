namespace Give.Service.Dtos
{
    public abstract class EntityBaseDto
    {
        public virtual int? Id { get; set; }
        public virtual string? CreatedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual string? UpdatedBy { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }

    }
}