using System;

namespace Serie_4{
    class Ejercico_4{
        static void Main(string[] args){
            //Creamos la variable que sera el primer elemento de la serie de Fibonacci
            int x = 0;
            //Creamos la variable a que es el segundo elemento de la serie de Fibonacci
            int y = 1;
            //Se crea una variable auxiliar que  nos ayudara a poder realizar las sumas
            int temp;
            //Creamos una variable donde guardaremos el limite dado por el usuario
            int limite = 0;
            //Se solicita al usuario ingrese el limite para la serie
            Console.WriteLine("Ingrese el limite de numeros a mostrar: ");
            try
            {
                //Se lee el limite ingresado por el usuario y se convierte a entero
                limite = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                //Si el usuario no ingresa un número mandara error
                Console.WriteLine("Ingrese solo numeros enteros");
            }
            finally
            {
                //Creamos un ciclo donde se repitira hasta llegar al limite indicado por el usuario
                for (int i = 0; i < limite; i++){
                    //Gardamos el valor de x en temp  para obtener el valor del número anterior en la serie
                    temp = x;
                    //Asignamos el valor del número actual que es y en la variable x que es el numero actual
                    x = y;
                    //Se suma el valor del número anterior con el actual y se guarda en la variable "y" la cual sera el nuevo valor actual
                    y = temp + x;
                    //Se imprime el valor de x
                    Console.WriteLine(x);
                }
                Console.ReadKey();
            }
        }
    }
}
