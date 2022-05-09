using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees- või perekonnanimi
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            if (lastName.Length < firstName.Length)
            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi!");
            }
            else if (lastName.Length > firstName.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem kui eesnimi!");
            }
            if(lastName.Length == firstName.Length)
            {
                Console.WriteLine("Ees- kui ka perekonnanimi on sama pikad");
            }
        }
    }
}
