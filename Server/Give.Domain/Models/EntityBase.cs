using Give.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Give.Domain.Models
{
    public abstract class EntityBase : IUpdatable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        public EntityBase(int id, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate)
        {
            Id = id;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
        }
    }
}
