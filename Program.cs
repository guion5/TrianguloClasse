//inclusão de bibliotecas
using System;
using System.Globalization;
//nome
namespace Course
{
    //atribuição de classe 
    public class Triangulo
    {
        //variáveis da classe
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        
        //função de álculo
        public double CalcularArea()
        {
            //cálculo
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //retorno da área
            return area;
        }
        //chamada da classe
        public class Program
        {
            //programa principal
            public static void Main(string[] args)
            {
                //atribuição de cada triângulo             
                Triangulo x = LerTriangulo("X");
                Triangulo y = LerTriangulo("Y");
                
                //variável de cálculo de cada triângulo
                double areaX = x.CalcularArea();
                double areaY = y.CalcularArea();

                //interface do usuário
                Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

                //condicionais da área dos triângulos
                if (areaX > areaY)
                {
                    //interface do usuário com a área do triângulo X
                    Console.WriteLine("Maior área: X");
                }
                else
                {
                    //interface do usuário com a área do triângulo Y
                    Console.WriteLine("Maior área: Y");
                }
            }
            //chamada de cada novo triângulo
            public static Triangulo LerTriangulo(string nomeTriangulo)
            {
                //atribuição de um novo triângulo à classe triângulo
                Triangulo triangulo = new Triangulo();

                //interface do usuário para imputar as medidas de cada triângulo
                Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":");
                //atribuição de cada medida do triângulo
                triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //retorno do triângulo
                return triangulo;
            }
        }
    }
}
