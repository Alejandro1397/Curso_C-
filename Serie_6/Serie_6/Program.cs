using System;

namespace Serie_6{
    class Program{
        static void Main(string[] args){
            //Declaramos dos nuevos objetos
            CuentaBancaria c1 = new CuentaBancaria("Yamid", 1750.60);
            CuentaBancaria c2 = new CuentaBancaria("Rashid", 883.25);
            //Utilizamos los metodos de la clase CuentaBancaria
            c1.mostarInformacion();
            c1.retirar(250.50);
            c2.mostarInformacion();
            c2.depositar(150.50);
            c2.retirar(2000);

            Console.ReadKey();
        }
    }
}
