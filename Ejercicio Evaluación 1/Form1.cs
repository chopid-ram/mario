using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Evaluación_1
{
    public partial class Form1 : Form
    {

        //Aqui van las variables generales
        //Estas variables pueden ser llamadas desde cualquier
        //Función dentro de public partial class.

        //Las variables numero1 y numero2 son las variables que uso
        //para guardar los numeros con los que voy a operar

        //La variable contador la utilizo para decirle al programa cuando
        //Concatenar los numeros. Si en una o en otra. Para diferenciar el
        //antes y despues del operando.

        //La variable resultado es una pequeña varibale para guardar el
        //resultado de las operaciones.

        //La variable Store es la que uso para guardar los numeros
        //en forma string para concatenarlos y hacer las cifras enteras
        //con los botones de los numeros.

        //las variables que hay en INT son un contador para saber
        //que operación hay que usar al darle al boton resultado

        float numero1, numero2, contador=0, resultado;
        string store="";
        int suma=0, dividir=0, multi=0, resta=0;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //esto limpia la pantalla y las variables numericas guardadas. 
            //"reinicia la calculadora" limpiando el cuadro de texto y
            //la variable store, como también reseteando el contador a 0.
            txtScreen.Text = "";
            store = "";
            contador = 0;
        }

        //Estos son los botones numericos
        //Al darle a uno, comprueba si hay un 0 en
        //Store. Si hay un 0 lo elimina e introduce la primera cifra.
        //Esto es para evitar ver que sale en pantalla "05" por ejemplo.
        //Tiene mas sentido que solo salga el 5.
        //Lo segundo que hace es coger la variable store y le concatena el
        //numero correspondiente y lo muestra en pantalla.
        //Todo esto en String, ya que si no sumaria los numeros como operación.

        private void btn1_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 1;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 1;
                txtScreen.Text = store;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 2;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 2;
                txtScreen.Text = store;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 3;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 3;
                txtScreen.Text = store;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 4;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 4;
                txtScreen.Text = store;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 5;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 5;
                txtScreen.Text = store;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 6;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 6;
                txtScreen.Text = store;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 7;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 7;
                txtScreen.Text = store;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 8;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 8;
                txtScreen.Text = store;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 9;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 9;
                txtScreen.Text = store;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (store == "0")
            {
                store = "";
                store = store + 0;
                txtScreen.Text = store;
            }
            else
            {
                store = store + 0;
                txtScreen.Text = store;
            }
        }

        //Fin de los botones numericos.


        //Este es el boton que cambia el signo de los numeros.
        //Comprueba el contador para saber a que variable cambiarle
        //el signo. Si el contador es 0 y hay algo en store
        //, multiplicara por -1 a la varibale numero1. 
        //Si no, se la cambiara a la variable numero2.
        //Luego lo mete en store y lo muestra por pantalla.

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                numero1 = (-1) * numero1;
                store = "" + numero1;
                txtScreen.Text = store;

            }
            else
            {
                if (store != "")
                {
                    numero2 = float.Parse(store);
                    numero2 = (-1) * numero2;
                    store = "" + numero2;
                    txtScreen.Text = store;
                }
            }
        }




        //El boton de resultado


        //Funciona mirando un contador especifico para cada boton operador

        //Por ejemplo, si le das al boton de sumar hara que el contador sea 1 y al darle
        //al boton de resultado te hara la suma de las variables.
        //Convierte lo que hay en la variable store en float y lo mete en la variable
        //numero2, ya que al darle al boton operador lo guarda en la variable numero1.

        //Hace la operación y lo muestra por pantalla. Luego, lo mete en store
        //para volverse a usar en la siguiente operación.
        //Por eso el boton operador guarda directamente la variable numero1.

        //Al final resetea los contadores de los operadores.

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (suma == 1 && store != "") //Procedimiento de suma
            {
                numero2 = float.Parse(store);
                resultado = numero1 + numero2;
                txtScreen.Text = "" + resultado;
                store = "" + resultado;
                contador = 0;
                suma = 0;
                resta = 0;
                dividir = 0;
                multi = 0;
            }
            else
            {

                if (resta == 1) //Procedimiento de resta
                {
                    numero2 = float.Parse(store);
                    resultado = numero1 - numero2;
                    txtScreen.Text = "" + resultado;
                    store = "" + resultado;
                    contador = 0;
                    suma = 0;
                    resta = 0;
                    dividir = 0;
                    multi = 0;
                }
                else
                {

                    if (dividir == 1) //Procedimiento de Dividir
                    {
                        numero2 = float.Parse(store);
                        resultado = numero1 / numero2;
                        txtScreen.Text = "" + resultado;
                        store = ""+resultado;
                        contador = 0;
                        suma = 0;
                        resta = 0;
                        dividir = 0;
                        multi = 0;
                    }
                    else
                    {

                        if (multi == 1) //Procedimiento de Multiplicar
                        {
                            numero2 = float.Parse(store);
                            resultado = numero1 * numero2;
                            txtScreen.Text = "" + resultado;
                            store = "" + resultado;
                            contador = 0;
                            suma = 0;
                            resta = 0;
                            dividir = 0;
                            multi = 0;
                        }
                        else //Procedimiento de Error
                        {

                            MessageBox.Show("Error");

                        }

                    }

                }

            }
        }



        //Los botones de operación

        //Los botones de operación funcionan de la siguiente manera:
        //el boton comprueba la variable contador para saber con que variable
        //tiene que trabajar, si con numero1 o con numero2.
        //También comprueba que haya algo en la variable store
        //para no dar problemas al convertir lo que haya en float.
        //Si por algún motivo no hubiera algo simplemente no lo ejecutaria.

        //Después pone la variable contador a 1 para señalar que lo siguiente 
        //se tiene que meter en la variable numero2.
        //Muestra por pantalla el caracter +, resetea store y pone el contador
        //de suma a 1 para indicarle al boton "=" que operar.

            //Aqui el boton de sumar


        private void btnSumar_Click(object sender, EventArgs e)
        {

            if (contador== 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "+";
                store = "0";
                suma = 1;

            }

        }

            //Aqui el boton de restar

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "-";
                store = "0";
                resta = 1;

            }
        }

            //Aqui el boton de multiplicar

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "X";
                store = "0";
                multi = 1;

            }
        }

            //Aqui el boton de dividir

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (contador == 0 && store != "")
            {

                numero1 = float.Parse(store);
                contador = 1;
                txtScreen.Text = "/";
                store = "0";
                dividir = 1;

            }
        }



    }
}

//Autor: Noruka
