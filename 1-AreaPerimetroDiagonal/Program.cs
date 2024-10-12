using _1_AreaPerimetroDiagonal;
using System.Globalization;
using System.Net.Http.Headers;

namespace AreaPerimetroDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Calculadora calculador = new Calculadora();
            Console.WriteLine("Escolha entre está 4 formas basicas: ");
            Console.WriteLine("1-Círculo");
            Console.WriteLine("2-Quadrado");
            Console.WriteLine("3-Retângulo");
            Console.WriteLine("4-triângulo");
            int escolhaDeFormaGeometrica = int.Parse(Console.ReadLine());
            //Círculo
            if (escolhaDeFormaGeometrica == 1)
            {
                Console.Clear();
                Console.WriteLine("Escolha o que vc gostaria de fazer: ");
                Console.WriteLine("1-Area");
                Console.WriteLine("2-Perimetro");             
                int escolhaDeOperação = int.Parse(Console.ReadLine());
                //Area do Círculo
                if(escolhaDeOperação == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o Raio da Circuferença");
                    double raio = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Area do Círculo é {calculador.AreaCirculo(raio).ToString("F2",CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                //Perimetro do Circulo 
                if (escolhaDeOperação == 2)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("Digite o Raio da Circuferença");
                    double raio = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Perimetro do Círculo é {calculador.PerimetroCirculo(raio).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Erro");
                    Task.Delay(2500).Wait();
                    Main(args);
                }          
            }
            //Quadrado 
            if (escolhaDeFormaGeometrica == 2)
            {
                Console.Clear();
                Console.WriteLine("Escolha o que vc gostaria de fazer: ");
                Console.WriteLine("1-Area");
                Console.WriteLine("2-Perimetro");
                Console.WriteLine("3-Diagonal");
                int escolhaDeOperação = int.Parse(Console.ReadLine());
                //Area do Quadrado
                if (escolhaDeOperação == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o Lado do Quadrado");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Area do Quadrado é {calculador.AreaQuadrado(lado).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                //Perimetro do Quadrado 
                if (escolhaDeOperação == 2)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("Digite o Lado do Quadrado");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O Perimetro do Quadrado é {calculador.PerimetroQuadrado(lado).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                // Diagonal do Quadrado 
                else if(escolhaDeOperação == 3)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("Digite o Lado do Quadrado");
                    double lado = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Diagonal do Quadrado  é {calculador.DiagonalQuadrado(lado).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Erro");
                    Task.Delay(2500).Wait();
                    Main(args);
                }
            }
            //Retângulo
            if (escolhaDeFormaGeometrica == 3)
            {
                Console.Clear();
                Console.WriteLine("Escolha o que vc gostaria de fazer: ");
                Console.WriteLine("1-Area");
                Console.WriteLine("2-Perimetro");
                Console.WriteLine("3-Diagonal");
                int escolhaDeOperação = int.Parse(Console.ReadLine());
                //Area do Retângulo
                if (escolhaDeOperação == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("Largura:");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Area do Retângulo é {calculador.AreaRetangulo(largura,altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                //Perimetro do Retângulo 
                if (escolhaDeOperação == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("Largura:");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O Perimetro do Retângulo  é {calculador.PerimetroRetangulo(largura, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                // Diagonal do Retângulo 
                else if (escolhaDeOperação == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("Largura:");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Diagonal do Retângulo  é {calculador.DiagonalRetangulo(largura, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro");
                    Task.Delay(2500).Wait();
                    Main(args);
                }
            }
            //Triângulo
            if (escolhaDeFormaGeometrica == 4)
            {
                Console.Clear();
                Console.WriteLine("Escolha o que vc gostaria de fazer: ");
                Console.WriteLine("1-Area");
                Console.WriteLine("2-Perimetro");
                Console.WriteLine("3-Diagonal");
                int escolhaDeOperação = int.Parse(Console.ReadLine());
                //Area do Triângulo
                if (escolhaDeOperação == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("baseTriangulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Area do Triângulo é {calculador.AreaTriangulo(baseTriangulo, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                //Perimetro do Triângulo 
                if (escolhaDeOperação == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("baseTriangulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O Perimetro do Triângulo   é {calculador.PerimetroTriangulo(baseTriangulo, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                //Hipotenusa
                else if (escolhaDeOperação == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a Altura e Largura do Retângulo");
                    Console.WriteLine("baseTriangulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.WriteLine($"A Hipotenusado Triangulo  é {calculador.Hipotenusa(baseTriangulo, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro");
                    Task.Delay(2500).Wait();
                    Main(args);
                }
            }
            else
            {             
                Main(args);
            }


        }
    }
}