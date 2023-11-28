using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    public class ArticoloAlimentare : Articolo
    {
        private int _anno;

        public int Anno
        {
            get { return _anno; }
            set
            {
                if (this is ArticoloAlimentare)
                    _anno = value;
                else
                    _anno = DateTime.Now.Year;
            }
        }

        public ArticoloAlimentare() : base()
        {
            Anno = DateTime.Now.Year + 1;
        }

        public ArticoloAlimentare(int anno, string descrizione, double prezzoUnitario, bool cartaFedelta) : base(descrizione, prezzoUnitario, cartaFedelta)
        {
            Anno = anno;
        }

        public ArticoloAlimentare(ArticoloAlimentare vecchioArtAlimentare, Articolo vecchioArticolo) : base(vecchioArticolo)
        {
            Anno = vecchioArtAlimentare.Anno;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentare other = (ArticoloAlimentare)obj;

            if (base.Equals(other) && Anno == other.Anno)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Anno: {Anno}";
        }
        public override double Sconta()
        {
            double sconto = base.Sconta();

            if (Anno == DateTime.Now.Year)
            {
                return PrezzoUnitario - sconto * 20F / 100F;
            }

            // Se non ho nessuna delle due
            return sconto;
        }
    }
}
