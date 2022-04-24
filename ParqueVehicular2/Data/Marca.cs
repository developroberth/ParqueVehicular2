using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Marca
    {
        public Marca()
        {
            MarcasUnidades = new HashSet<MarcasUnidade>();
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<MarcasUnidade> MarcasUnidades { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
