using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRodriguezED_POO
{
    internal class Clientes
    {
        //===============================================

        //Declaracion de campos
        public Int32 Codigo;
        public string Nombre;
        public Decimal Deuda;

        //===============================================

        //Declaracion de procedimientos
        public void Comprar(Decimal Importe)
        {
            Deuda = Deuda + Importe;
        }

        public void Pagar (Decimal Importe)
        {
            Deuda = Deuda - Importe;
        }

        //===============================================
    }
}
