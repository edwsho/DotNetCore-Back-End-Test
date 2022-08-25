using BackEndPortafolioTarjeta.Application.Services;
using BackEndPortafolioTarjeta.Infrastructure;
using BackEndPortafolioTarjeta.Infrastructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarjetaCredito.Domain.DomainObject;

namespace BackEndPortafolioTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudHogwartsController : ControllerBase
    {

        SolicitudHogwartsServices CreateSolicitudHogwartsServices()
        {
           
            SolicitudHogwartsDbContext _context = new SolicitudHogwartsDbContext();         // Obtengo el Contexto para acceder a la Base de Datos
            SolicitudHogwartsRepository _repo = new SolicitudHogwartsRepository(_context);  // Intancio el Repositorio con el Contexto, Aca estan los Casos de Uso
            SolicitudHogwartsServices _services = new SolicitudHogwartsServices(_repo);     // Intancio el Servicio con el repositorio el cual quiero trabajar en este Controller

            return _services;
        }

        // GET api/Tarjeta/GetTarjetas
        /// <summary>
        /// Metodo Expuesto encargado de mostrar todas las solicitudes de ingreso a Hogwarts.
        /// </summary>
        /// <returns>Devuelve una lista con todas las Solicitudes de ingreso a Hogwarts del tipo SolicitudHogwarts </returns>
        /// <response code="200"> OK. Devuelve la lista de solicitudes. </response>
        [HttpGet]
        [Route("GetSolicitud")]
        public async Task<IActionResult> GetTarjetas()
        {
            try
            {
                var _service = CreateSolicitudHogwartsServices();
                return Ok(_service.List());

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        /// <summary>
        /// Metodo Expuesto encargado de mostrar la solicitud de ingreso a Hogwarts
        /// </summary>
        /// <params name="_id">Id de la solicitud a consultar</params>
        /// <returns>Devuelve una Solicitud de ingreso a Hogwarts del tipo SolicitudHogwarts </returns>
        /// <response code="200"> OK. Devuelve la solicitud especifica. </response>
        /// <response code="400"> Mensaje: Solicitud con Id: 1 no encontrada!! </response>
        // GET api/<TarjetaController>/5
        [HttpGet("{_id}")]
        public ActionResult<SolicitudHogwarts> Get(int _id)
        {
            try
            {
                var _service = CreateSolicitudHogwartsServices();
                return Ok(_service.GetbyID(_id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // POST api/<TarjetaController>
        /// <summary>
        /// Metodo Expuesto encargado de agregar una solicitud de ingreso a Hogwarts
        /// </summary>
        /// <params name="_solicitud">Objeto del tipo SolicitudHogwarts </params>
        /// <returns>Devuelve una Solicitud de ingreso a Hogwarts del tipo SolicitudHogwarts </returns>
        /// <response code="200"> OK. Retorna el objeto añadido con sus respectivos campos.</response>
        /// <response code="400"> Excepcion por Cantidad de caracateres(Nombre Apellido, Identificacion Casa), Excepcion por una Casa que no existe. </response>
        [HttpPost]
        [Route("PostSolicitud")]
        public async Task<IActionResult> Post([FromBody] SolicitudHogwarts _solicitud)
        {
            try
            {
                var _service = CreateSolicitudHogwartsServices();
                return Ok(_service.Add(_solicitud));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // PUT api/<TarjetaController>/5
        /// <summary>
        /// Metodo Expuesto encargado de editar una solicitud de ingreso a Hogwarts
        /// </summary>
        /// <params name="_solicitud">Objeto del tipo SolicitudHogwarts </params>
        /// <returns>Devuelve una Solicitud de ingreso a Hogwarts del tipo SolicitudHogwarts </returns>
        /// <response code="200"> OK. Mensaje: Solicitud con Id: X y con Nombre: X Modificada Satisfactoriamente </response>
        /// <response code="400"> Mensaje: No se encontro el Id especificado </response>
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] SolicitudHogwarts _solicitud)
        {

            try
            {
                var _service = CreateSolicitudHogwartsServices();
                //_actTarjeta.Id = id;
                _service.Edit(_solicitud);
                return Ok("Solicitud con Id: " + _solicitud.Id + " y con Nombre: " + _solicitud.Nombre + " Modificada Satisfactoriamente");

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        // DELETE api/<TarjetaController>/5
        /// <summary>
        /// Metodo Expuesto encargado de eliminar una solicitud de ingreso a Hogwarts
        /// </summary>
        /// <params name="id">Id de la solicitud a eliminar</params>
        /// <returns>Devuelve un mensaje de aliminacion satisfactoria.</returns>
        /// <response code="200"> OK. Mensaje: Solicitud Eliminada con exito! </response> 
        /// <response code="400"> Mensaje: No se encontro el Id especificado </response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                var _service = CreateSolicitudHogwartsServices();
                _service.Delete(id);
                return Ok(new { message = "Solicitud Eliminada con exito!" });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        //[HttpGet("Expulsar/{id}")]
        //public ActionResult<SolicitudHogwarts> Expulsar(int id)
        //{
        //    try
        //    {
        //        var _service = CreateSolicitudHogwartsServices();
        //        return Ok(_service.ExpulsarAlumno(id));
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }

        //}

    }
}
