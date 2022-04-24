using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            UsuariosVehiculos = new HashSet<UsuariosVehiculo>();
        }

        public int Id { get; set; }
        public DateTime? Modelo { get; set; }
        public string Placas { get; set; }
        public double? Kilometraje { get; set; }
        public string TipoLinea { get; set; }
        public string Color { get; set; }
        public int? NumeroSerie { get; set; }
        public DateTime? TarjetaIaveVencimiento { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }
        public int? MarcaId { get; set; }
        public int? VerificacionId { get; set; }
        public int? StatusId { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<UsuariosVehiculo> UsuariosVehiculos { get; set; }
    }
}
