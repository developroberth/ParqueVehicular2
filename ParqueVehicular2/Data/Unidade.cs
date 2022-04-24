using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Unidade
    {
        public Unidade()
        {
            MarcasUnidades = new HashSet<MarcasUnidade>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<MarcasUnidade> MarcasUnidades { get; set; }
    }
}
