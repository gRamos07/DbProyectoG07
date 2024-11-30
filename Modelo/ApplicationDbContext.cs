using Microsoft.EntityFrameworkCore;

namespace Proyecto.Modelo
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Secretaria> Secretarias { get; set; }
        public DbSet<Proceso> Procesos { get; set; }
        public DbSet<Propuesta> Propuestas { get; set; }
        public DbSet<CoordinadorDeRevision> CoordinadorDeRevisiones { get; set; }
        public DbSet<Gestor> Gestores { get; set; }
        public DbSet<Informe> Informes { get; set; }
        public DbSet<RevisorPropuesta> RevisorPropuestas { get; set; }

        //Tener en cuenta que se deben de observar 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relación uno-a-muchos entre Alumno y Propuesta
            modelBuilder.Entity<Propuesta>()
                .HasOne(p => p.Alumno)
                .WithMany(a => a.PropuestasACorregir)
                .HasForeignKey(p => p.AlumnoId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Propuesta>()
                .HasOne(p => p.Alumno)
                .WithMany(a => a.PropuestasACorregir)
                .HasForeignKey(p => p.AlumnoId)
                .OnDelete(DeleteBehavior.SetNull);

            // Relación uno-a-muchos: Secretaria -> Propuesta
            modelBuilder.Entity<Propuesta>()
                .HasOne(p => p.Secretaria)
                .WithMany(s => s.PropuestasCargadas)
                .HasForeignKey(p => p.SecretariaId)
                .OnDelete(DeleteBehavior.SetNull);

            // Relación uno-a-muchos: Revisor -> Propuesta
            modelBuilder.Entity<Propuesta>()
                .HasOne(p => p.RevisorPropuestas)
                .WithMany(r => r.PropuestasRevisadas)
                .HasForeignKey(p => p.RevisorPropuestaId)
                .OnDelete(DeleteBehavior.SetNull);

            // Relación uno-a-muchos: Gestor -> Proceso
            modelBuilder.Entity<Proceso>()
                .HasOne(pr => pr.Gestores)
                .WithMany(g => g.Procesos)
                .HasForeignKey(pr => pr.GestorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relación uno-a-muchos: Proceso -> Informe
            modelBuilder.Entity<Informe>()
                .HasOne(i => i.Procesos)
                .WithMany(p => p.Informes)
                .HasForeignKey(i => i.ProcesoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relación uno-a-muchos: Coordinador -> Informe
            modelBuilder.Entity<Informe>()
                .HasOne(i => i.CoordinadorDeRevisiones)
                .WithMany(c => c.Informes)
                .HasForeignKey(i => i.CoordinadorDeRevisionId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    } 
}
