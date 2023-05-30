// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using Aula02;
using System.Drawing;


void Imprimir(TFigura figura)
{
    figura.Imprimir();
    figura.Desenhar();
    figura.Exibir();
}

TFigura figura1 = new TQuadrado(300, Color.BlueViolet);
TFigura figura2 = new TCirculo(150, Color.GreenYellow);

Console.WriteLine("### Dados da Figura 1 ###");
Imprimir(figura1);

Console.WriteLine(" ");
Console.WriteLine("### Dados da Figura 2 ###");
Imprimir(figura2);

Console.Write("pressione uma tecla para finalizar...");
Console.ReadKey();


//((TQuadrado)figura1).Lado = 4;
//((TQuadrado)figura1).Cor = Color.Red;


/*
TFigura figura1 = new TQuadrado();
TFigura figura2 = new TCirculo();

((TQuadrado)figura1).Lado = 4;
((TCirculo)figura2).Raio = 4;

figura1.CalcularArea();
figura2.CalcularArea();

Console.WriteLine("### Areas calculadas ###");
Console.WriteLine("Figura1: " + figura1.Area);
Console.WriteLine("Figura2: " + figura2.Area);
Console.WriteLine(" ");
Console.Write("pressione uma tecla para finalizar...");
Console.ReadLine();
*/














/*
TQuadrado figura = new TQuadrado();

figura.Cor = Color.Red;
figura.Lado = 8;
figura.CalcularArea();

Console.WriteLine("### Area do quadrado ###");
Console.WriteLine("==> Cor informada: " + figura.Cor.ToString());
Console.WriteLine("==> Lado.........: " + figura.Lado);
Console.WriteLine("==> Area.........: " + figura.Area);
Console.WriteLine(" ");
Console.Write("pressione uma tecla para finalizar...");
Console.ReadLine();
*/
