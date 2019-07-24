using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.builderPattern
{
    class ASCIIConverter : Converter
    {
        public override void getDocument()
        {
            Console.WriteLine("gerando documento ASCII");
        }

        public override void makeLine()
        {
            Console.WriteLine("gerando linha ASCII");
        }

        public override void makeParagraph()
        {
            Console.WriteLine("gerando paragrafo ASCII");
        }

        public override void makeTable()
        {
            Console.WriteLine("gerando tabela ASCII");
        }
    }
}
