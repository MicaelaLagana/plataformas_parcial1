using System;

namespace primerparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ctx = new ParcialDBContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                Id = 1,
                User = "Pepe",
                Clave = "1234",
            });

            ctx.SaveChanges();
        }
    }
}
