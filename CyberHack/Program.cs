using System;
using System.Security.Cryptography.X509Certificates;


namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which type of system do you want to attack? Write the number of which one to use: ");
            Console.WriteLine("CorporateServer, BankDatabase, SmartCityCore, MilitaryAI? ");
            string systemToAttack = Console.ReadLine();
            Console.WriteLine("Which tool would you like to use? ");
            Console.WriteLine("BruteForce, Phishing, Backdoor, ZeroDay, AIOverride, QuantumExploit?");
            string toolToHack = Console.ReadLine();
            SystemType attack = (SystemType)Enum.Parse(typeof(SystemType), systemToAttack);
            Console.WriteLine(attack);
            HackTool system = (HackTool)Enum.Parse(typeof(HackTool), toolToHack);
            Console.WriteLine(system);
        }
    }
}

