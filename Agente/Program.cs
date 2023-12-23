using Agente.Application;
using Agente.Core.Interfaces;

namespace Agente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFunciones funciones = new AgenteC();

            var mainApplication = new MainApplication(funciones);
            mainApplication.Run();
        }
    }
}
