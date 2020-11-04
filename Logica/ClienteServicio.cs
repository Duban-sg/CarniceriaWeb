using System;
using System.Collections.Generic;
using Datos;
using Entidad;

namespace Logica
{
    public class ClienteServicio
    {
        private readonly CarniceriaContext _context;

        public ClienteServicio(CarniceriaContext context)
        {
            _context = context;
        }

        public GuardarPersonaResponse Guardar(Cliente cliente)
        {
            try
            {
                _context.Personas.Add(cliente);
                _context.SaveChanges();
                return new GuardarPersonaResponse(cliente);
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }
        }


    }

    public class GuardarPersonaResponse
    {
        public GuardarPersonaResponse(Cliente cliente )
        {
            Error = false;
            Cliente = Cliente;
        }
        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }
    public class ConsultarClientesResponse
    {
        public ConsultarClientesResponse(List<Cliente> clientes)
        {
            Error = false;
            Clientes = Clientes;
        }
        public ConsultarClientesResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
    public class BuscarClienteResponse
    {
        public BuscarClienteResponse(Cliente cliente)
        {
            Error = false;
            Cliente = cliente;
        }
        public BuscarClienteResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }
}