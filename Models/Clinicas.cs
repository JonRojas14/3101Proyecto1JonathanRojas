using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestProyecto1.Models
{
    public class Clinicas
    {
        //este modelo representa la tabla Clinicas en la base de datos

        //propiedades con data annotations 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre completo de la clinica")]
        [Display(Name = "Nombre de la clinica")]
        [StringLength(50, ErrorMessage = "El nombre de la clinica debe tener como minimo 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero de cedula juridico de la clinica")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "8 caracteres maximo.")]
        [Display(Name = "Cedula juridica")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero telefonico de la clinica")]
        [Phone]
        [Display(Name = "Numero telefonico de la clinica")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe incluir el correo de la clinica")]
        [Display(Name = "Correo de la clinica")]
        [EmailAddress(ErrorMessage = "Formato del correo invalido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe incluir el pais de donde se encuentra la clinica")]
        [Display(Name = "Pais de la clinica")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Debe incluir el estado o provincia donde se encuentra la clinica")]
        [Display(Name = "Estado o provincia de la clinica")]
        public string Estado { get; set; }

        [Display(Name = "Distrito de la clinica")]
        public string? Distrito { get; set; }

        [Required(ErrorMessage = "Debe incluir el sitio web de la clinica")]
        [Display(Name = "Sitio Web")]
        [Url(ErrorMessage ="El formato del sitio web es invalido")]
        public string SitioWeb { get; set; }


    }
}
