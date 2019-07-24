using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.builderPattern
{
    public enum tipo { PARAGRAPH, LINE, TABLE, DOCUMENT }

    class Reader
    {
        private tipo tipo;    
        private Converter conv;

        public Reader(Converter conv, tipo tipo)
        {
            this.conv = conv;
            this.tipo = tipo;
        }

        public void parseInput()
        {
            switch(this.tipo)
            {
                case tipo.DOCUMENT:
                    conv.getDocument();
                    break;
            }
        }
    }
}
