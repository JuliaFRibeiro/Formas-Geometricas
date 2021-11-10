using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    class Retangulo : Forma
    {
        //declaraçao de variavel
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            //formula
            return Largura * Altura;
        }
    }
}
