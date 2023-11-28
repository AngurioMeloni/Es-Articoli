using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    public class Articolo
    {
        private static int _codice;
        private string _descrizione;
        private double _prezzoUnitario;
        private bool _cartaFedeltaeltà;

        public int Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public double PrezzoUnitario
        {
            get { return _prezzoUnitario; }
            set { _prezzoUnitario = value; }
        }

        public bool CartaFedelta
        {
            get { return _cartaFedelta; }
            set { _cartaFedeltaeltà = value; }
        }
  

        public Articolo()  
        {
            Codice += 1;
            Descrizione = "";
            PrezzoUnitario = 0;
            CartaFedelta = false;
        }
        public Articolo(string descrizione, double prezzoUnitario, bool cartaFedelta)
        {
            Codice += 1;
            Descrizione = descrizione;
            PrezzoUnitario = prezzoUnitario;
            CartaFedelta = cartaFedelta;
        }
        public Articolo(Articolo vecchioArticolo)
        {
            Codice = vecchioArticolo.Codice;
            Descrizione = vecchioArticolo.Descrizione;
            PrezzoUnitario = vecchioArticolo.PrezzoUnitario;
            CartaFedelta = vecchioArticolo.CartaFedelta;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Articolo other = (Articolo)obj;

            if (Codice == other.Codice && Descrizione == other.Descrizione && PrezzoUnitario == other.PrezzoUnitario && cartaFedelta == other.cartaFedelta)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            string s = cartaFedelta ? "Abbonato con carta fedeltà" : "Non abbonato";
            return $"Codice: {Codice}; Descrizione: {Descrizione}; Prezzo Unitario: {PrezzoUnitario}; Carta Fedeltà: {s}";
        }

        public virtual double Sconta()
        {
            if(cartaFedelta)
            {
                return PrezzoUnitario - PrezzoUnitario * 0.05; //riduzione del 5% con la carta fedeltà
            }
            return PrezzoUnitario;
        }
    }
}
