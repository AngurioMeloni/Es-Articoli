using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        public int GiorniConsumoDopoAp { get; set; }
        public ArticoloAlimentareFresco(string codice,string descrizione,double prezzoUnitario, int annoScadenza,int giorniConsumoDopoAp) : base(codice,descrizione, prezzoUnitario,annoScadenza) 
        {
            GiorniConsumoDopoAp = giorniConsumoDopoAp;
        }
        public override void Sconta()
        {
            base.Sconta();//sconti in base alla carta fedeltà e all'anno di scadenza
            double scontoGiorni = GiorniConsumoDopoAp * 0.02; // 2% per ogni giorno
            double scontoTotale = 1 - scontoGiorni; //calcolo dellosconto totale
            PrezzoUnitario *= scontoTotale; 
        }
    }
}
