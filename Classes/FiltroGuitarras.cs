using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.Interfaces;
using OCP.Models;

namespace OCP.Classes
{
    public class FiltroGuitarras : IFiltro<Guitarra>
    {
        public List<Guitarra> Filtro(IEnumerable<Guitarra> guitarras, IValidaTipos<Guitarra> valida) => guitarras.Where(x => valida.ValidaTipo(x)).ToList();         
    }
}