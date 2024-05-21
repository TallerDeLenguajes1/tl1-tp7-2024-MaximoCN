using System.Runtime.CompilerServices;

namespace EmpleadosEscpacio;

class Empleados{
     
       private string nombre;
       private string apellido;

       private DateTime fechanac;

       private char estadoCivil;

       private DateTime FechaIng;

       private double Sueldo;

       private Cargos cargo;
       public enum cargo{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
       }
        



}