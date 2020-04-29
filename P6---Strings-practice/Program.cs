using System;

namespace P6___Strings_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string motivacion = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            motivacion = motivacion.ToUpper();
            motivacion = motivacion.Replace(",", ";");
            motivacion = motivacion.Replace(" ", "");

            string[] motivacionArray = motivacion.Split(";");
           
            System.Console.WriteLine(String.Format("{5};{4};{3};{2};{1}", motivacionArray));
        }
    }
}
