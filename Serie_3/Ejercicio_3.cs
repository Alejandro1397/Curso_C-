using System;

namespace Serie_3{
    class Ejercicio_3{
        static void Main(string[] args){
            //Solicitamos al usuario que ingrese una cadena
            Console.WriteLine("Ingrese una cadena: ");
            //Leemos la cadena y la guardamos
            string cadena = Console.ReadLine();
            //Creamos un arreglo con las vocales minusculas y mayusculas
            char[] vocales = { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            //Creeamos una bandera que nos indica si hay cambios, es decir si se empiza cn una vocal se agrega una f al inicio
            bool intercambio = false;
            //Creamos una nueva cadena en donde se guardaran los cambios
            string cadenaF = "";
            //Creamos un ciclo con el que recorreremos toda la cadena proporcionada por el usuario
            for (int i = 0; i < cadena.Length; i++){
                //Creamos un ciclo que recorra el arreglo de vocales
                for (int j = 0; j < vocales.Length; j++){
                    //Verificamos si el caracter actual que se esta evaluando es igual a alguna de las vocales dentro del arreglo
                    if (cadena[i].Equals(vocales[j])){
                        //Si se cumple la condicion se levanta la bandera de cambio y se agrega una f a la nueva cadena
                        intercambio = true;
                        cadenaF += ("f" + cadena[i]);
                        //Salimos del ciclo que recorre las vocales
                        break;
                    }
                    else{
                        //Si no se cumple la condicion anterior se mantiene abajo la bandera de cambio
                        intercambio = false;
                    }
                }
                //Si no hubo cambios en el ciclo de las vocales se mantiene la cadena original
                if (!intercambio)
                    cadenaF += cadena[i];
            }
            //Se imprime la nueva cadena
            Console.WriteLine(cadenaF);
            Console.ReadKey();
        }
    }
}
