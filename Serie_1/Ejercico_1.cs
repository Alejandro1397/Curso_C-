using System;

namespace Serie_1{
    class Suma{
        static void Main(string[] args){
            //Se le indica a el usuario que indique el limite de numeros a sumae
            Console.WriteLine("Ingrese el limite de numeros a sumar");
            int n=0;
            try
            {
                //Leemos la entrada del usuario y luego la convertimos a entero
                n = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.WriteLine("Solo se aceptan numeros enteros");
            }
            //Creamos una variable donde almacenaremos el resultado de la suma
            int res = 0;
            //Creamos un ciclo for con el cual realizaremos la suma desde uno hasta
            //el limite que nos indico el usuario
            for (int i = 1; i <= n; i++){
                //se agrega el valor de cada repeticion a la variable suma
                res += i;
            }
            //Se imprime el resutado de la suma
            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
        }
    }
}
