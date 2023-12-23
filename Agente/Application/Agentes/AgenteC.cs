using Agente.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Services.Description;

namespace Agente.Application
{
    public class AgenteC : IFunciones
    {
        public double GetMedia(List<double> numbers)
        {
            //Formula para obetner la mediana
            //1) Ordenar los elementos de manera ascendente o descendente.
            //2)Si el número de elementos es impar, la mediana es el valor en el medio. 
            //Si el número de elementos es par, la mediana es el promedio de los dos valores en el medio.

            List<double> elementosOrdenados = numbers.OrderBy(m => m).ToList();
            double mediana = 0;

            if (elementosOrdenados.Count != 0)
            {
                int indiceMedia = (elementosOrdenados.Count - 1) / 2;

                if (elementosOrdenados.Count % 2 != 0)//es impar
                {
                    mediana = elementosOrdenados[indiceMedia];
                }
                else //es par
                {
                    mediana = (elementosOrdenados[indiceMedia] + elementosOrdenados[indiceMedia + 1]) / 2;
                }
            }

            return mediana;
        }

        public string GetStaircase(int n)
        {
            StringBuilder escalera = new StringBuilder();

            if (n < 100 && n > 0)
            {
                int cantidadColumnasMaximas = (n + 1) * 2;
                int cantidadInicialEspacios = (cantidadColumnasMaximas - n) / 2;

                for (int cantidadColumna = n; cantidadColumna <= cantidadColumnasMaximas; cantidadColumna++)
                {
                    escalera.Append(' ', cantidadInicialEspacios);
                    escalera.Append('#', cantidadColumna);
                    escalera.Append(' ', cantidadInicialEspacios);
                    escalera.AppendLine();
                    cantidadInicialEspacios--;
                    cantidadColumna++;
                }

                cantidadInicialEspacios = 0;

                for (int cantidadColumna = cantidadColumnasMaximas-2; cantidadColumna >= n; cantidadColumna--)
                {
                    cantidadInicialEspacios++;

                    escalera.Append(' ', cantidadInicialEspacios);
                    escalera.Append('#', cantidadColumna);
                    escalera.Append(' ', cantidadInicialEspacios);
                    escalera.AppendLine();
                    cantidadColumna--;
                }
            }

            return escalera.ToString();
        }
    }
}
