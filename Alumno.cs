using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestTdeP
{
    class Alumno
    {

        public StreamWriter Hoja_de_vida 
        { 
            get; 
            set; 
        }
        public int calculaEdad(int añoNAC, int mesNAC, int diaNAC) //Método que calcula la edad del alumno
        {
            int edad;
            int AÑO = int.Parse(DateTime.Today.ToString("yyyy"));
            int MES = int.Parse(DateTime.Today.ToString("MM"));
            int DIA = int.Parse(DateTime.Today.ToString("dd"));

            if (MES < mesNAC) //Si el mes de nacimiento es POSTERIOR al mes actual, se evalúa el día. Else, la edad es Año actual menos año de nacimiento
            {
                if (DIA > diaNAC) //Si el día de hoy es POSTERIOR al dia de nacimiento, se añade 1 al resultado de año actual menos año de nacimiento +1
                {
                    edad = AÑO - añoNAC + 1;
                    return edad;
                }
                else //Si el día de hoy es ANTERIOR, se conserva la edad como año actual menos año de nacimiento
                {
                    edad = AÑO - añoNAC;
                    return edad;
                }
            }
            else
            {
                edad = AÑO - añoNAC;
                return edad;
            }
        }

        public string NombreAlumno { get; set; }
        int edad;
       
        public string NacAlumno { get; set; } 

        public string RUT_Alumno { get; set; }

        private int rutAlumno;              //<----------- Hay que desarrollar los métodos que calculen el dígito verif.
        public int RutAlumno 
        { 


            get; 
            set; 
        }

        private int verif_Alumno;
        public int Verif_Alumno 
        {
            get; 
            set; 
        }
        private int edadAlumno;               //<---------- Hay que desarrollar un método que calcule la edad a partir de la fecha de nacimiento.
        public int EdadAlumno
        {
            get { return edadAlumno; }
            set { edadAlumno = edad; }
        }
    }
}
