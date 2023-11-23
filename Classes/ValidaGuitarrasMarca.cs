using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.Interfaces;
using OCP.Models;

namespace OCP.Classes
{
    public class ValidaGuitarrasMarca : IValidaTipos<Guitarra>
    {
        private readonly Marcas _marcas;

        public ValidaGuitarrasMarca(Marcas marcas)
        {
            _marcas = marcas;
        }

        public bool ValidaTipo(Guitarra guitarra) => guitarra.Marca == _marcas; 
    }
}