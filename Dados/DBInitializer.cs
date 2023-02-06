using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using p2.Models;

namespace p2.Dados
{
    public class DBInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.Database.EnsureCreated())
            {
                //Criar usuário admin
                context.Usuarios.Add(
                    new Usuario
                    {
                        Nome = "Administrador",
                        Login = "admin",
                        Senha = "123"
                    });
                context.SaveChanges();
            }
        }
    }
}
