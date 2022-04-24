using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Role
    {
        public Role()
        {
            UsuariosRoles = new HashSet<UsuariosRole>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<UsuariosRole> UsuariosRoles { get; set; }
    }
}
