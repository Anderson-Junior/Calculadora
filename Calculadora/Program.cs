using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Escolha qual operação deseja fazer:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");

            double opcao = double.Parse(Console.ReadLine());
            Calculadora calc = new Calculadora();

            if(opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
            {
                Console.Write("Digite o primeiro valor: ");
                calc.A = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                calc.B = double.Parse(Console.ReadLine());

                try
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Resultado: {0} + {1} = {2}", calc.A, calc.B, calc.Somar(calc.A, calc.B).ToString("F2"));
                            break;

                        case 2:
                            Console.WriteLine("Resultado: {0} - {1} = {2}", calc.A, calc.B, calc.Subtrair(calc.A, calc.B).ToString("F2"));
                            break;

                        case 3:
                            Console.WriteLine("Resultado: {0} * {1} = {2}", calc.A, calc.B, calc.Multiplicar(calc.A, calc.B).ToString("F2"));
                            break;

                        case 4:
                            Console.WriteLine("Resultado: {0} / {1} = {2}", calc.A, calc.B, calc.Dividir(calc.A, calc.B).ToString("F2"));
                            break;

                        default:
                            break;
                    }
                } 
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Opção invalida, preciose qualquer tecla para sair!");
                Console.ReadLine();
            }
        }
    }
}
