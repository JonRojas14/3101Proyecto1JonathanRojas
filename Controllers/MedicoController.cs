using Microsoft.AspNetCore.Mvc;
using TestProyecto1.Data;
using TestProyecto1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit;
using System.Net.Mail;

namespace TestProyecto1.Controllers
{
    public class MedicoController : Controller
    {
        private readonly ApplicationDbContext _context; //Invocar clase ApplicationDbContext para acceder a la base de datos

        public MedicoController(ApplicationDbContext context)
        {
            _context = context; //contructor que recibe como parametro la clase dbcontext
        }

        //Get Create
        public IActionResult CreateMed() //metodo Get Create de datos del profesional medico
        {
            return View(); //retorna la vista Create, muestra el formulario para crear registros de medicos
        }

        //Post Create Medicos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMed(Medicos medico)
        {

            MailMessage correo = new MailMessage(); //Objeto tipo MailMessage para enviar correo con informacion extraida del formulario.
            correo.From = new MailAddress("correoproyecto1jonrojas@outlook.com"); //Establece el email desde el cual se enviara el correo con los datos del medico.
            correo.To.Add(medico.Correo); //Establece el email que recibira el correo con la informacion del medico.
            correo.Subject = "Registro de efectos adversos Paso 1 - Datos del profesional medico"; //Establece el asunto (subject) del correo.
            correo.Body += "<b>Datos del medico: </b>";
            correo.Body += "<p>Identificacion: </p>" + medico.Identificacion;
            correo.Body += "<p>Nombre completo: </p>" + medico.NombreComp;
            correo.Body += "<p>Correo electronico: </p>" + medico.Correo;
            correo.Body += "<p>Pais: </p>" + medico.Pais;
            correo.Body += "<p>Estado/Provincia: </p>" + medico.Estado;
            correo.IsBodyHtml = true; // Obtiene o establece si el cuerpo de un mail message esta en HTML. 
            correo.Priority = MailPriority.High; // Establece la prioridad del correo 

            SmtpClient smtp = new SmtpClient(); // crea un objeto de Client SMTP
            smtp.Host = "smtp-mail.outlook.com"; // Nombre del host que sera utilizado para transacciones SMTP
            smtp.Port = 587; // Establece el puerto que ser autilisado para transacciones SMTP, por defaul outlook y office utilizan el puerto 587
            smtp.EnableSsl = true; // Especifica que el cliente utiliza SSL para encriptar la conexion.
            smtp.UseDefaultCredentials = false; // establece que si las solicitudes utilizaran las credenciales por defecto
            string correoEnv = "correoproyecto1jonrojas@outlook.com"; // variable para definir el correo desde el que se enviara el correo
            string contra = "PruebaCorreo3101"; // variable para definir la contraseña del correo
            smtp.Credentials = new System.Net.NetworkCredential(correoEnv, contra); // establece las credenciales del cliente smtp usando las variables definidas anteriormente
            smtp.Send(correo); // accion para enviar el correo. 

            if (ModelState.IsValid) // valida el modelo es decir toma en cuenta si un campo es requerido, entre otros.
            {
                _context.Med.Add(medico); //agrega un objeto mdel modelo medicos 
                _context.SaveChanges(); //guarda los cambios en la tabla correspondiente de la base de datos

                return RedirectToAction("CreateClinic"); //redirecciona al Paso 2 para brindar la informacion de la clinica 
            }            

            return View();
        }

        //Get Create para formulario de clinicas
        public IActionResult CreateClinic() //metodo Get Create
        {
            return View(); //retorna la vista CreateClinic, muestra el formulario para crear registros de clinicas
        }

        //Post Create Clinicas
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateClinic(Clinicas clinicas)
        {

            MailMessage correo = new MailMessage(); //Objeto tipo MailMessage para enviar correo con informacion extraida del formulario.
            correo.From = new MailAddress("correoproyecto1jonrojas@outlook.com"); //Establece el email desde el cual se enviara el correo con los datos del medico.
            correo.To.Add(clinicas.Correo); //Establece el email que recibira el correo con la informacion del medico.
            correo.Subject = "Registro de efectos adversos Paso 2 - Informacion del paciente"; //Establece el asunto (subject) del correo.
            // Este bloque establece el cuerpo que tendra el correo y la infromacion. 
            correo.Body += "<b>Datos de la clinica: </b>";
            correo.Body += "<p>Nombre de la clinica: </p>" + clinicas.Nombre;
            correo.Body += "<p>Cedula Juridica: </p>" + clinicas.Cedula;
            correo.Body += "<p>Pais: </p>" + clinicas.Pais;
            correo.Body += "<p>Estado/Provincia: </p>" + clinicas.Estado;
            correo.Body += "<p>Distrito: </p>" + clinicas.Distrito;
            correo.Body += "<p>Telefono de la administracion: </p>" + clinicas.Telefono;
            correo.Body += "<p>Correo de la clinica: </p>" + clinicas.Correo;
            correo.Body += "<p>Sitio web de la clinica: </p>" + clinicas.SitioWeb;
            // Fin del bloque del cuerpo
            correo.IsBodyHtml = true; // Obtiene o establece si el cuerpo de un mail message esta en HTML. 
            correo.Priority = MailPriority.High; // Establece la prioridad del correo 

            SmtpClient smtp = new SmtpClient(); // crea un objeto de Client SMTP
            smtp.Host = "smtp-mail.outlook.com"; // Nombre del host que sera utilizado para transacciones SMTP
            smtp.Port = 587; // Establece el puerto que ser autilisado para transacciones SMTP, por defaul outlook y office utilizan el puerto 587
            smtp.EnableSsl = true;  // Especifica que el cliente utiliza SSL para encriptar la conexion.
            smtp.UseDefaultCredentials = false; // establece que si las solicitudes utilizaran las credenciales por defecto
            string correoEnv = "correoproyecto1jonrojas@outlook.com"; // variable para definir el correo desde el que se enviara el correo
            string contra = "PruebaCorreo3101"; // variable para definir la contraseña del correo
            smtp.Credentials = new System.Net.NetworkCredential(correoEnv, contra); // establece las credenciales del cliente smtp usando las variables
            smtp.Send(correo); // accion para enviar el correo.

            if (ModelState.IsValid) // valida el modelo es decir toma en cuenta si un campo es requerido, entre otros.
            {
                _context.Clinic.Add(clinicas); //agrega un objeto del modelo clinicas
                _context.SaveChanges(); //guarda los cambios

                return RedirectToAction("CreatePacient"); //redirecciona al Paso 3 para brindar la informacion de la clinica 

            }

            return View();

        }

        //Get Create para formulario de pacientes
        public IActionResult CreatePacient() //metodo Get Create
        {
            return View(); //retorna la vista CreateClinic, muestra el formulario para crear registros de clinicas
        }

        //Post Create Paciente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePacient(Pacientes pacientes)
        {

            MailMessage correo = new MailMessage(); //Objeto tipo MailMessage para enviar correo con informacion extraida del formulario.
            correo.From = new MailAddress("correoproyecto1jonrojas@outlook.com");  //Establece el email desde el cual se enviara el correo con los datos del medico.
            correo.To.Add(pacientes.Correo); //Establece el email que recibira el correo con la informacion del medico.
            correo.Subject = "Registro de efectos adversos Paso 3 - Informacion del paciente"; //Establece el asunto (subject) del correo.
            // Este bloque establece el cuerpo que tendra el correo y la infromacion.
            correo.Body += "<b>Datos del Paciente: </b>";
            correo.Body += "<p>Identificacion: </p>" + pacientes.CedulaPaciente;
            correo.Body += "<p>Nombre del paciente: </p>" + pacientes.Nombre;
            correo.Body += "<p>Primer Apellido: </p>" + pacientes.Apellido1;
            correo.Body += "<p>Segundo Apellido: </p>" + pacientes.Apellido2;
            correo.Body += "<p>Fecha de nacimiento: </p>" + pacientes.Nacimiento;
            correo.Body += "<p>Sexo Natural: </p>" + pacientes.Sexo;
            correo.Body += "<p>Numero de contacto del paciente: </p>" + pacientes.NumContacto;
            correo.Body += "<p>Pais: </p>" + pacientes.Pais;
            correo.Body += "<p>Provincia: </p>" + pacientes.Provincia;
            correo.Body += "<p>Distrito: </p>" + pacientes.Distrito;
            correo.Body += "<p>Estado Civil: </p>" + pacientes.EstadoCivil;
            correo.Body += "<p>Telefono: </p>" + pacientes.Telefono;
            correo.Body += "<p>Correo electronico del paciente: </p>" + pacientes.Correo;
            correo.Body += "<p>Fecha de registro: </p>" + pacientes.FechaRegistro;
            correo.Body += "<p>Ocupacion: </p>" + pacientes.Ocupacion;
            // Fin del bloque del cuerpo
            correo.IsBodyHtml = true; // Obtiene o establece si el cuerpo de un mail message esta en HTML.
            correo.Priority = MailPriority.High; // Establece la prioridad del correo 

            SmtpClient smtp = new SmtpClient(); // crea un objeto de Client SMTP
            smtp.Host = "smtp-mail.outlook.com"; // Nombre del host que sera utilizado para transacciones SMTP
            smtp.Port = 587; // Establece el puerto que ser autilisado para transacciones SMTP, por defaul outlook y office utilizan el puerto 587
            smtp.EnableSsl = true; // Especifica que el cliente utiliza SSL para encriptar la conexion.
            smtp.UseDefaultCredentials = false; // establece que si las solicitudes utilizaran las credenciales por defecto
            string correoEnv = "correoproyecto1jonrojas@outlook.com"; // variable para definir el correo desde el que se enviara el correo
            string contra = "PruebaCorreo3101"; // variable para definir la contraseña del correo
            smtp.Credentials = new System.Net.NetworkCredential(correoEnv, contra); // establece las credenciales del cliente smtp usando las variables
            smtp.Send(correo); // accion para enviar el correo.

            if (ModelState.IsValid) // valida el modelo es decir toma en cuenta si un campo es requerido, entre otros.
            {
                _context.Pac.Add(pacientes); //agrega un objeto del modelo clinicas
                _context.SaveChanges(); //guarda los cambios

                return RedirectToAction("CreateReporteInyecciones"); //redirecciona al index donde estan los registros de los pacientes

            }

            return View();

        }

        public IActionResult CreateReporteInyecciones() //metodo Get Create
        {
            return View(); //retorna la vista CreateClinic, muestra el formulario para crear registros de clinicas
        }

        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReporteInyecciones(Inyecciones inyecciones)
        {

            if (ModelState.IsValid) // valida el modelo es decir toma en cuenta si un campo es requerido, entre otros.
            {
                _context.Inyec.Add(inyecciones); //agrega un objeto del modelo clinicas
                _context.SaveChanges(); //guarda los cambios

                return RedirectToAction("CreateReporteEfectos"); //redirecciona al index donde estan los registros de los pacientes

            }

            return View();

        }

        public IActionResult CreateReporteEfectos() //metodo Get Create
        {
            return View(); //retorna la vista CreateReporteEfectos, muestra el formulario para crear registros de clinicas
        }

        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReporteEfectos(Efectos efectos, List<string> ListaResultados, List<string> ListaAlergias, List<string> ListaNuevasEfermedades, List<string> ListaSintomas)
        {

            string resultados = string.Join(", ", ListaResultados);
            efectos.ResultadosEfectosAdversos = resultados;

            string alergias = string.Join(", ", ListaAlergias);
            efectos.Alergias = alergias;

            string enfermedadesnuevas = string.Join(", ", ListaNuevasEfermedades);
            efectos.NuevasEnfermedades = enfermedadesnuevas;

            string sintomas = string.Join(", ", ListaSintomas);
            efectos.Sintomas = sintomas;

            MailMessage correo = new MailMessage(); //Objeto tipo MailMessage para enviar correo con informacion extraida del formulario.
            correo.From = new MailAddress("correoproyecto1jonrojas@outlook.com");  //Establece el email desde el cual se enviara el correo con los datos del medico.
            correo.To.Add(efectos.CorreoPaciente); //Establece el email desde el cual se enviara el correo con los datos del medico.
            correo.To.Add(efectos.CorreoMedico); //Establece el email que recibira el correo con la informacion del medico.
            correo.Subject = "Registro de efectos adversos fase 5 - Registrar efectos adversos"; //Establece el asunto (subject) del correo.
            // Este bloque establece el cuerpo que tendra el correo y la infromacion.
            correo.Body += "<b>Datos del medico: </b>";
            correo.Body += "<p>Nombre del medico: </p>" + efectos.NombreMedico;
            correo.Body += "<p>Correo electronico: </p>" + efectos.CorreoMedico;
            correo.Body += "<p> <b>Datos del paciente: </b></p>";
            correo.Body += "<p>Nombre del paciente: </p>" + efectos.NombrePaciente;
            correo.Body += "<p>Correo electronico: </p>" + efectos.CorreoPaciente;
            correo.Body += "<p> <b>Reporte de efectos del paciente: </b></p>";
            correo.Body += "<p>Efectos adversos: </p>" + efectos.ResultadosEfectosAdversos;
            correo.Body += "<p>Converva los sintomas?: </p>" + efectos.ConservaSintomas;
            correo.Body += "<p>Alergias: </p>" + efectos.Alergias;
            correo.Body += "<p>Descripcion de alergias: </p>" + efectos.DescripAlergias;
            correo.Body += "<p>Nuevas enfermedades: </p>" + efectos.NuevasEnfermedades;
            correo.Body += "<p>Otras condiciones: </p>" + efectos.OtrasCondiciones;
            correo.Body += "<p>Ha desarrollado un nuevo cancer?, especifique: </p>" + efectos.Cancer;
            correo.Body += "<p>Sintomas: </p>" + efectos.Sintomas;
            // Fin del bloque del cuerpo
            correo.IsBodyHtml = true; // Obtiene o establece si el cuerpo de un mail message esta en HTML.
            correo.Priority = MailPriority.High; // Establece la prioridad del correo 

            SmtpClient smtp = new SmtpClient(); // crea un objeto de Client SMTP
            smtp.Host = "smtp-mail.outlook.com"; // Nombre del host que sera utilizado para transacciones SMTP
            smtp.Port = 587;  // Establece el puerto que ser autilisado para transacciones SMTP, por defaul outlook y office utilizan el puerto 587
            smtp.EnableSsl = true; // Especifica que el cliente utiliza SSL para encriptar la conexion.
            smtp.UseDefaultCredentials = false; // establece que si las solicitudes utilizaran las credenciales por defecto
            string correoEnv = "correoproyecto1jonrojas@outlook.com"; // variable para definir el email desde el que se enviara el correo
            string contra = "PruebaCorreo3101"; // variable para definir la contraseña del correo
            smtp.Credentials = new System.Net.NetworkCredential(correoEnv, contra); // establece las credenciales del cliente smtp usando las variables
            smtp.Send(correo); // accion para enviar el correo.

            if (ModelState.IsValid) // valida el modelo es decir toma en cuenta si un campo es requerido, entre otros.
            {
                _context.Efec.Add(efectos); //agrega un objeto del modelo clinicas
                _context.SaveChanges(); //guarda los cambios

                return RedirectToAction("Index", "Home"); //redirecciona al index donde estan los registros de los efectos secundarios

            }

            return View(efectos);

        }

    }

}
