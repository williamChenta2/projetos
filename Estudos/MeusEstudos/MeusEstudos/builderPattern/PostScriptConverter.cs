using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.builderPattern
{
    class PostScriptConverter : Converter
    {
        public override void getDocument()
        {
            Console.WriteLine("gerando documento POST SCRIPT");
        }

        public override void makeLine()
        {
            Console.WriteLine("gerando linha POST SCRIPT");
        }

        public override void makeParagraph()
        {
            Console.WriteLine("gerando paragrafo POST SCRIPT");
        }

        public override void makeTable()
        {
            Console.WriteLine("gerando tabela POST SCRIPT");
        }
    }
}
