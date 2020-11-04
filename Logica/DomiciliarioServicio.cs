using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;

namespace Logica
{
   
    public class DomiciliarioServicio
    {
        private readonly CarniceriaContext _context;

        public DomiciliarioServicio(CarniceriaContext context)
        {
            _context = context;
        }

        public GuardarDomiciliaroResponse Guardar(Domiciliario domiciliario)
        {
            try
            {
                _context.Domiciliarios.Add(domiciliario);
                _context.SaveChanges();
                return new GuardarDomiciliaroResponse(domiciliario);
            }
            catch (Exception e)
            {
                return new GuardarDomiciliaroResponse($"Error de la Aplicacion: {e.Message}");
            }
        }

           public ConsultarDomiciliarioResponse ConsultarTodos()
        {
            try
            {
                //var personas = _context.Personas.Include(a => a.Apoyo).ToList();
                var domiciliarios = _context.Domiciliarios.ToList();
                return new ConsultarDomiciliarioResponse(domiciliarios);

            }
            catch (Exception e)
            {
                return new ConsultarDomiciliarioResponse($"error de aplicacion: {e.Message}");
            }

        }




    }

    public class GuardarDomiciliaroResponse
    {
        public GuardarDomiciliaroResponse(Domiciliario domiciliario )
        {
            Error = false;
            Domiciliario = domiciliario;
        }
        public GuardarDomiciliaroResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Domiciliario Domiciliario { get; set; }
    }
    public class ConsultarDomiciliarioResponse
    {
        public ConsultarDomiciliarioResponse(List<Domiciliario> domiciliarios)
        {
            Error = false;
            Domiciliarios = domiciliarios;
        }
        public ConsultarDomiciliarioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Domiciliario> Domiciliarios { get; set; }
    }
    public class BuscarDomiciliarioResponse
    {
        public BuscarDomiciliarioResponse(Domiciliario domiciliario)
        {
            Error = false;
            Domiciliario = domiciliario;
        }
        public BuscarDomiciliarioResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Domiciliario Domiciliario { get; set; }
    }
}