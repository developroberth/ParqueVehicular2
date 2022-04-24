using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ParqueVehicular2.Data
{
    public partial class ParqueVehicularDBContext : DbContext
    {
        public ParqueVehicularDBContext()
        {
        }

        public ParqueVehicularDBContext(DbContextOptions<ParqueVehicularDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetalleMantenimiento> DetalleMantenimientos { get; set; }
        public virtual DbSet<DetalleMantenimientosEvidencium> DetalleMantenimientosEvidencia { get; set; }
        public virtual DbSet<Licencia> Licencias { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimientos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MarcasUnidade> MarcasUnidades { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuariosRole> UsuariosRoles { get; set; }
        public virtual DbSet<UsuariosVehiculo> UsuariosVehiculos { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1J2A00L;Database=ParqueVehicularDB;User ID=desa;Password=123456;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<DetalleMantenimiento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Folio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MantenimientosId).HasColumnName("MantenimientosID");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .HasColumnName("StatusID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DetalleMantenimientosEvidencium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DetalleMantenimientosId).HasColumnName("DetalleMantenimientosID");

                entity.Property(e => e.FechaArchivo).HasColumnType("date");

                entity.Property(e => e.NombreArchivo).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<Licencia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Licencia)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Licencias_Status");
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaMantto).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UsuarioAlta)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Marcas)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Marcas_Status");
            });

            modelBuilder.Entity<MarcasUnidade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarcasId).HasColumnName("MarcasID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UnidadesId).HasColumnName("UnidadesID");

                entity.HasOne(d => d.Marcas)
                    .WithMany(p => p.MarcasUnidades)
                    .HasForeignKey(d => d.MarcasId)
                    .HasConstraintName("FK_MarcasUnidades_Marcas");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MarcasUnidades)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MarcasUnidades_Status");

                entity.HasOne(d => d.Unidades)
                    .WithMany(p => p.MarcasUnidades)
                    .HasForeignKey(d => d.UnidadesId)
                    .HasConstraintName("FK_MarcasUnidades_Unidades");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Roles_Status");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Unidades)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Unidades_Status");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppMaterno).HasMaxLength(50);

                entity.Property(e => e.AppPaterno).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.LicenciaId).HasColumnName("LicenciaID");

                entity.Property(e => e.Nombres).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(10)
                    .HasColumnName("Usuario")
                    .IsFixedLength(true);

                entity.Property(e => e.UsuarioAlta).HasMaxLength(50);

                entity.HasOne(d => d.Licencia)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.LicenciaId)
                    .HasConstraintName("FK_Usuarios_Licencias");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Usuarios_Status");
            });

            modelBuilder.Entity<UsuariosRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UsuariosRoles)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_UsuariosRoles_Roles");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UsuariosRoles)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_UsuariosRoles_Status");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuariosRoles)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_UsuariosRoles_Usuarios");
            });

            modelBuilder.Entity<UsuariosVehiculo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UsuarioAlta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.VehiculoId).HasColumnName("VehiculoID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UsuariosVehiculos)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_UsuariosVehiculos_Status");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuariosVehiculos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_UsuariosVehiculos_Usuarios");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.UsuariosVehiculos)
                    .HasForeignKey(d => d.VehiculoId)
                    .HasConstraintName("FK_UsuariosVehiculos_Vehiculos");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.Modelo).HasColumnType("date");

                entity.Property(e => e.Placas).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TarjetaIaveVencimiento).HasColumnType("date");

                entity.Property(e => e.TipoLinea).HasMaxLength(50);

                entity.Property(e => e.UsuarioAlta).HasMaxLength(50);

                entity.Property(e => e.VerificacionId).HasColumnName("VerificacionID");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.MarcaId)
                    .HasConstraintName("FK_Vehiculos_Marcas");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Vehiculos_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
