using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel.Cat.MatGrafics
{
    interface IElementGrafic
    {
        string IdTipo { get; }
        double ValorX { get; }
        double ValorY { get; }
    }
}
