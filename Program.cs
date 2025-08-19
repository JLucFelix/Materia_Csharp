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

/*namespace Atividade_dia_18
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

//namespace Atividade_dia_18
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite 3 numeros");
//            int numero1 = Convert.ToInt32(Console.ReadLine());
//            int numero2 = Convert.ToInt32(Console.ReadLine());
//            int numero3 = Convert.ToInt32(Console.ReadLine());
//            int[] numeros = [numero1, numero2, numero3];
//            Array.Sort(numeros);
//            foreach (int numero in numeros)
//            {
//                Console.WriteLine("A ordem do menor para o maior é : "+ numero);
//            }
//        }
//    }

//}
//Desafio 2 
namespace Atividade_dia_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor");
            int valor = Convert.ToInt32(Console.ReadLine());
            int notas100 = valor / 100;
            int restante = valor % 100;

            int notas50 = valor / 50;
            restante = valor % 50;

            int notas20 = valor / 20;
            restante = valor % 20;

            int notas10 = valor / 10;
            restante = valor % 10;

            int notas5 = valor / 5;
            restante = valor % 5;

            int notas1 = restante;

            if(notas100 > 0) Console.WriteLine("Notas de 100 " + notas100);
            if(notas50  > 0) Console.WriteLine("Notas de 50 " + notas50);
            if (notas20 > 0) Console.WriteLine("Notas de 20 " + notas20);
            if (notas10 > 0) Console.WriteLine("Notas de 10 " + notas10);
            if (notas5 > 0) Console.WriteLine("Notas de 5 " + notas5);
            if (notas1 > 0) Console.WriteLine("Notas de 1 " + notas1);
        }
    }

}
