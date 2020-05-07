using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Models;
using TesteWebMotors.Service;

namespace TesteWebMotors.Entidades
{
    [ViewComponent(Name = "ComboVersion")]
    public partial class ComboVersionViewComponent : ViewComponent
    {
        private readonly APIService APIService;

        public ComboVersionViewComponent(APIService api)
        {
            this.APIService = api;
        }

        public async Task<IViewComponentResult> InvokeAsync(int ModelId)
        {
            ComboViewModel vm = new ComboViewModel();

            var lista = await this.APIService.GetVersions(ModelId);

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

            vm.Id = "select.versao";
            vm.Label = "Selecione uma versão";
            vm.ListaProcessada = ListaProcessada;

            return View("~/Views/Shared/Components/Combo/Default.cshtml", vm);
        }
    }
}
