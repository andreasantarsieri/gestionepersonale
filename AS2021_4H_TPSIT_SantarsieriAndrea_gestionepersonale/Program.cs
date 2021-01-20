using System;

namespace AS2021_4H_TPSIT_SantarsieriAndrea_gestionepersonale
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            GestioneAzienda utente = new GestioneAzienda("Gino", "Rossi", 24, "Magazzino1");

            utente.Nome = "Gino";
            utente.Cognome = "Rossi";
            utente.Eta = 24;
            utente.Reparto = "Magazzino1";

            Console.WriteLine(utente.VisualizzaDati());

            i++;
            if(i == 1)
            {
                utente.Nome = "Mario";
                utente.Cognome = "Verde";
                utente.Eta = 44;
                utente.Reparto = "Ufficio1";
            }
    
            Console.WriteLine(utente.VisualizzaDati());
            Console.WriteLine(utente.CancellaDati());
            
            


        }
    }
}
