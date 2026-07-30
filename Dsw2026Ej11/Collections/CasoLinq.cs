using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public List<Libro> libros = Libro.CrearLista();

    // 1. Obtener el primer libro (GetPrimero)

    public Libro GetPrimero()
    {
        return libros.FirstOrDefault();
    }


    // 2. Obtener el último libro (GetUltimo)

    public Libro GetUltimo()
    {
        return libros.LastOrDefault();
    }

    // 3. Obtener la suma de precios (GetTotalPrecios)

    public decimal GetTotalPrecios()
    {
        decimal precioTotal = 0;
        precioTotal = libros.Sum(libro => libro.Precio);
        return precioTotal;
    }

    // 4. Obtener el promedio de precios (GetPromedioPrecios)

    public decimal GetPromedioPrecios()
    {
        decimal promedioPrecio = 0;
        promedioPrecio = libros.Average(libro => libro.Precio);
        return promedioPrecio;
    }

    // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)

    public List<Libro> GetListById()
    {
        return libros.Where(libro => libro.Id > 15).ToList();
    }

    // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)

    public List<string> GetLibros()
    {
        return libros.Select(libro => $"{libro.Titulo}-${libro.Precio}").ToList();
    }

    // 7. Obtener el libro con el precio más alto (GetMayorPrecio)

    public Libro GetMayorPrecio()
    {
        return libros.OrderByDescending(libro => libro.Precio).FirstOrDefault();
    }

    // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)

    public Libro GetMenorPrecio()
    {
        return libros.OrderByDescending(libro => libro.Precio).LastOrDefault();
    }

    // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = libros.Average(libro => libro.Precio);
        return libros.Where(libro => libro.Precio > promedio).ToList();
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetLibrosOrdenadosPorTituloDescendente()
    {
        return libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}
