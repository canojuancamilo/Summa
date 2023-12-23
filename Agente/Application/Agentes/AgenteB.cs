using Agente.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agente.Application
{
    public class AgenteB : IFunciones
    {
        public double GetMedia(List<double> numbers)
        {
            //Formula de media armonica cantidad de elementos / ((1/valor elemento 1) + (1/valor elemento 2)...)
            double mediaArmonica = numbers.Count / numbers.Sum(x => 1 / x);

            return mediaArmonica;
        }

        public string GetStaircase(int n)
        {
            StringBuilder escalera = new StringBuilder();

            if (n < 100 && n > 0)
            {
                for (int cantidadColumna = n; cantidadColumna >= 1; cantidadColumna--)
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
