using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        //        IdVenta int primary key identity,
        //IdCliente int references CLIENTE(IdCliente),
        //TotalProducto int,
        //MonTotal decimal (10,2),
        //Contacto varchar(50),
        //IdUbicacion varchar(10),
        //Telefono varchar(50),
        //Direccion varchar(500),
        //IdTransaccion varchar(50)

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MonTotal { get; set; }
        public string Contacto { get; set; }
        public string IdUbicacion { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaTexto { get; set; }
        public string IdTransaccion { get; set; }
    }
}
