using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AreaPerimetroDiagonal
{
    internal class Calculadora
    {
        //Círculo 
        public double AreaCirculo(double raio)
        {
            double AreaDoCirculo = Math.PI * Math.Pow(raio, 2);
            return AreaDoCirculo; 
        }
        public double PerimetroCirculo(double raio)
        {
            return 2 * Math.PI * raio; 
        }
        //Quadrado
        public double AreaQuadrado(double lado)
        {
            return Math.Pow(lado, 2); 
        }
        public double PerimetroQuadrado(double lado)
        {
            return 4 * lado; 
        }
        public double DiagonalQuadrado(double lado)
        {
            return lado * Math.Sqrt(2); 
        }
        //Retangulo
        public double AreaRetangulo(double largura, double altura)
        {
            return largura * altura; 
        }

        public double PerimetroRetangulo(double largura, double altura)
        {
            return 2 * (largura + altura); 
        }
        public double DiagonalRetangulo(double largura, double altura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2)); 
        }
        //triângulo
        public double AreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2; 
        }
        public double PerimetroTriangulo(double baseTriangulo, double altura)
        {
            double hipotenusa = Hipotenusa(baseTriangulo, altura);
            return baseTriangulo + altura + hipotenusa; 
        }
        public double Hipotenusa(double baseTriangulo, double altura)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2)); 
        }







    }
}
