using Give.Domain.Abstractions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Give.Domain.Models
{
    public abstract class EntityBase : IUpdatable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        [Required]

        [AllowNull]
        public string? UpdatedBy { get; set; }

        [AllowNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedDate { get; set; }

        public EntityBase(int id, string createdBy, DateTime createdDate, string? updatedBy, DateTime? updatedDate)
    {
            Id = id;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
        }
    }
}
