using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honduras_Shopping.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena ("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario1.Nombre = "Carlosf";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "Alexp";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "Abnerb";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario4 = new Usuario();
            nuevoUsuario4.Nombre = "Asbels";
            nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var nuevoUsuario5 = new Usuario();
            nuevoUsuario5.Nombre = "Carlosl";
            nuevoUsuario5.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
    }
}
