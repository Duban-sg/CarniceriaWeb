using System.Collections.Generic;
namespace Entidad
{
    public class Persona
    {
        public int PersonaID {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string correo {get;set;}
        public string contraseña {get;set;}
        public List<Pedido> pedidos {get;set;}





        
    }
}