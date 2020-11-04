using System;
using System.ComponentModel.DataAnnotations;
namespace Entidad
{
    public class Documento
    {
        public int DocumentoID {get;set;}
        public DateTime Fecha {get;set;}
        public String Url {get;set;}

        //para la relacion
        public Domiciliario Domiciliario {get;set;}
        public string Identificacion {get;set;} 
    }
}