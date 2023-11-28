using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    public class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public bool Riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value; }
        }
        public ArticoloNonAlimentare() : base()
        {
            Materiale = "";
            Riciclabile = false;
        }

        public ArticoloNonAlimentare(int codice, string materiale, bool riciclabile, string descrizione, double prezzoUnitario, bool cartaFedelta) : base(codice, descrizione, prezzoUnitario, cartaFedelta)
        {
            Materiale = materiale;
            Riciclabile = riciclabile;
        }

        public ArticoloNonAlimentare(ArticoloNonAlimentare vecchioArtNonAlim, Articolo vecchioArt) : base(vecchioArt)
        {
            Materiale = vecchioArtNonAlim.Materiale;
            Riciclabile = vecchioArtNonAlim.Riciclabile;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloNonAlimentare other = (ArticoloNonAlimentare)obj;

            if (base.Equals(other) && Materiale == other.Materiale && Riciclabile == other.Riciclabile)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            string s = Riciclabile ? "Materiale Riciclabile" : "Materiale Non riciclabile";
            return $"{base.ToString()}; Materiale: {Materiale}; Riciclabilità: {s}";
        }
        public override double Sconta()
        {
            double sconto = base.Sconta(); // sconto base della carta fedeltà

            if(Riciclabile) //sconto aggiuntivo nel caso il materiale sia riciclabile
            {
                return PrezzoUnitario - sconto * 10F / 100F; // sconto del 10% 
            }
            return sconto;
        }

    }
}
