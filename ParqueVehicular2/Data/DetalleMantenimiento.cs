using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class DetalleMantenimiento
    {
        public int Id { get; set; }
        public int? MantenimientosId { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public double? Importe { get; set; }
        public string StatusId { get; set; }
    }
}
