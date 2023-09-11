using System.ComponentModel.DataAnnotations;

namespace Give.Domain.Models
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public string ModifiedBy { get; set; }

        public EntityBase(int id, DateTime createdDate, DateTime modifiedDate, string createdBy, string modifiedBy)
        {
            Id = id;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
        }
    }
}
