using System;
using System.Collections.Generic;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class Status
    {
        public Status()
        {
            Licencia = new HashSet<Licencia>();
            Marcas = new HashSet<Marca>();
            MarcasUnidades = new HashSet<MarcasUnidade>();
            Roles = new HashSet<Role>();
            Unidades = new HashSet<Unidade>();
            Usuarios = new HashSet<Usuario>();
            UsuariosRoles = new HashSet<UsuariosRole>();
            UsuariosVehiculos = new HashSet<UsuariosVehiculo>();
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int Id { get; set; }


        public string Descripcion { get; set; }

        public virtual ICollection<Licencia> Licencia { get; set; }
        public virtual ICollection<Marca> Marcas { get; set; }
        public virtual ICollection<MarcasUnidade> MarcasUnidades { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Unidade> Unidades { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<UsuariosRole> UsuariosRoles { get; set; }
        public virtual ICollection<UsuariosVehiculo> UsuariosVehiculos { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
