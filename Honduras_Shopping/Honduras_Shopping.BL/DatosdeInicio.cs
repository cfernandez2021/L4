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
            nuevoUsuario.Nombre = "Admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("1234");


            var usuarioCarlos = new Usuario();
            usuarioCarlos.Nombre = "Carlos";
            usuarioCarlos.Contrasena = Encriptar.CodificarContrasena("7777");

            var usuarioJona = new Usuario();
            usuarioJona.Nombre = "Jona";
            usuarioJona.Contrasena = Encriptar.CodificarContrasena("1010");

            var usuarioAlex = new Usuario();
            usuarioAlex.Nombre = "Alex";
            usuarioAlex.Contrasena = Encriptar.CodificarContrasena("1111");

            var usuarioAbner = new Usuario();
            usuarioAbner.Nombre = "Abner";
            usuarioAbner.Contrasena = Encriptar.CodificarContrasena("0000");



            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(usuarioAbner);
            contexto.Usuarios.Add(usuarioAlex);
            contexto.Usuarios.Add(usuarioCarlos);
            contexto.Usuarios.Add(usuarioJona);


            base.Seed(contexto);
        }
    }
}
