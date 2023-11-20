using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClassi2
{
    internal class Program
    {
        public class Persona
        {
            // attributi

            protected string _nome;
            protected string _cognome;
            protected string _altezza;
            protected string _peso;
            protected string _data_di_nascita;
            protected string _luogo_di_nascita;
            protected bool registrato = false;

            public Persona(string nome, string cognome, string altezza, string peso, string data, string luogo)
            {
                _nome = nome;
                _cognome = cognome;
                _altezza = altezza;
                _peso = peso;
                _data_di_nascita = data;
                _luogo_di_nascita = luogo;
            }

            public void Registrare()
            {
                Console.WriteLine($"Vuoi registrare {_cognome} {_nome}? (s,n)");
                string risposta = Console.ReadLine();

                if( risposta == "n") // non registrato
                {
                    
                }
                else // già registrato
                {
                    registrato = true;
                }
            }

            public void MostraOregistra()
            {
                if (registrato == false)
                {
                    Console.WriteLine($"Nome: {_nome}\nCognome: {_cognome}\nAltezza: {_altezza}\nPeso: {_peso}\nData di nascita: {_data_di_nascita}\nLuogo di nascita: {_luogo_di_nascita}");
                }
                else
                {
                    Console.WriteLine("Persona registrata");
                }
            }
        }
        static void Main(string[] args)
        {
            string nome = "carlo";
            string cognome = "rossi";
            string peso = "56";
            string altezza = "1.85";
            string data = "15/12/1968";
            string luogo = "verona";

            Persona p = new Persona(nome, cognome, altezza, peso, data, luogo);
            p.Registrare();
            p.MostraOregistra();
        }
    }
}
