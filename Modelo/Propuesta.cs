namespace Proyecto.Modelo
{
    public class Propuesta
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Estado { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }


        // Relación con Alumno 
        public int? AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }

        // Relación con Secretaria 
        public int? SecretariaId { get; set; }
        public Secretaria? Secretaria { get; set; }

        // Relación con Revisor 
        public int? RevisorPropuestaId { get; set; }
        public RevisorPropuesta? RevisorPropuestas { get; set; }
    }
}
