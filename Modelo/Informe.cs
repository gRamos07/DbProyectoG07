namespace Proyecto.Modelo
{
    public class Informe
    {
        public int Id { get; set; }
        public string Detalles { get; set; }

        // Relación con Proceso
        public int ProcesoId { get; set; }
        public Proceso? Procesos { get; set; }

        // Relación con Coordinador
        public int CoordinadorDeRevisionId { get; set; }
        public CoordinadorDeRevision? CoordinadorDeRevisiones { get; set; }
    }
}
