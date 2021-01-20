using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_4H_TPSIT_SantarsieriAndrea_gestionepersonale
{
    class GestioneAzienda
    {
        string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        string _cognome;
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }
        int _eta;
        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }
        string _reparto;
        public string Reparto
        {
            get
            {
                return _reparto;
            }
            set
            {
                _reparto = value;
            }
        }

        public GestioneAzienda(string _nome, string _cognome , int _eta, string _reparto)
        {
            _nome = Nome;
            _cognome = Cognome;
            _eta = Eta;
            _reparto = Reparto;
        }
        public string VisualizzaDati()
        {
            return $"Il dipendente di nome {Nome} e di cognome {Cognome} ha {Eta} anni e lavora nel reparto {Reparto}.";
        }
        public string CancellaDati()
        {
            _nome = ".";
            _cognome = ".";
            _eta = 0;
            _reparto = ".";
            return $"Il dipendente di nome {Nome} e di cognome {Cognome} ha {Eta} anni e lavora nel reparto {Reparto}.";
        }
        public string ModificaDati()
        {
            return $"Il dipendente di nome {Nome} e di cognome {Cognome} ha {Eta} anni e lavora nel reparto {Reparto}.";
        }


    }
}
