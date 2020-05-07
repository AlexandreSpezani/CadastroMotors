using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TesteWebMotors.Context;
using TesteWebMotors.Entidades;
using TesteWebMotors.Models;
using TesteWebMotors.Service;
using TesteWebMotors.Util;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteWebMotors.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly Constantes CONSTANTES;
        private readonly teste_webmotorsContext db;
        private readonly APIService APIService;

        public AnuncioController(Constantes constantes, teste_webmotorsContext context, APIService apiservice)
        {
            this.CONSTANTES = constantes;
            this.db = context;
            this.APIService = apiservice;
        }

        public async Task<IActionResult> Index()
        {
            AnuncioViewModel vm = new AnuncioViewModel();

            vm.AnuncioList = db.TbAnuncioWebmotors.ToList();

            return View(vm);
        }

        public async Task<IActionResult> Salvar(TbAnuncioWebmotors anuncio)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            this.db.TbAnuncioWebmotors.Add(anuncio);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Excluir(int id)
        {
            TbAnuncioWebmotors item = db.TbAnuncioWebmotors.Where(x => x.Id == id).FirstOrDefault();

            db.TbAnuncioWebmotors.Remove(item);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            AnuncioViewModel vm = new AnuncioViewModel();

            vm.Anuncio = db.TbAnuncioWebmotors.FirstOrDefault(x => x.Id == id);

            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(TbAnuncioWebmotors anuncio)
        {
            db.TbAnuncioWebmotors.Update(anuncio);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ComboModel(int makerId)
        {
            return ViewComponent("ComboModel", makerId);
        }

        public IActionResult ComboVersion(int modelId)
        {
            return ViewComponent("ComboVersion", modelId);
        }

    }
}
