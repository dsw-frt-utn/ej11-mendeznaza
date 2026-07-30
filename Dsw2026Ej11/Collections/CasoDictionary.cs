using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{

    Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumnos(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }

    public Alumno BuscarAlumno(int legajo)
    {

        if (alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
        }
        else
        {
            Console.WriteLine("No existe");
        }

        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return alumnos;
    }

    public void RemoverAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            alumnos.Remove(legajo);
        }
    }
}

