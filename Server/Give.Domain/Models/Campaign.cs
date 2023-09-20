namespace Give.Domain.Models
{
    public sealed class Campaign : EntityBase
    {
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
        public string State { get; set; }
        public Campaign(int id, string createdBy, DateTime createdDate,string updatedBy, DateTime updatedDate,
            string name, DateTime launchDate)
            : base(id, createdBy, createdDate, updatedBy, updatedDate)
        {
            Name = name;
            LaunchDate = launchDate;
            State = (LaunchDate.Date == DateTime.Now.Date) ? CampaignState.Active : CampaignState.Inactive;
        }


        public static class CampaignState
        {
            public static readonly string Inactive = "INACTIVE";
            public static readonly string Active = "ACTIVE";
            public static readonly string PendingModeration = "PENDING_MODERATION";
            public static readonly string AuditReview = "AUDIT_REVIEW";
            public static readonly string Rejected = "REJECTED";
            public static readonly string Banned = "BANNED";
            public static readonly string Incomplete = "INCOMPLETE";
            public static readonly string Deleted = "DELETED";
            public static readonly string Completed = "COMPLETED";
        }


        private bool TransitionTo(string newState)
        {
            State = newState;
            return true;
        }

        public bool PauseCampaign() => (State == CampaignState.Active) ? TransitionTo(CampaignState.Inactive) : false;

        public bool StartModeration() => (State == CampaignState.Inactive || State == CampaignState.Active) ? TransitionTo(CampaignState.PendingModeration) : false;

        public bool ReviewCampaign(bool approved, bool banned, bool incomplete) =>
            (State == CampaignState.PendingModeration) ?
                (approved ? TransitionTo(CampaignState.Active) :
                 banned ? TransitionTo(CampaignState.Banned) :
                 incomplete ? TransitionTo(CampaignState.Incomplete) :
                 TransitionTo(CampaignState.Rejected)) : false;

        public bool ResumeCampaign() => (State == CampaignState.AuditReview) ? TransitionTo(CampaignState.Active) : false;

        public bool DeleteCampaign() => (State == CampaignState.Active) ? TransitionTo(CampaignState.Deleted) : false;

        public bool CompleteCampaign() => (State == CampaignState.Active) ? TransitionTo(CampaignState.Completed) : false;


    }
}
