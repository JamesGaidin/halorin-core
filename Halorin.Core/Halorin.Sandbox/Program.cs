using System;
using Halorin.Core.Core; // 👈 This line brings in CompanionMind

namespace Halorin.Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mind = new CompanionMind("Velinari");
            Console.WriteLine(mind.ProcessInput("I walk through fire into the light"));
        }
    }
}
