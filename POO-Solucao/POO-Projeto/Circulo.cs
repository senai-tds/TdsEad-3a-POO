using FigureControlLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class TCirculo : TFigura
    {
        private double raio;

        public double Raio { get => raio; set => raio = value; }

        public TCirculo(double raio)
        {
            this.raio = raio;
            CalcularArea();
        }

        public TCirculo(double raio, Color cor)
        {
            this.raio = raio;
            Cor = cor;
            CalcularArea();
        }

        public override void CalcularArea()
        {
            Area = Math.PI * raio * raio;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Tipo: " + GetType().Name);
            Console.WriteLine("Cor.: " + Cor.ToString());
            Console.WriteLine("Raio: " + raio);
            Console.WriteLine("Area: " + Area);
        }

        private const string arquivo = "FiguraCirculo.png";
        public override void Desenhar()
        {
            TDesenhista artista = new TDesenhista();

            artista.DesenharCirculo(Cor, (int)raio, arquivo);

            Console.WriteLine(GetType().Name + " salvo no arquivo " + arquivo);
        }

        public override void Exibir()
        {
            Process.Start(Aplicativo, arquivo);
        }
    }
}
