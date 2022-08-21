using Examen.DataAccess.Data;
using Examen.DataAccess.Repository;
using Examen.DataAccess.Repository.UnitOfWork;
using Examen.Models.DataModels;
using Examen.Models.InputModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class ClienteController : Controller
    {

        public ClienteController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
        {
            UnitOfWork = unitOfWork;
            Repository = UnitOfWork.Repository<Cliente>();
            Context = context;
        }
        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
        readonly IRepository<Cliente> Repository;
        IApplicationDbContext Context;

        public IActionResult Index(int id = 0)
        {

            return View(Repository.Listar());
        }

        public IActionResult Upsert(int? id)
        {


            Cliente Cliente
                = new Cliente
                {

                };


            if (id == null)
            {
                return View(Cliente);
            }

            Cliente = Repository.Obtener(id.GetValueOrDefault());
            if (Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Cliente Cliente)
        {


            if (ModelState.IsValid)
            {
                if (Cliente.Id == 0)
                {
                    Repository.Insertar(Cliente);

                }
                else
                {
                    Repository.Actualizar(Cliente);
                }

                UnitOfWork.Guardar();
                return RedirectToAction(nameof(Index));
            }

            return View(Cliente);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var Cliente = Repository.Obtener(id);

            if (Cliente == null)  //ver esto bien
            {
                return Json(new { success = false, message = $"No se encuentra el Cliente con id {id}" });
            }

            Repository.Borrar(Cliente);
            UnitOfWork.Guardar();

            return Json(new { success = true, message = "Cliente eliminado exitosamente." });
        }
    }
}
