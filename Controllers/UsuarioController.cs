using Microsoft.AspNetCore.Mvc;
using PRACTICA2.Data;
using PRACTICA2.Models;

namespace PRACTICA2.Controllers
{
    public class UsuarioController : Controller
    {
          private UsuarioContext _context;
        public UsuarioController(UsuarioContext context)
        {
            _context = context;
        }
         public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Usuario p) {
            if (ModelState.IsValid) {
                
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            
            return View(p);
        }

    }
}