namespace Proyecto.Modelo
{
    public class Secretaria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        // Relaciones 
        public ICollection<Propuesta> PropuestasCargadas { get; set; } = new List<Propuesta>();
        public ICollection<Proceso> ProcesosRegistrados { get; set; } = new List<Proceso>();
    }
}
