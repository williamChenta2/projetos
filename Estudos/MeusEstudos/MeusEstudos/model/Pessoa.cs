using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.model
{
    class Pessoa
    {
        private int id;

        public int ID { get{return id; }
            set {
                if(value > 0)
                {
                    id = value;
                }
            }
        }

        virtual
        public void printId()
        {
            Console.WriteLine(id);
        }
    }
}
