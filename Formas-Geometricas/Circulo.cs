using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    class Circulo : Forma
    {
        //declaraçao de variavel
        public double Raio { get; set; }
        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
            Color = cor;
        }
        public override double Area()
        {
            //formula
            return Math.PI * Raio * Raio;
        }
    }
}
