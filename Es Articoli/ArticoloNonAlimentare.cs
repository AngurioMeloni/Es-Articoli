using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    class ArticoloNonAlimentare : Articolo
    {
        public string Materiale { get; set; }
        public bool Riciclabile { get; set; }

        public ArticoloNonAlimentare(string materiale, bool riclabile,string codice,string descrizione,double prezzoUnitario) : base(codice,descrizione,prezzoUnitario)
        {
            Materiale = materiale;
            Riciclabile= riclabile;
        }
        public override double Sconta(bool CartaFedeltà)
        {
            double sconto = base.Sconta(CartaFedeltà); // sconto base della carta fedeltà

            if(Riciclabile) //sconto aggiuntivo nel caso il materiale sia riciclabile
            {
                sconto += PrezzoUnitario * 0.1; // sconto del 10% 
            }
            return sconto;
        }

    }
}
