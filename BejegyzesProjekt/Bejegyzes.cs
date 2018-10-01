using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.letrejott = DateTime.Now;
        }

        public string getSzerzo() { return this.szerzo; }
        public string getTartalom() { return this.tartalom; }
        public void setTartalom(string tartalom)
        {
            this.tartalom = tartalom;
        }
        public int getLikok() { return this.likok; }
        public void setLikekok(int value)
        {
            this.likok = value;
        }
        public DateTime getLetrejott() { return this.letrejott; }
        public DateTime getSzerkesztve() {
            if (this.tartalom != "")
            {
                return DateTime.Now;
            }
            else
            {
                return getLetrejott();
            }
        }       

        public void Like()
        {
            this.likok++;
        }

        public string Kiir()
        {
            string valasz = this.szerzo + "-" + this.likok + "-" + this.letrejott + "\nSzerkesztve: " + getSzerkesztve() + "\n" + this.tartalom;
            return valasz;
        }
    }
}
