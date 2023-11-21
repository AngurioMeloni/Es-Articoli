﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Articoli
{
    class Articolo
    {
        public string Codice { get;set; }
        public string Descrizione { get;set; }
        public double PrezzoUnitario { get;set; }
        public bool CartaFedeltà{ get;set; }

        public Articolo(string codice,string descrizione,double prezzoUnitario)  
        {
            Codice = codice;
            Descrizione = descrizione;
            PrezzoUnitario= prezzoUnitario;      
        }
        public virtual double Sconta(bool CartaFedeltà)
        {
            double sconto = 0;
            if(CartaFedeltà)
            {
                sconto = PrezzoUnitario * 0.05; //riduzione del 5% con la carta fedeltà
            }
            return sconto;
        }
        public virtual double prezzoScontato(bool CartaFedeltà)
        {
            double sconto = Sconta(CartaFedeltà);
            return PrezzoUnitario - sconto;
        }
    }
}
