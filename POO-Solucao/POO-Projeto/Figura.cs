
using System.Drawing;

namespace Aula02
{
    public abstract class TFigura
    {
        private Color cor;
        private double area;
        private const string aplicativo = "mspaint";

        public Color Cor { get => cor; set => cor = value; }
        public double Area { get => area; protected set => area = value; }

        public static string Aplicativo => aplicativo;

        public abstract void CalcularArea();
        public abstract void Imprimir();
        public abstract void Desenhar();
        public abstract void Exibir();
    }
}
