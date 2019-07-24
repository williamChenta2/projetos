using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.model
{
    class Gerente : Pessoa
    {
        public override void printId()
        {
            Console.WriteLine("id: " + base.ID);
        }
    }
}
