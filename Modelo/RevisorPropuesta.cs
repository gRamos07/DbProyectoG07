namespace Proyecto.Modelo
{
    public class RevisorPropuesta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relacion con Propuesta
        public ICollection<Propuesta>? PropuestasRevisadas { get; set; }
    }
}
