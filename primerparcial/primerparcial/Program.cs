using System;
using System.Linq;

namespace primerparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            UserPost("Pepe", "1234");
            UserPost("Moni", "4321");
            UserPost("Paola", "1222");
            UserPost("Coqui", "3241");

            GetUsers();

            PutUser(1, "Pepe", "Dardo");
            PutUserByID(2, "Maria Elena");
            PutUserByUsername("Paola", "La nena");

            GetUsers();

            DeleteUser(4);

        }

        static void UserPost(string user, string clave)
        {
            var ctx = new ParcialDBContext();

            ctx.Usuarios.Add(new Usuario
            {
                User = user,
                Clave = clave
            });

            ctx.SaveChanges();
        }

        static void TareaPost(string titulo, DateTime vto, int estimacion, Recurso responsable, bool estado)
        {
            var ctx = new ParcialDBContext();

            ctx.Tareas.Add(new Tarea
            {
                Titulo = titulo,
                Vencimiento = vto,
                Estimacion = estimacion,
                Responsable = responsable,
                Estado = estado
            });

            ctx.SaveChanges();
        }

        static void GetUsers()
        {
            var ctx = new ParcialDBContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.User} ({item.Id})");
            }
        }

        static void PutUserByID(int id, string newUser)
        {
            var ctx = new ParcialDBContext();
         
            var user = ctx.Usuarios.Where(i => i.Id == id).FirstOrDefault();
            if (user != null)
            {
                user.User = newUser;
            }
            ctx.SaveChanges();
        }

        static void PutUserByUsername(string user, string newUser)
        {
            var ctx = new ParcialDBContext();

            var row = ctx.Usuarios.Where(i => i.User == user).FirstOrDefault();
            if (row != null)
            {
                row.User = newUser;
            }
            ctx.SaveChanges();
        }

        static void PutUser(int Id, string user, string newUser)
        {
            var ctx = new ParcialDBContext();

            var row = ctx.Usuarios.Where(i => i.User == user && i.Id == Id).FirstOrDefault();
            if (row != null)
            {
                row.User = newUser;
            }
            ctx.SaveChanges();
        }

        static void DeleteUser(int id)
        {
            var ctx = new ParcialDBContext();
            var user = ctx.Usuarios.Where(i => i.Id == id).Single();
            ctx.Usuarios.Remove(user);
            ctx.SaveChanges();
        }
    }
}
