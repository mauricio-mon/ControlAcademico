using ControlAcademico.Edu.Kinal.Lab.Entities;

namespace ControlAcademico.Edu.Kinal.Lab.Interfaces
{
    public interface IOperaciones
    {
         public void listarMisDatos(string identificador);
         public bool eliminarAsignatura (string asignatura);

    }
}