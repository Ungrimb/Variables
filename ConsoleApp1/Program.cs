using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Ismael", cognom1 = "Anaya", cognom2 = "Marquez", frase1= "El meu any de naixement és de traspàs", frase2= "El meu any de naixement no és de traspàs";
            int dia = 10, mes = 04, any = 1976, numberTraspas, anyInici = 1948;
            const int TRASPAS = 1948;
            bool bisiesto = false;

            Console.WriteLine("FASE 1");
            Console.WriteLine($"{cognom1} { cognom2}, {nom}");
            Console.WriteLine($"{dia}/{mes}/{any}");

            numberTraspas = (any - TRASPAS) / 4;

            Console.WriteLine("FASE 2");
            Console.WriteLine(numberTraspas);

            if (any % 4 == 0 && (any % 100 != 0 || any % 400 == 0)) bisiesto = true;
            numberTraspas = 0;
            for (int a=0; a < any;a++)
            {
                if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0)) numberTraspas++;
            }
            string nomComplet = $"El meu nom és {nom} {cognom1} {cognom2}";
            string dataComplet = $"Vaig néixer el {dia}/{mes}/{any}";

            Console.WriteLine("FASE 3");
            Console.WriteLine(nomComplet);
            Console.WriteLine(dataComplet);
            Console.WriteLine($"Hi ha agut {numberTraspas} anys de tràspas desde l'any 0 fins al teu naixement");
            if (bisiesto)
            {
                Console.WriteLine(frase1);
            }
            else Console.WriteLine(frase2);
        }
    }
}
