using System;

namespace FOGO
{

    public class Program 
    {
        public static void Main( string [] args )
        {
        	Console.WriteLine("Pronto para disparar? Aperte Enter para continuar...");
        	Console.ReadKey();
        	Console.Clear();
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("Preparar...");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.ReadKey();
		Console.WriteLine("Apontar...");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.ReadKey();
		Console.WriteLine("FOGO!");
		Console.ResetColor();
        }
    }
}
