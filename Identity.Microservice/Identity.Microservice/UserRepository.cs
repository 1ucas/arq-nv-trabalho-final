using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Microservice
{
    public class UserRepository
    {
        public List<User> Usuarios { get; set; }

        public UserRepository()
        {
            Usuarios = new List<User>();
            Usuarios.Add(new User(1, "Usuario1", "Password1", "email1@email.com", "Nome Usuario 1"));
            Usuarios.Add(new User(2, "Usuario2", "Password2", "email2@email.com", "Nome Usuario 2"));
            Usuarios.Add(new User(3, "Usuario3", "Password3", "email3@email.com", "Nome Usuario 3"));
        }
    }
}
