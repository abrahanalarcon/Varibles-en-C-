using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar el ejercicio descrito en este apartado:
            string nombre = "Moises";
            string apellido = "Alarcon";
            int edad = 24;
            string sexo = "Masculino";
            string estado_civil = "Soltero";
            string telefono = "829-968-8949";
            string direccion = "San Pedro De Macoris";
            string email = "moises.alarcon@unicaribe.edu.do";
            string estatus = "ONLINE(ACTIVO)";
            Console.Write("Los siguientes datos son los que estan almacenados en la variable: " + '\n');
            Console.WriteLine("Su nombre es " + nombre
                + " " + apellido + '\n' 
                + "Tiene " + edad + '\n' +
             "Sexo: " +sexo  + '\n' + 
             "Su estado civil es: " + estado_civil + '\n' +
             "Su direccion es: "  + direccion  + '\n' +
             "Su email es: " + email + '\n' + 
             "Status: " + estatus  + '\n'
             );

        }
    }
}
