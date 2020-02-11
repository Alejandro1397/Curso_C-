using System;

namespace Serie_8{
    class Program{
        static void Main(string[] args){
            //Instanciamos 3 objetos
            Auto a1 = new Auto();
            Auto a2 = new Auto("Mercedes", 654218893, 462586.65);
            Auto a3 = new Auto("Lincoln", 254687985, 1780589.38);
            //Mandamos a llamar a los metodos creados asi como el get y el set
            Console.WriteLine(a1.Marca);
            a1.Encender();
            a1.Acelerar();
            a1.Apagar();
            Console.WriteLine(a2.Marca);
            a2.Encender();
            a2.Apagar();
            Console.WriteLine(a3.Marca);
            a3.Encender();

            a1.Marca = "Rolls Royce";
            a1.Precio = 10000000.00;
            

            Console.WriteLine(a1.Marca);
            Console.WriteLine(a1.Precio);
            

            Console.ReadKey();


        }
    }
}
