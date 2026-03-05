using System;
using System.Reflection.PortableExecutable;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string text = Console.ReadLine();

            Console.Write("Character: ");
            char c = Convert.ToChar(Console.ReadLine());

            foreach (char letter in text)
            {
                if (letter == c)
                Console.Write('x');
                else
                Console.Write(letter);
            }
        }
    }
}
