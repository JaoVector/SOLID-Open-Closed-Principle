using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.Interfaces
{
    public interface IValidaTipos<T>
    {
        bool ValidaTipo(T entry);
    }
}