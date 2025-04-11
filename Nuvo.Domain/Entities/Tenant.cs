using System.ComponentModel.DataAnnotations;

namespace Nuvo.Domain.Entities
{
    public class Tenant
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(200)]
        public required string Nombre { get; set; }
    }
}
