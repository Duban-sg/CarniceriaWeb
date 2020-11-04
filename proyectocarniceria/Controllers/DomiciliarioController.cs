using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;
using Datos;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using proyectocarniceria.Models;

namespace WebPulsaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomiciliarioController: ControllerBase
    {
        private readonly DomiciliarioServicio _domiciliarioService;
        
        public DomiciliarioController( CarniceriaContext _context)
        {
            _domiciliarioService = new DomiciliarioServicio(_context);
        }

        
        // GET: api/Domiciliario
        [HttpGet]
        public ActionResult<IEnumerable<DomiciliarioViewModel>> Gets()
        {
            var response = _domiciliarioService.ConsultarTodos(); 
            if(response.Error){
           
                return BadRequest(response.Mensaje);
            }
            var domiciliarios = response.Domiciliarios.Select(d => new DomiciliarioViewModel(d));
            return Ok(domiciliarios);
        }
        
        // Post: api/Persona
        [HttpPost]
        public ActionResult<DomiciliarioViewModel> Post(DomiciliarioInputModel domiciliarioInput)
        {
            Domiciliario domiciliario = MapearDomiciliario(domiciliarioInput);
            var response = _domiciliarioService.Guardar(domiciliario);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Domiciliario);
        }
        private Domiciliario MapearDomiciliario(DomiciliarioInputModel domiciliarioInput)
        {
            var domiciliario = new Domiciliario
            {
                  Identificacion =  domiciliarioInput.Identificacion,
                  Nombre = domiciliarioInput.Nombre,
                  Apellido = domiciliarioInput.Apellido,
                  Correo = domiciliarioInput.Correo,
                  Telefono = domiciliarioInput.Telefono
            };
            return domiciliario;
        }
    }
}