using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class MarcasUnidade
    {
        public int Id { get; set; }
        public int? MarcasId { get; set; }
        public int? UnidadesId { get; set; }
        public int? StatusId { get; set; }

        public virtual Marca Marcas { get; set; }
        public virtual Status Status { get; set; }
        public virtual Unidade Unidades { get; set; }
    }
}
