using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuariosRoles = new HashSet<UsuariosRole>();
            UsuariosVehiculos = new HashSet<UsuariosVehiculo>();
        }

        public int Id { get; set; }
        public string AppPaterno { get; set; }
        public string AppMaterno { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Usuario1 { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }
        public int? StatusId { get; set; }
        public int? LicenciaId { get; set; }

        public virtual Licencia Licencia { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<UsuariosRole> UsuariosRoles { get; set; }
        public virtual ICollection<UsuariosVehiculo> UsuariosVehiculos { get; set; }
    }
}
