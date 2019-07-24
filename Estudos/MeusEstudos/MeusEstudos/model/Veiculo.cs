using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEstudos.model
{
    abstract class Veiculo
    {
        private string modelo;

        public string Modelo { get {
                return modelo;
            } set {
                this.modelo = value;
            } }

        public abstract void printModelo();
    }
}
