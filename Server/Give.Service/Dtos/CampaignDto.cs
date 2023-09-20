namespace Give.Service.Dtos
{
    public class CampaignDto : EntityBaseDto
    {
        public virtual string? Name { get; set; }
        public virtual DateTime? LaunchDate { get; set; }
        public virtual string? State { get; set; }
        public CampaignDto()
        {
        }
    }
}
