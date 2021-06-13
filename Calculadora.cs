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
        int valorRaiz;

        public Calculadora(int pvalorUno, int pvalorDos/*, int pvalorRaiz*/)
        {
            valorUno = pvalorUno;
            valorDos = pvalorDos;
            //valorRaiz = pvalorRaiz;
        }

        public Calculadora(int pvalorRaiz)
        {
            valorRaiz = pvalorRaiz;
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
            return (int)Math.Sqrt(valorRaiz);
        }


    }
}
