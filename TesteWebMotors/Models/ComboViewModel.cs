using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TesteWebMotors.Entidades;

namespace TesteWebMotors.Models
{
    public class ComboViewModel
    {
        public string Id { get; set; }
        public string Label { get; set; }

        public IEnumerable<SelectListItem> ListaProcessada { get; set; }
    }
}