using System;

namespace Serie_7{
    class Program{
        static void Main(string[] args){
            //Se declaran los objetos
            NumComplejos n1 = new NumComplejos(10, -1);
            NumComplejos n2 = new NumComplejos(13, 15);
            NumComplejos n3;
            //Se hace uso de los metodos declarados
            n1.mostrar();
            n3 = n2.sumar(n1);
            n3.mostrar();

            Console.ReadKey();
        }
    }
}
