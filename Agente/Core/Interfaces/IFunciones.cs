using System.Collections.Generic;

namespace Agente.Core.Interfaces
{
    public interface IFunciones
    {
        string GetStaircase(int n);

        double GetMedia(List<double> numbers);
    }
}
