using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Mantenimiento
    {
        public int Id { get; set; }
        public int? VehiculoId { get; set; }
        public DateTime? FechaMantto { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }
        public int? StatusId { get; set; }
    }
}
