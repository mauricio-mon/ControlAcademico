using ControlAcademico.Edu.Kinal.Lab.Interfaces;
namespace ControlAcademico.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string Cui { get; set; }
        public string Cargo { get; set; }

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
            Console.WriteLine($"Se ha eliminado la asignatura {this.Apellidos} {this.Nombres}");
        }

        public Profesor(): base()
        {

        }
        public Profesor(string uuid, string apellidos, string nombres, string mail, string cui, string cargo)
            :base(uuid, apellidos, nombres, mail)
            {
                this.Cui = cui;
                this.Cargo = cargo;
            }
    }
}