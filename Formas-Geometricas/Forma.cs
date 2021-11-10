using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    abstract class Forma
    {
        //declaraçao de variavel
        public Color Color { get; set; }
        public Forma(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
