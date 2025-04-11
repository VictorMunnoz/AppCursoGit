using System.ComponentModel.DataAnnotations;

namespace Nuvo.Domain.Entities
{

    //Se agrega comentario: Víctor Gallegos
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

        public string GetInfo() => $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} NombreDeUsuario: {NombreDeUsuario}";
    }
}
