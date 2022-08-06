using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestProyecto1.Models
{
    public class Inyecciones
    {
        //este modelo representa la tabla Inyecciones en la base de datos

        //propiedades con data annotations 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre del inoculo")]
        [Display(Name = "Nombre de inoculo")]
        public string NombreInyec { get; set; }

        [Required(ErrorMessage = "Debe incluir el nombre de la marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de aplicacion de la primera dosis")]
        [Display(Name = "Fecha de aplicacion - Primera dosis")]
        [DataType(DataType.Date)]
        public string FechaAplicacion1 { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de aplicacion de la segunda dosis")]
        [Display(Name = "Fecha de aplicacion - Segunda dosis")]
        [DataType(DataType.Date)]
        public string FechaAplicacion2 { get; set; }

        [Required(ErrorMessage = "Debe incluir el numero de lote")]
        [Display(Name = "Numero de lote")]
        public string Lote { get; set; }

        [Required(ErrorMessage = "Debe incluir la fecha de vencimiento")]
        [Display(Name = "Fecha de vencimiento")]
        [DataType(DataType.Date)]
        public string FechaVencimiento { get; set; }

        [Required(ErrorMessage = "Debe incluir el lugar de aplicacion")]
        [Display(Name = "Lugar de Aplicacion")]
        public string LugarAplicacion { get; set; }

        [Required(ErrorMessage = "Debe incluir observaciones generales")]
        [Display(Name = "Observaciones")]
        public string Observacion { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Ha tenido COVID previo a inyectarse?")]
        public string TuvoCovid { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Ha tenido sospecha de haber tenido COVID antes de ponerte la inyección ?")]
        public string Sospecha { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Ha tenido COVID después de tomar la inyección?")]
        public string CovidPostInyeccion { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Razón de inyectarse contra COVID?")]
        public string RazonDeInyeccion { get; set; }

        [Display(Name = "¿Estaba embarazada al inyectarse contra COVID?")]
        public string EstabaEmbarazada { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "¿Ha tenido reacciones a vacunas en el pasado?")]
        public string Reacciones { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Especifique las reacciones a vacunas en el pasado")]
        public string DescripcionesReacciones { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Medicamentos actuales con receta: enumere todos los medicamentos y las dosis.")]
        public string Medicamentos { get; set; }

        [Required(ErrorMessage = "Informacion requerida")]
        [Display(Name = "Nuevos medicamentos recetados que tuvieron que ser iniciados después de la(s) inyección(es) de COVID")]
        public string MeidcamentosPostInyeccion { get; set; }
    }
}
