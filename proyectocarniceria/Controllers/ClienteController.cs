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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServicio _clienteService;
        
        public ClienteController( CarniceriaContext _context)
        {
            _clienteService = new ClienteServicio(_context);
        }

        /*
        // GET: api/Persona
        [HttpGet]
        public ActionResult<IEnumerable<PersonaViewModel>> Gets()
        {
            var response = _personaService.ConsultarTodos(); 
            if(response.Error){
           
                return BadRequest(response.Mensaje);
            }
            var personas = response.Personas.Select(p => new PersonaViewModel(p));
            return Ok(personas);
        }
        */
        // Post: api/Cliente
        [HttpPost]
        public ActionResult<ClienteViewModel> Post(ClienteInputModel clienteInput)
        {
            Cliente cliente = MapearCliente(clienteInput);
            var response = _clienteService.Guardar(cliente);
            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Cliente);
        }
        private Cliente MapearCliente(ClienteInputModel clienteInput)
        {
            var cliente = new Cliente
            {
                  Nombre = clienteInput.Nombre,
                  Apellido = clienteInput.Apellido,
                  Correo = clienteInput.Correo,
                  Password = clienteInput.Password
            };
            return cliente;
        }
    }
}