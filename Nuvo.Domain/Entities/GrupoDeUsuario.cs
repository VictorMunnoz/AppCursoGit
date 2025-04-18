using System.ComponentModel.DataAnnotations;

namespace Nuvo.Domain.Entities
{
    public class GrupoDeUsuario
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100)]
        public required string Nombre { get; set; }

        public Guid TenantId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
