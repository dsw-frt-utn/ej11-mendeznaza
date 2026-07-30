using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> Alumnos = new List<Alumno>();
    public void AgregarAlumnos(Alumno alumnoNuevo)
    {
        Alumnos.Add(alumnoNuevo);
    }

    public List<Alumno> RetornarLista()
    {
        return Alumnos;
    }

    public void RetornarAlumno(String alumnoBuscado)
    {
        Alumno alumnoExistente = null;

        foreach (Alumno alumno in Alumnos)
        {
            if (alumno.Nombre.Equals(alumnoBuscado))
            {
                alumnoExistente = alumno;
            }
        }

        if (alumnoExistente != null)
        {
            Console.WriteLine(alumnoExistente);
        }
        else
        {
            Console.WriteLine("No existe");
        }
    }

    public void EliminarAlumnos(Alumno alumnoNuevo)
    {
        Alumnos.Remove(alumnoNuevo);
    }

    public void EliminarAlumnosPorIndice(int indexAlumno)
    {
        Alumnos.RemoveAt(indexAlumno);
    }
}
