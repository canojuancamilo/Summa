using Agente.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agente.Application
{
    public class AgenteA : IFunciones
    {
        public double GetMedia(List<double> numbers)
        {
            // formula para media es: la suma de todos los elementos / la cantidad de elementos
            double totalSuma = numbers.Sum(m => m);
            double mediaAritmetica = totalSuma / numbers.Count;

            return mediaAritmetica;
        }

        public string GetStaircase(int n)
        {
            StringBuilder escalera = new StringBuilder();

            if (n < 100 && n > 0)
            {
                for (int cantidadColumna = 1; cantidadColumna <= n; cantidadColumna++)
                {
                    escalera.Append(' ', n - cantidadColumna);
                    escalera.Append('#', cantidadColumna);
                    escalera.AppendLine();
                }
            }

            return escalera.ToString();
        }
    }
}
