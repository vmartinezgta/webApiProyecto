using System.ComponentModel.DataAnnotatios;
namespace webapidb.Models{

    public class Clientes{
        [Key]
        public int idCliente{get;set;}
        public string nombres{get;set;}
        public string apellidos{get;set;}
        public string direccion{get;set;}
        public string telefono{get;set;}
    }
}