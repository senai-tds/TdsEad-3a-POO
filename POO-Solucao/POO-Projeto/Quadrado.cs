
using FigureControlLibrary;
using System.Diagnostics;
using System.Drawing;

namespace Aula02
{
    public class TQuadrado : TFigura
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        // construtores
        public TQuadrado() 
        { 
        }

        public TQuadrado(double lado)
        {
            this.lado = lado;
            CalcularArea();
        }

        public TQuadrado(double lado, Color cor)
        {
            this.lado = lado;
            Cor = cor;
            CalcularArea();
        }

        public override void CalcularArea()
        {
            Area = lado * lado;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Tipo: " + GetType().Name);
            Console.WriteLine("Cor.: " + Cor.ToString());
            Console.WriteLine("Lado: " + lado);
            Console.WriteLine("Area: " + Area);
        }

        private const string arquivo = "FiguraQuadrado.png";

        public override void Desenhar()
        {
            TDesenhista artista = new TDesenhista();

            artista.DesenharQuadrado(Cor, (int)lado, arquivo);

            Console.WriteLine(GetType().Name + " salvo no arquivo " + arquivo);
        }

        public override void Exibir()
        {
            Process.Start(Aplicativo, arquivo);
        }
    }
}
