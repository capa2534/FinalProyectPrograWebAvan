using Examen.DataAccess.Data;
using Examen.DataAccess.Repository;
using Examen.DataAccess.Repository.UnitOfWork;
using Examen.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Examen.Controllers
{
    public class VentasController : Controller
    {
        public VentasController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
        {
            UnitOfWork = unitOfWork;
            Repository = UnitOfWork.Repository<Ventas>();
            Context = context;
        }
        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
        readonly IRepository<Ventas> Repository;
        IApplicationDbContext Context;

        public IActionResult Index(int id = 0)
        {

            return View(Repository.Listar());
        }

        public IActionResult Upsert(int? id)
        {


            Ventas Ventas
                = new Ventas
                {

                };


            if (id == null)
            {
                return View(Ventas);
            }

            Ventas = Repository.Obtener(id.GetValueOrDefault());
            if (Ventas == null)
            {
                return NotFound();
            }

            return View(Ventas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Ventas Ventas)
        {


            if (ModelState.IsValid)
            {
                if (Ventas.Id == 0)
                {
                    Repository.Insertar(Ventas);

                }
                else
                {
                    Repository.Actualizar(Ventas);
                }

                UnitOfWork.Guardar();
                return RedirectToAction(nameof(Index));
            }

            return View(Ventas);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var Ventas = Repository.Obtener(id);

            if (Ventas == null)  //ver esto bien
            {
                return Json(new { success = false, message = $"Error con id {id}" });
            }

            Repository.Borrar(Ventas);
            UnitOfWork.Guardar();

            return Json(new { success = true, message = "Eliminado exitosamente." });
        }

        [HttpGet]
        [Route("api/ventas/cliente")]
        public IActionResult ListarCliente(int cliente)
        {
            List<Ventas> Ventas =
                Context.Ventas.Where(w => w.Id_Auto.Id == cliente).ToList();

            var contentido =
                new
                {
                    success = Ventas != null || Ventas.Count == 0 , 
                    content = Ventas,
                    error =
                        Ventas == null || Ventas.Count == 0
                            ? "No se han encontrado clientes registrados"
                            : string.Empty
                };

            return Json(contentido);
        }
    }
}
