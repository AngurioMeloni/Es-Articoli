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

        }
    }
}
