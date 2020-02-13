using System;

namespace Serie_10{
    class Program{
        static void Main(string[] args){
            // Variables para la ejecución del programa
            string nombre_ingresado;
            int altura_ingresada;
            int peso_ingresado;

            Console.Write("Conversion de peso y altura al sistema inglés.");
            Console.WriteLine("Ingrese el nombre : ");
            nombre_ingresado = Console.ReadLine();
           
            do{
                try
                {
                    Console.WriteLine("Ingrese la altura en cm : ");
                    altura_ingresada = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese el dato correspondiente");
                }
            } while (true);


            do{
                try
                {
                    Console.WriteLine("Peso (kg) : ");
                    peso_ingresado = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese el dato correspondiente");
                }
            } while (true);

            // Creamos el objeto
            Persona p1 = new Persona(nombre_ingresado, altura_ingresada, peso_ingresado);

            // Se mandan a llamar a los métodos
            p1.cmToft(altura_ingresada);
            p1.kgTolb(peso_ingresado);

            Console.ReadKey();
        }
    }
}
