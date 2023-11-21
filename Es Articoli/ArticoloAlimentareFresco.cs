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
        public override double Sconta(bool CartaFedeltà)
        {
            double sconto = base.Sconta(CartaFedeltà);//sconti in base alla carta fedeltà e all'anno di scadenza
            if(GiorniConsumoDopoAp >= 1 && GiorniConsumoDopoAp <= 5)
            {
                sconto += PrezzoUnitario * (GiorniConsumoDopoAp * 0.02);
            }
            return sconto;
        }
    }
}
