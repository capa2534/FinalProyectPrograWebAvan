using Examen.DataAccess.Data;
using Examen.DataAccess.Repository;
using Examen.DataAccess.Repository.UnitOfWork;
using Examen.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    public class AutoController : Controller
    {

        public AutoController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
        {
            UnitOfWork = unitOfWork;
            Repository = UnitOfWork.Repository<Auto>();
            Context = context;
        }
        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
        readonly IRepository<Auto> Repository;
        IApplicationDbContext Context;


    

        public IActionResult Index(int id = 0)
        {

            return View(Repository.Listar());
        }

        public IActionResult Upsert(int? id)
        {


            Auto Auto
                = new Auto
                {

                };


            if (id == null)
            {
                return View(Auto);
            }

            Auto = Repository.Obtener(id.GetValueOrDefault());
            if (Auto == null)
            {
                return NotFound();
            }

            return View(Auto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Auto Auto)
        {


            if (ModelState.IsValid)
            {
                if (Auto.Id == 0)
                {
                    Auto.Estado = "En Inventario";
                    Repository.Insertar(Auto);

                }
                else
                {
                    Repository.Actualizar(Auto);
                }

                UnitOfWork.Guardar();
                return RedirectToAction(nameof(Index));
            }

            return View(Auto);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var Auto = Repository.Obtener(id);

            if (Auto == null)  //ver esto bien
            {
                return Json(new { success = false, message = $"No se encuentra el Auto con id {id}" });
            }

            Repository.Borrar(Auto);
            UnitOfWork.Guardar();

            return Json(new { success = true, message = "Auto eliminado exitosamente." });
        }
    }
}
