using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.builderPattern
{
    abstract class Converter
    {
        abstract public void makeLine();
        abstract public void makeParagraph();
        abstract public void makeTable();
        abstract public void getDocument();
    }
}
