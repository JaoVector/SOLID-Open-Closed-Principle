using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.Classes;

namespace OCP.Models
{
    public class Guitarra
    {
        public string? Nome { get; set; }
        public TiposGuitarras Tipo { get; set; }
        public Marcas Marca { get; set; }
    }
}