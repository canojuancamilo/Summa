using Agente.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agente.Application
{
    internal class MainApplication
    {
        private readonly IFunciones funciones;

        public MainApplication(IFunciones _funciones)
        {
            this.funciones = _funciones;
        }

        public void Run()
        {
            var numbers = new List<double> { 1, 2, 3, 4, 5 };
            var media = funciones.GetMedia(numbers);
            Console.WriteLine($"Media: {media}");

            var staircase = funciones.GetStaircase(4);
            Console.WriteLine("Escalera:");
            Console.WriteLine(staircase);

            Console.WriteLine("\nPresiona una tecla para salir.");
            Console.ReadKey();
        }
    }
}
