using System;

namespace primerparcial
{
    public class Detalle
    {
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}