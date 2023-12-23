using Agente.Application;
using Agente.Core.Interfaces;

namespace Agente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFunciones funciones = new AgenteC();
            //IFunciones funciones = new AgenteA();
            //IFunciones funciones = new AgenteB();

            var mainApplication = new MainApplication(funciones);
            mainApplication.Run();
        }
    }
}
