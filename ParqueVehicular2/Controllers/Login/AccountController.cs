using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParqueVehicular2.Data;
using System.Linq;

namespace ParqueVehicular2.Controllers.Login
{
    public class AccountController : Controller
    {
        private readonly ParqueVehicularDBContext _context;

        public AccountController(ParqueVehicularDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public string login(string user, string contrasena)
        {
            string Respuesta = "";

            //Hash

            //var res =  _context.Usuarios.Where(u => u.Email == user
            //                     && u.PasswordHash == contrasena) 
            //    .FirstOrDefault();


            var res = _context.Usuarios
                             .Where(u => u.Email == user
                                && u.PasswordHash == contrasena)
                             //.Include(r => r.UsuariosRoles)
                             .FirstOrDefault();


            var Id = res.Id;

            var nom = res.Nombres;

            HttpContext.Session.SetInt32("UserId",Id);
            HttpContext.Session.SetString("NombreUser", nom);

            //var rol = _context.UsuariosRoles.Where(r=> r.UsuarioId == UserId);
            //var idres = HttpContext.Session.GetInt32("UserId");


            if (res != null){
               Respuesta = "ok";
            }

            return Respuesta;
        }


    }
}
