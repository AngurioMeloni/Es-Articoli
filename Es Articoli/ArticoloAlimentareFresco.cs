using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _consumabile;

        public int Consumabile
        {
            get { return _consumabile; }
            set
            {
                if (value > 0)
                    _consumabile = value;
                else
                    _consumabile = 0;
            }
        }

        public ArticoloAlimentareFresco() : base()
        {
            Consumabile = 3;
        }

        public ArticoloAlimentareFresco(int codice, int consumabile, int anno, string descrizione, double prezzoUnit, bool cartaFedelta) : base(codice, descrizione, prezzoUnit, cartaFedelta)                                                                                           
        {
            Consumabile = _consumabile;
        }

        public ArticoloAlimentareFresco(ArticoloAlimentareFresco vecchioArticoloAlimentareFresco, ArticoloAlimentare vecchioArticoloAlimentare, Articolo vecchioArticolo) : base(vecchioArticoloAlimentare, vecchioArticolo)
        {
            Consumabile = vecchioArticoloAlimentareFresco.Consumabile;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentareFresco other = (ArticoloAlimentareFresco)obj;

            if (base.Equals(other) && Consumabile == other.Consumabile)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return $"{base.ToString()}; Consumarsi entro: {Consumabile}";
        }
        public override double Sconta()
        {
            double percentuale = 10F;
            double sconto = base.Sconta();

            for (int i = 1; i < 6 && i < Consumabile; i++)
            {
                percentuale -= 2F;
            }

            return sconto - sconto * percentuale / 100;
        }
    }
}
