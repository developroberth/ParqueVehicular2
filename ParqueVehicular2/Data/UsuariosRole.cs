using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class UsuariosRole
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? RolId { get; set; }
        public int? StatusId { get; set; }

        public virtual Role Rol { get; set; }
        public virtual Status Status { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
