using System;

namespace Serie_2{
    class Ejercico_2{
        static void Main(string[] args){
            try
            {
                //Se le indica al usuario que ingrese el primer número
                Console.WriteLine("Ingresa el primer numero: ");
                //Leemos el primer número
                int num1 = Convert.ToInt32(Console.ReadLine());
                //Se indica al usuario que ingrese el segundo número
                Console.WriteLine("Ingresa el segundo numero: ");
                //Leemos el segundo número
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                //Creamos un ciclo for que va del 1 al 100 para comparar cada valor con los dos numeros ingresados pr el usuario
              for (int i = 1; i <= 100; i++){
                //Comparamos si el número actual es multiplo de alguno de los numeros ingresdos por el usuario o verificamos si el número actualcontiene alguno de ellos
                if((i % num1 == 0) || (i % num2 == 0) || i.ToString().Contains(num1.ToString()) || i.ToString().Contains(num2.ToString())){
                    //en caso de cumplirse la condición se imprime "clap" en vez del número
                    Console.WriteLine("clap");
                }
                //En caso de que la condicón no se cumla, imprimimos el número actual
                else{
                    Console.WriteLine(i);
                }
              }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros enteros");
            }
            Console.ReadKey();

        }
    }
}
