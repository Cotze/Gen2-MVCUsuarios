using System;
using System.ComponentModel.DataAnnotations;

namespace Gen2_MVCUsuarios.Models
{
    public class Usuarios
    {
        //DataAnnotation
        //Metadato
        //Datos de Datos
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El apellido paterno es obligatorio")]
        [StringLength(20)]
        [Display(Name ="Apellido Paterno")]
        public string ApPaterno { get; set; }

        [Required(ErrorMessage ="El apellido materno es obligatorio")]
        [StringLength(20)]
        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }

        [Required(ErrorMessage ="El telefono es obligatorio")]
        [MaxLength(15)]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="Email es obligatoriao")]
        [EmailAddress(ErrorMessage ="Direcciónde correo invalido")]
        public string Correo { get; set; }

        [Required(ErrorMessage ="Fecha de nacimiento es obligatoria")]
        [Display(Name ="Fecha de nacimiento")]
        public DateTime FechaNac { get; set; }

        [Required(ErrorMessage ="Dirección de usuario es obligatoria")]
        public string Direccion { get; set; }
    }
}
