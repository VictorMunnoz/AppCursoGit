using System.ComponentModel.DataAnnotations;

namespace Nuvo.Domain.Entities
{

    //Se agrega comentario: Víctor Gallegos 21/05/1993
    internal class Usuario
    {
        [Key]     
        public Guid Id { get; set; }

        [StringLength(300)]
        [Required]
        public required string Nombre { get; set; }

        [StringLength(300)]
        [Required]
        public required string Apellido { get; set; }

        [StringLength(300)]
        [Required]
        public required string NombreDeUsuario { get; set; }

        [StringLength(300)]
        public string? Puesto { get; set; }

        //TODO: ESTA PROPIEDAD ES LA RELACION CON TETANT
        public Guid TenantId { get; set; }

        public string GetInfo() => $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} NombreDeUsuario: {NombreDeUsuario}";
    }
}
