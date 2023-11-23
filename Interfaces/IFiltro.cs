using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.Interfaces
{
    public interface IFiltro<T>
    {
        List<T> Filtro(IEnumerable<T> guitarras, IValidaTipos<T> valida);
    }

}