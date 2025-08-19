using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

/*class Programa
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    static void Main()
    {
        string caminho = @"C:\Users\Aluno\Downloads\rato1.jpeg";
        Process.Start(new ProcessStartInfo(caminho) { UseShellExecute = true });


        MessageBox(IntPtr.Zero, "TROPA DO RATÃO", "Minha janela", 0);
    }
}


//namespace Atividade_dia_18
//{
//    internal class Program
//    {
//        static void Main(string[] args) {
//            Console.WriteLine("Digite o lado do cubo");
//            double a = Convert.ToDouble(Console.ReadLine());
//            double resultado = Math.Pow(a,a);
//            Console.WriteLine(resultado);
//    }
//}

namespace Atividade_dia_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da circunferência");
            double a = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Math.Pow(a, 2);
            double AreaArredondada = Math.Round(Area, 2);
            Console.WriteLine($"A area do circulo é: {Area:F4}, Proveniente do raio: " + a + " E a área arredondada é " + AreaArredondada);
            if (AreaArredondada > 32)
            {
                if (AreaArredondada < 35)
                {
                    Console.WriteLine("Resultado 1");
                }
                else
                {
                    Console.WriteLine("Resultado 2");
                }
            }
            if (AreaArredondada < 32)
            {
                for (double i = AreaArredondada; i < 32.0; i++)
                {
                    Console.WriteLine("A contagem da area é " + i);
                }
            }

        }
    
        
    }
}

*/
//Desafio 1

/*namespace Atividade_dia_18
{
    internal class OrdenacaoNumeros
    {
        static void Main()
        {
            Console.WriteLine("Digite 3 numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int[] numeros = [numero1, numero2, numero3];
            Array.Sort(numeros);
            foreach (int numero in numeros)
            {
                Console.WriteLine("A ordem do menor para o maior é : " + numero);
            }
        }
    }

}
//Desafio 2 
namespace Atividade_dia18_Jean
{
    internal class BancoDeNotas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor");
            int valor = Convert.ToInt32(Console.ReadLine());
            int notas100 = valor / 100;
            int restante = valor % 100;

            int notas50 = restante / 50;
            restante = restante % 50;

            int notas20 = restante / 20;
            restante = restante % 20;

            int notas10 = restante / 10;
            restante = restante % 10;

            int notas5 = restante / 5;
            restante = restante % 5;

            int notas1 = restante;

            void imprimirNota(int quantidade, int valorNota)
            {
                if (quantidade > 0)
                {
                    string texto = quantidade > 1 ? "Nota" : "Notas";
                    Console.WriteLine($"{quantidade} de {valorNota}");
                }
            }
            Console.WriteLine($"Para sacar R${valor}, você precisará de:");
            imprimirNota(notas100, 100);
            imprimirNota(notas50, 50);  
            imprimirNota(notas20, 20);  
            imprimirNota(notas10, 10); 
            imprimirNota(notas5, 5);
            imprimirNota(notas1, 1);
        }
        
    }

}


//Desafio 3
namespace Atividade_dia18_Jean
{
    internal class PrimoChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para descobrir se é primo ou não");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 1 == 0 && numero % numero == 0)
            {
                bool Primo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        Primo = false;
                        break;
                    }
                }
                if (Primo && numero > 1)
                {
                    Console.WriteLine("O número " + numero + " é primo.");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " não é primo.");
                }
            }
            else
            {
                Console.WriteLine("O número deve ser maior que 1.");
            }

        }
    }
}
*/