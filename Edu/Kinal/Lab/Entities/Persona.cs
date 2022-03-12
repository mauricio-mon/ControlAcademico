
using ControlAcademico.Edu.Kinal.Lab.Interfaces;

namespace ControlAcademico.Edu.Kinal.Lab.Entities
{
    public abstract class Persona 
    {
        public string Uuid {get; set; }
        public string Apellidos {get; set; }
        public string Nombres {get; set; }
        public string Mail {get; set; }

        public abstract void TomarAsistencia();

        public Persona()
        {

        }

        public Persona(string uuid, string apellidos, string nombres, string mail)
        {
            this.Uuid = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Mail = mail;
        }

    }
}