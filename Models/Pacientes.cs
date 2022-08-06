using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestProyecto1.Models
{
    public class Pacientes
    {
        //este modelo representa la tabla Pacientes en la base de datos

        //propiedades con data annotations 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero de cedula del paciente")]
        [StringLength(8, MinimumLength = 1, ErrorMessage = "8 caracteres maximo.")]
        [Display(Name = "Cedula")]
        public string CedulaPaciente { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre del paciente")]
        [Display(Name = "Nombre del paciente")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe incluir el primer apellido del paciente")]
        [Display(Name = "Primer Apellido")]
        public string Apellido1 { get; set; }

        [Required(ErrorMessage = "Debe incluir el primer apellido del paciente")]
        [Display(Name = "Segundo Apellido")]
        public string Apellido2 { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public string Nacimiento { get; set; }

        [Required(ErrorMessage = "Debe incluir el sexo natural del paciente")]
        [Display(Name = "Sexo Natural")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero telefonico de un contacto paciente")]
        [Display(Name = "Numero de contacto")]
        [Phone]
        public string NumContacto { get; set; }

        [Required(ErrorMessage = "Debe incluir el pais de donde reside el paciente")]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Debe incluir la provincia donde reside el paciente")]
        [Display(Name = "Provincia")]
        public string Provincia { get; set; }

        [Display(Name = "Distrito (opcional)")]
        public string? Distrito { get; set; }

        [Required(ErrorMessage = "Debe incluir el estado civil del paciente")]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero telefonico del paciente")]
        [Display(Name = "Numero del paciente")]
        [Phone]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe incluir el correo del paciente")]
        [Display(Name = "Correo del paciente")]
        [EmailAddress(ErrorMessage = "Formato del correo invalido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha del registro de informacion")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de registro")]
        public string FechaRegistro { get; set; }

        [Required(ErrorMessage = "Debe incluir la ocupacion del cliente")]
        [Display(Name = "Ocupacion del paciente")]
        public string Ocupacion { get; set; }
    }
}
