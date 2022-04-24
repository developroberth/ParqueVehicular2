using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Licencia
    {
        public Licencia()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
