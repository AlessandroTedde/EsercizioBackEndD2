using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackEndD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci Nome:");
            string Nome = Console.ReadLine(); 
            Console.WriteLine("Inserisci Cognome:");
            string Cognome = Console.ReadLine();            
            Console.WriteLine("Inserisci Età:");
            int Età = Convert.ToInt16(Console.ReadLine());

            Persona persona = new Persona(Nome, Cognome, Età);
            Console.WriteLine("\n");
            persona.GetDettagli();
            Console.ReadKey();
        }
    }
}
