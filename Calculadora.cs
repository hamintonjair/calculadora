using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraclase
{
    class Calculadora
    {
        int valorUno;
        int valorDos;        

        public Calculadora(int pvalorUno, int pvalorDos)
        {
            valorUno = pvalorUno;
            valorDos = pvalorDos;
        }
        public int sumarDosNumeros()
        {
            return valorUno + valorDos;
        }        
        public int restarDosNumeros()
        {
            return valorUno - valorDos;
        }
        public int dividirDosNumeros()
        {
            return valorUno / valorDos;
        }
        public int multiplicarDosNumeros()
        {
            return valorUno * valorDos;
        }

        public double Potencia()
        {
            return Math.Pow(valorUno, valorDos); 
        }
        public int raizCuadrada()
        {
            return (int)Math.Sqrt(valorUno);
        }


    }
}
