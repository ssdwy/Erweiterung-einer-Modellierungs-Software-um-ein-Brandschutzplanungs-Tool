using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB1_UE1_Gruppe12_Klassen
{
    [Serializable]
    public class Gebaeude
    {
        private List<Stockwerk> stockwerkliste = new List<Stockwerk>();

        public List<Stockwerk> Stockwerkliste { get => stockwerkliste; set => stockwerkliste = value; }
        public string Gebaeude_bezeichnung { get; set; }


        public Gebaeude(string gebaeude_bezeichnung)
        {
            
            this.Gebaeude_bezeichnung = gebaeude_bezeichnung;
        }

        public Gebaeude (string gebaeude_bezeichnung, List<Stockwerk> stockwerklist)
        {
            this.Gebaeude_bezeichnung = gebaeude_bezeichnung;
            this.Stockwerkliste = stockwerklist;
        }

        public override string ToString()
        {
            return this.Gebaeude_bezeichnung;
        }
    }

}
