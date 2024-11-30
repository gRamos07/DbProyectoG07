namespace Proyecto.Modelo
{
    public class Alumno
    {
        public int Id { get; set; }
        public int cedula { get; set; }
        public string Nombre { get; set; }
        public string Correcion { get; set; }

        //Relacion con Propuestas
        public ICollection<Propuesta> PropuestasACorregir { get; set; } = new List<Propuesta>();

    }
}
