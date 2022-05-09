using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World" tagurpidi
            Console.WriteLine("Sisesta lause, Hello World, ja konsool kuvab selle tagurpidi:");
            string sentence = Console.ReadLine();

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }
        }
    }
}
