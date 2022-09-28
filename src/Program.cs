using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();
            
            //Para forcar rodar as migrações ao subir a aplicacao
            //db.Database.Migrate();

            var existe = db.Database.GetPendingMigrations().Any();

            if (existe)
            {
                //sair da aplicacao
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}