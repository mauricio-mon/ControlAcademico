using ControlAcademico.Edu.Kinal.Lab.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        List<Persona> listaGeneral = new List<Persona>();
        
        operarRegistro(listaGeneral);
        registrarAsistencia(asistencia);
        operarAsistencia(listaGeneral);

        static void operarRegistro(List<Persona> listaGeneral)
        {
        Alumno alumnoUno = new Alumno("1","monroy","mauricio","ad@gmail.com","2022",10);
        Alumno alumnoDos = new Alumno("2","sandoval","paola","pa@gmail.com","2023",20);
        Profesor profesorUno = new Profesor("1","monroy","mauricio","ad@gmail.com","2323232323",10);
        Profesor profesroDos = new Profesor("2","sandoval","paola","pa@gmail.com","4343434343",20);
            listaGeneral.Add(alumnoUno);
            listaGeneral.Add(alumnoDos);
            listaGeneral.Add(profesorUno);
            listaGeneral.Add(profesroDos);
        }



        static void VerDatos(List<Persona> listaPersonas)
        {
            string identificador = "2022-003";
            Console.WriteLine($"Los datos de la persona identificada con el número : {identificador} es :");

            foreach (Persona elemento in listaPersonas)
            {
                if  (elemento is Alumno && ((Alumno)elemento).Carne == identificador)
                {
                    ((Alumno)elemento).listarMisDatos(elemento);
                }
                else if (elemento is Profesor && ((Profesor)elemento).Cui == identificador)
                {
                    ((Profesor)elemento).listarMisDatos(elemento);
                    
                }
            }               
            
        }
        }

        

    }
}
