using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    class ArticoloAlimentare : Articolo
    {
        public int AnnoScadenza { get; set; }
        public ArticoloAlimentare(string codice,string descrizione,double prezzoUnitario,int annoScadenza) : base(codice,descrizione,prezzoUnitario)
        {
            AnnoScadenza= annoScadenza;
        }
        public override double Sconta(bool CartaFedeltà)
        {
            double sconto = base.Sconta(CartaFedeltà);  //sconto base della carta fedeltà
            if(AnnoScadenza == DateTime.Now.Year)   //sconto aggiuntivo per l'anno di scadenza
            {
                sconto += PrezzoUnitario * 0.2; // sconto del 20%
            }
            return sconto;
        }
    }
}
