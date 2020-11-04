using System;
using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class Estado
    {
        public int EstadoID {get;set;}
        public string NombreEstado{get;set;}
        public DateTime Fecha {get;set;}


        //para la relacion
        public Pedido Pedido {get;set;} 
    }
}