

using OCP.Classes;
using OCP.Interfaces;
using OCP.Models;

var listaGuitarras = new List<Guitarra>()
{
    new Guitarra() { Nome = "Telecaster X10", Tipo = TiposGuitarras.Telecaster, Marca = Marcas.Fender },
    new Guitarra() { Nome = "Les Paul Classic", Tipo = TiposGuitarras.LesPaul, Marca = Marcas.Gibson },
    new Guitarra() { Nome = "Super Fender", Tipo = TiposGuitarras.Strato, Marca = Marcas.Fender },
    new Guitarra() { Nome = "CGR121", Tipo = TiposGuitarras.Superstrato, Marca = Marcas.Ibanez },
    new Guitarra() { Nome = "Fender 2000", Tipo = TiposGuitarras.Superstrato, Marca = Marcas.Fender },
    new Guitarra() { Nome = "GIORG 131", Tipo = TiposGuitarras.Superstrato, Marca = Marcas.Ibanez },
    new Guitarra() { Nome = "Solar X5", Tipo = TiposGuitarras.Strato, Marca = Marcas.Solar },
    new Guitarra() { Nome = "Telecaster X", Tipo = TiposGuitarras.Telecaster, Marca = Marcas.Solar },
    new Guitarra() { Nome = "Les Paul Vintage", Tipo = TiposGuitarras.LesPaul, Marca = Marcas.Gibson },
    new Guitarra() { Nome = "Les Paul GFender", Tipo = TiposGuitarras.LesPaul, Marca = Marcas.Fender },
    new Guitarra() { Nome = "Telecaster 231", Tipo = TiposGuitarras.Telecaster, Marca = Marcas.Solar },
};


var filtro = new FiltroGuitarras();

var fenders = filtro.Filtro(listaGuitarras, new ValidaGuitarrasMarca(Marcas.Fender));
foreach (var fender in fenders)
{
    Console.WriteLine($"Nome: {fender.Nome}, Tipo: {fender.Tipo}, Marca: {fender.Marca}");
}

Console.WriteLine("===============================================================================");

var superstratos = filtro.Filtro(listaGuitarras, new ValidaGuitarrasTipo(TiposGuitarras.Superstrato));
foreach (var super in superstratos)
{
    Console.WriteLine($"Nome: {super.Nome}, Tipo: {super.Tipo}, Marca: {super.Marca}");
}
