using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestProyecto1.Models
{
    public class Medicos
    {
        //este modelo representa la tabla Medicos en la base de datos

        //propiedades con data annotations 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero de identificacion del medico.")]
        [StringLength(8, MinimumLength = 1, ErrorMessage = "8 caracteres maximo.")]
        [Display(Name = "Identificacion Medico")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "Debe incluir el codigo del medico.")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "4 caracteres maximo.")]
        [Display(Name = "Codigo de medico")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre completo del medico.")]
        [Display(Name = "Nombre completo de medico")]
        [StringLength(50, ErrorMessage ="El nombre debe tener como minimo 50 caracteres.")]
        public string NombreComp { get; set; }

        [Required(ErrorMessage = "Debe incluir el correo del medico")]
        [Display(Name = "Correo del medico")]
        [EmailAddress(ErrorMessage = "Formato del correo invalido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Debe incluir el pais de residencia del medico")]
        [Display(Name = "Pais del medico")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Debe incluir el estado o provincia de residencia del medico")]
        [Display(Name = "Estado o provincia del medico")]
        public string Estado { get; set; }
    }
}
