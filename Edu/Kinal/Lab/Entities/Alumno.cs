using ControlAcademico.Edu.Kinal.Lab.Interfaces;
namespace ControlAcademico.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCredito { get; set; }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }

        public void listarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public bool eliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de {this.Apellidos} {this.Apellidos}, perdera la cantidad de creditos {this.NumeroCredito}")
            return true;
        }

        public Alumno() : base()
        {

        }

        public Alumno(string uuid, string apellidos, string nombres, string mail, string carne, int numeroCredito)
            :base(uuid, apellidos, nombres, mail)
        {
            this.Carne = carne;
            this.NumeroCredito = numeroCredito;

        }
    }
}