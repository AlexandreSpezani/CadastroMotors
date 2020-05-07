using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Models;
using TesteWebMotors.Service;

namespace TesteWebMotors.Entidades
{
    [ViewComponent(Name = "ComboMaker")]
    public partial class ComboMakerViewComponent : ViewComponent
    {
        private readonly APIService APIService;

        public ComboMakerViewComponent(APIService api)
        {
            this.APIService = api;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ComboViewModel vm = new ComboViewModel();

            var lista = await this.APIService.GetMakers();

            List<SelectListItem> ListaProcessada = new List<SelectListItem>();

            ListaProcessada.Add(new SelectListItem()
            {
                Text = "Selecione",
                Value = "0"
            });

            foreach (var item in lista)
            {
                ListaProcessada.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.ID.ToString()
                });
            }

            vm.Id = "select.marca";
            vm.Label = "Selecione um Fabricante";
            vm.ListaProcessada = ListaProcessada;

            return View("~/Views/Shared/Components/Combo/Default.cshtml", vm);
        }
    }
}
