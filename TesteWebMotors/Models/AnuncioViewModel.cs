using System;
using System.Collections.Generic;
using TesteWebMotors.Entidades;

namespace TesteWebMotors.Models
{
    public class AnuncioViewModel
    {
        public TbAnuncioWebmotors Anuncio { get; set; }
        public List<TbAnuncioWebmotors> AnuncioList { get; set; }
    }
}