using System;

namespace Exercicio_2_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int anoAtual;
           int mesAtual;
           int idadeDia;
           int idadePessoa;
           float idadeSemana;
           int anoNasceu;
           int mesNasceu;


           Console.WriteLine("Em qual ano você nasceu?");
           anoNasceu = int.Parse(Console.ReadLine());
           
           Console.WriteLine("Em qual mês você nasceu?");
           mesNasceu = int.Parse(Console.ReadLine());

           anoAtual = DateTime.Now.Year;
           mesAtual = DateTime.Now.Month;

           idadePessoa = anoAtual - anoNasceu;
           idadeDia = idadePessoa * 365;
           idadeSemana = idadeDia / 7;
           
          
               Console.WriteLine("A sua idade é de: " + idadePessoa);
               Console.WriteLine("A sua idade em semanas é de: " + idadeSemana);
           
        }
    }
}
