namespace Proyecto.Modelo
{
    public class CoordinadorDeRevision
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Relacion con Informe 
        public ICollection<Informe>? Informes { get; set; }
    }
}
