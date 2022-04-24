using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class DetalleMantenimientosEvidencium
    {
        public int Id { get; set; }
        public int? DetalleMantenimientosId { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime? FechaArchivo { get; set; }
        public string Tipo { get; set; }
    }
}
