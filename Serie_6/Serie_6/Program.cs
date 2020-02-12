using System;

namespace Serie_6{
    class Program{
        static void Main(string[] args){
            //Declaramos dos nuevos objetos
            CuentaBancaria c1 = new CuentaBancaria("Daniel", 1532.0);
            CuentaBancaria c2 = new CuentaBancaria("Juan", 783.25);
            //Utilizamos los metodos de la clase CuentaBancaria
            c1.mostarInformacion();
            c1.retirar(500.30);
            c2.mostarInformacion();
            c2.depositar(250.50);
            c2.retirar(2000);

            Console.ReadKey();
        }
    }
}
