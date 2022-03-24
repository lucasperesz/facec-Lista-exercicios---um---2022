using System;
using System.Linq;

namespace exercicio.oito
{
    class Program
    {
        private static readonly char[] _vogais = new char[]
        {
            'a','e','i','o','u',' ',
        };


        //private const char _a = 'a';
        //private const char _e = 'e';
        //private const char _i = 'i';
        //private const char _o = 'o';
        //private const char _u = 'u';
        //private const char _esp = ' ';
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o nome:");
                string nome = Console.ReadLine().ToLower();
                //Console.WriteLine(ContarConsoantesString(nome));
                Console.WriteLine(ContarConsoantesChar(nome));
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }


        }
        private static string ContarConsoantesChar(string nome)
        {
            int count = 0;
            for (int i = 0; i < nome.Length; i++)
            {
                var letra = nome[i];
                if (!_vogais.Contains(letra))
                {
                    count++;
                }

            }

            return $"Seu nome possui {count} consoante(s)!";
        }
        //private static string ContarConsoantesString(string nome)
        //{
        //    int count = 0;
        //    for (int i = 0; i < nome.Length; i++)
        //    {
        //        if (!_a.Equals(nome[i])

        //            && !_e.Equals(nome[i])
        //            && !_i.Equals(nome[i])
        //            && !_o.Equals(nome[i])
        //            && !_u.Equals(nome[i])
        //            && !_esp.Equals(nome[i]))
        //            count++;
        //    }
        //    return $"Seu nome possui {count} consoante(s)!";
        //}
    }
}

