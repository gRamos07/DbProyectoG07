namespace Proyecto.Modelo
{
    public class Gestor
    {
            public int Id { get; set; }
            public string Nombre { get; set; }

            // Relacion con Proceso
            public ICollection<Proceso>? Procesos { get; set; } // Relación uno-a-muchos con Proceso

    }
}
