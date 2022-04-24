using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class UsuariosVehiculo
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? VehiculoId { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
