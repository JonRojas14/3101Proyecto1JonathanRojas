using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestProyecto1.Models
{
    public class Efectos
    {
        //este modelo representa la tabla Efectos en la base de datos

        //propiedades con data annotations 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del medico no puede estar vacio")]
        [Display(Name = "Nombre del medico:")]
        public string NombreMedico { get; set; }

        [Required(ErrorMessage = "El correo del medico no puede estar vacio")]
        [Display(Name = "Correo del medico:")]
        [EmailAddress(ErrorMessage = "Formato del correo invalido")]
        public string CorreoMedico { get; set; }

        [Required(ErrorMessage = "El nombre del paciente no puede estar vacio")]
        [Display(Name = "Nombre del paciente:")]
        public string NombrePaciente { get; set; }

        [Required(ErrorMessage = "El correo del paciente no puede estar vacio")]
        [Display(Name = "Correo del paciente:")]
        [EmailAddress(ErrorMessage = "Formato del correo invalido")]
        public string CorreoPaciente { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Efecto(s) adverso(s)")]
        public string? ResultadosEfectosAdversos { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Se mantiene los síntomas?")]
        public string ConservaSintomas { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Alergias conocidas?")]
        public string? Alergias { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Descripción de alergias conocidas.")]
        public string DescripAlergias { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Nuevas enfermedades desde su inyección de COVID")]
        public string? NuevasEnfermedades { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Especifique otras condiciones")]
        public string OtrasCondiciones { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Si ha desarrollado un nuevo cáncer o la reaparición de un cáncer existente después de la inyección de COVID, especifique el tipo de cáncer ? ")]
        public string Cancer { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Desde la inyección de COVID, ha tenido alguno de los siguientes síntomas ?")]
        public string? Sintomas { get; set; }

    }
}
