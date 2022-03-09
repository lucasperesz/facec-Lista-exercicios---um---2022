using System;

namespace exercicio___quatro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe sua data de aniversario!");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int idade = DateTime.Today.Year - data.Year;

                if (data.DayOfYear > DateTime.Today.DayOfYear)
                    idade = idade - 1;
                Console.WriteLine($"Sua idade é de:  {idade}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}