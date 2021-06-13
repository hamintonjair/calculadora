using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeraclase
{
    public partial class Calculador : Form
    {
        Calculadora suma, resta, division, multiplicacion, potencia, raiz;
        public Calculador()
        {
            InitializeComponent();
        }
        //Dividir
        private void btn_dividir_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            division = new Calculadora(numeroUno, numeroDos);

            int respuesta2 = division.dividirDosNumeros();
            txt_respuesta2.Text = respuesta2 + "";
            
        }
        //Multiplicar
        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            multiplicacion = new Calculadora(numeroUno, numeroDos);

            int respuesta3 = multiplicacion.multiplicarDosNumeros();
            txt_respuesta3.Text = respuesta3 + "";
            
        }
        //limpiar pantalla
        private void button1_Click(object sender, EventArgs e)
        {
            txt_respuesta.Text = "";
            txt_respuesta1.Text = "";
            txt_respuesta2.Text = "";
            txt_respuesta3.Text = "";
            txt_respuesta4.Text = "";
            txt_respuesta5.Text = "";
            txt_valorUno.Text = "";
            txt_valorDos.Text = "";
        }

        private void txt_respuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_respuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_respuesta2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            raiz = new Calculadora(numeroUno, numeroDos);

            double respuesta5 = raiz.raizCuadrada();
            txt_respuesta5.Text = respuesta5 + "";            
        }
        //cerrar el programa
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Raiz cuadrada
        private void btn_raiz_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            raiz = new Calculadora(numeroUno, numeroDos);

            double respuesta5 = raiz.raizCuadrada();
            txt_respuesta5.Text = respuesta5 + "";
        }

        //Potencia de un numero
        private void btn_potencia_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            potencia = new Calculadora(numeroUno, numeroDos);

            double respuesta4 = potencia.Potencia();
            txt_respuesta4.Text = respuesta4 + "";
        }

        private void txt_respuesta3_TextChanged(object sender, EventArgs e)
        {

        }
             

        private void label2_Click(object sender, EventArgs e)
        {

        }      
        //Sumar
        private void btn_sumar_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

            suma = new Calculadora(numeroUno, numeroDos);

            int respuesta = suma.sumarDosNumeros();
            txt_respuesta.Text = respuesta + "";
        }
        //Restar
        private void btn_restar_Click(object sender, EventArgs e)
        {           

            int numeroUno = Int32.Parse(txt_valorUno.Text);
            int numeroDos = Int32.Parse(txt_valorDos.Text);

             resta = new Calculadora(numeroUno, numeroDos);

            int respuesta1 = resta.restarDosNumeros();
            txt_respuesta1.Text = respuesta1 + "";
        }
    }
}
