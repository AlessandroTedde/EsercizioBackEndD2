using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBackEndD2
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }

        public string GetNome() 
        { 
            return Nome; 
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEtà()
        {
            return Età;
        }
        public void GetDettagli()
        {
            Console.WriteLine("Dettagli persona:" + "\n" + "Nome: " + GetNome() + "\n" + "Cognome: " + GetCognome() + "\n" + "Età: " + Convert.ToString(GetEtà()));
        }
        public Persona(string nome, string cognome, int età)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Età = età;
        }
    }
}
