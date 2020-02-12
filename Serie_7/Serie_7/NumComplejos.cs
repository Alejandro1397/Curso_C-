using System;
using System.Collections.Generic;
using System.Text;

namespace Serie_7{
    class NumComplejos{
        //Declaramos los atributos necesarios para la clase
        public int Real;
        public int Imaginario;
        //Creamos el constructor que solicita la parte real e imaginaria para crear el número
        public NumComplejos(int real, int imaginario){
            Real = real;
            Imaginario = imaginario;
        }
        //Funcion que imprime el numero imaginario
        public void mostrar(){
            //Verifica si la parte imaginaria es postivica para imprimirlo con un signo de mas despues de la parte real
            if (Imaginario > 0){
                Console.WriteLine("{0}+{1}i", Real, Imaginario);
                //Si lo anterior no se cumple verifica si la parte imaginaria es 0 para solo imprimir la parte real
            }else if (Imaginario == 0){
                Console.WriteLine("{0}", Real);
                //Si la parte imaginaria es negativa solo imprime la real segida de la imaginaria ya que trae su signo
            }else{
                Console.WriteLine("{0}{1}i", Real, Imaginario);
            }
        }
        //Funcion que suma dos numeros complejos
        public NumComplejos sumar(NumComplejos n1){
            NumComplejos sum = new NumComplejos(Real + n1.Real, Imaginario + n1.Imaginario);
            return sum;
        }
    }
}
