using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Entidad
{
    public class Domiciliario
    {
        public int DomiciliarioID {get;set;}
        public string Identificacion {get;set;}
         
        public string Nombre { get; set; }
        public string Apellido {get;set;}
        public string Correo {get;set;}
        public string Telefono {get;set;}
        public List<Documento> Documentos  {get;set;}


        public Pedido Pedido {get;set;}
        
        
    }
}