using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Clsempleados
    {   //constructor
        public  Clsempleados()
        {
            Nombre = "Alejandro";
            SueldoDiario = 25.6m;
            Edad = 25;
        }

        public string Nombre;

        public decimal SueldoDiario;

        public int Edad;

        //metodo

        public decimal CalcularSalario(int numerodias)
        {
            return SueldoDiario * numerodias;
        }
    }
}
