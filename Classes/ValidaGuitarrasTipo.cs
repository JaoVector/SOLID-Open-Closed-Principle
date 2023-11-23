using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.Interfaces;
using OCP.Models;

namespace OCP.Classes
{
    public class ValidaGuitarrasTipo : IValidaTipos<Guitarra>
    {
        private readonly TiposGuitarras _guitas;
        public ValidaGuitarrasTipo(TiposGuitarras tipos)
        {
            _guitas = tipos;
        }

        public bool ValidaTipo(Guitarra guitarra) => guitarra.Tipo == _guitas;
    }
}