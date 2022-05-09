using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"
            Console.WriteLine("Sisesta lause, Hello World, ja arvuti loeb kokku, mitu 'h', 'o' ja 'l' selles lauses on:");
            string sentence = Console.ReadLine().ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'h')
                {
                    hCounter++;
                }

                if (sentence[i] == 'o')
                {
                    oCounter++;
                }

                if(sentence[i] == 'l')
                {
                    lCounter++;
                }

                
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'a', {oCounter} 'o' ja {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'a', {oCounter} 'o' ja {lCounter} 'l' täht.");
            }
        }
    }
}
