using Gen2_MVCUsuarios.Data;
using Gen2_MVCUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Gen2_MVCUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        public ApplicationDbContext contexto { get; set; }
        public UsuarioController(ApplicationDbContext _context)
        {
            contexto = _context;
        }

        public IActionResult Index()
        {
            //Obtener el listado de usuarios 👇
            IEnumerable<Usuarios> listado = contexto.Usuarios.ToList();
            return View(listado);
        }


        //Peticiones http
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            //Elimina los registros de la base de datos 👇
            contexto.Usuarios.Remove(contexto.Usuarios.Find(id));
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Usuarios user)
        {
            if (ModelState.IsValid)
            {
                contexto.Usuarios.Update(user);
                contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit", user);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Equivalente a GetByID 👇
            Usuarios u = contexto.Usuarios.Find(id);
            if (u == null)
            {
                return NotFound();
            }
            return View(u);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Equivalente a GetByID 👇
            Usuarios u = contexto.Usuarios.Find(id);
            if (u == null)
            {
                return NotFound();
            }

            return View(u);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Insert(Usuarios user)
        {
            if (ModelState.IsValid)
            {
                //Insertar el registro en la BD 👇
                //EF
                contexto.Usuarios.Add(user);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", user);
        }
    }
}
