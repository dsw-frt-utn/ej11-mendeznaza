using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
 
    public static void EjemploList()
    {
      
        CasoList casoListas = new CasoList();
        Alumno alumno1 = new Alumno(1, "Juan", 10);
        Alumno alumno2 = new Alumno(5, "Maria", 4);
        Alumno alumno3 = new Alumno(7, "Pedro", 6);

        Console.WriteLine("Agregado de Alumnos");
        //Agregar 3 alumnos a la lista
        casoListas.AgregarAlumnos(alumno1);
        casoListas.AgregarAlumnos(alumno2);
        casoListas.AgregarAlumnos(alumno3);
        Console.WriteLine("");

        Console.WriteLine("Listado de Alumnos");
        //Listar por consola los alumnos
        foreach (Alumno alumno in casoListas.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("");

        Console.WriteLine("Retorno de Juan");
        //Buscar por nombre un alumno que exista y mostrar por consola
        casoListas.RetornarAlumno("Juan");
        Console.WriteLine("");

        Console.WriteLine("Retorno de No existe");
        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        casoListas.RetornarAlumno("Mario");
        Console.WriteLine("");

        Console.WriteLine("Eliminado de Alumno Pedro");
        //Eliminar un alumno y listar por consola los alumnos
        casoListas.EliminarAlumnos(alumno3);

        foreach (Alumno alumno in casoListas.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("");

        Console.WriteLine("Eliminado de Alumno Maria");
        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        casoListas.EliminarAlumnosPorIndice(1);

        foreach (Alumno alumno in casoListas.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("");
    }

   
    public static void EjemploDictionary()
    {
        CasoDictionary casoDic = new CasoDictionary();

        //Agregar 3 alumnos al diccionario
        casoDic.AgregarAlumnos(new Alumno(58999, "Ian", 5));
        casoDic.AgregarAlumnos(new Alumno(63245, "Martina", 10));
        casoDic.AgregarAlumnos(new Alumno(61225, "Miguel", 7));

        //Listar por consola los alumnos
        Console.WriteLine("Listado de alumnos");
        foreach (Alumno alumno in casoDic.RetornarDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("");

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("Alumno por clave");
        Alumno alu = casoDic.BuscarAlumno(58999);
        Console.WriteLine(alu);
        Console.WriteLine("");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("Alumno por clave No Existe");
        Alumno alumnobuscado = casoDic.BuscarAlumno(55555);
        Console.WriteLine(alumnobuscado);
        Console.WriteLine("");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("Eliminar un alumno por clave");
        casoDic.RemoverAlumno(61225);
        foreach (Alumno alumno in casoDic.RetornarDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("");
    }

   
 
    public static void EjemploLinq()
    {
        //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
        // Instanciamos la clase donde creamos los métodos de LINQ
        CasoLinq casoLinq = new CasoLinq();

        // 1. Obtener el primer libro (GetPrimero)
        Libro primero = casoLinq.GetPrimero();
        Console.WriteLine($"1. Primer libro: {primero.Id} - {primero.Titulo} - {primero.Precio:C2}");
        Console.WriteLine("");

        // 2. Obtener el último libro (GetUltimo)
        Libro ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"2. Último libro: {ultimo.Id} - {ultimo.Titulo} - {ultimo.Precio:C2}");
        Console.WriteLine("");

        // 3. Obtener la suma de precios (GetTotalPrecios)
        decimal totalPrecios = casoLinq.GetTotalPrecios();
        Console.WriteLine($"3. Suma total de todos los precios: {totalPrecios:C2}");
        Console.WriteLine("");

        // 4. Obtener el promedio de precios (GetPromedioPrecios)
        decimal promedioPrecios = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"4. Promedio de precios de los libros: {promedioPrecios:C2}");
        Console.WriteLine("");

        // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
        List<Libro> librosIdMayor15 = casoLinq.GetListById();
        Console.WriteLine($"5. Libros con ID mayor a 15 (Total encontrados: {librosIdMayor15.Count}):");
        foreach (var libro in librosIdMayor15)
        {
            Console.WriteLine($"ID: {libro.Id} - {libro.Titulo}");
        }
        Console.WriteLine("");

        // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros)
        Console.WriteLine("6. Muestra de libros:");
        List<string> todosLibros = casoLinq.GetLibros();
        foreach (string libro in todosLibros)
        {
            Console.WriteLine(libro);
        }
        Console.WriteLine("");

        // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
        Libro masCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"7. Libro más costoso:{masCaro.Titulo} ({masCaro.Precio:C2})");
        Console.WriteLine("");

        // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
        Libro masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"8. Libro más económico:{masBarato.Titulo} ({masBarato.Precio:C2})");
        Console.WriteLine("");

        // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
        List<Libro> sobreElPromedio = casoLinq.GetMayorPromedio();
        Console.WriteLine($"9. Libros que superan el promedio de {promedioPrecios:C2}:");
        foreach (Libro libro in sobreElPromedio)
        {
            Console.WriteLine($" {libro.Titulo} - {libro.Precio:C2}");
        }
        Console.WriteLine("");

        // 10. Obtener los libros ordenados por título de forma descendente
        List<Libro> ordenadosDesc = casoLinq.GetLibrosOrdenadosPorTituloDescendente();
        Console.WriteLine("10. Libros ordenados alfabéticamente (Z-A):");
        foreach (Libro libro in ordenadosDesc)
        {
            Console.WriteLine($" {libro.Id}- {libro.Titulo}");
        }

    }
}
