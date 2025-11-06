using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes
{
    public class Cliente
    {
        public string? Cuit { get; set; } 
        public string? RazonSocial { get; set; }
        public string? Telefono { get; set; }
        public string? Provincia { get; set; }
        public string? Localidad { get; set; }
        public string? Calle { get; set; }

        public Cliente (string? cuit, string? razonSocial, string? telefono, string? provincia, string? localidad, string? calle)
        {
            Cuit = cuit;
            RazonSocial = razonSocial;
            Telefono = telefono;
            Provincia = provincia;
            Localidad = localidad;
            Calle = calle;
        }
    }
}
