namespace Proyecto.Modelo
{
    public class Proceso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public ICollection<Informe>? Informes { get; set; }


        //Relación con Secretaria 
        public int SecretariaId { get; set; }
        public Secretaria Secretarias { get; set; }

        // Relación con Gestor
        public int? GestorId { get; set; }
        public Gestor? Gestores { get; set; }
    }
}
