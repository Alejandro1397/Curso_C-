using System;
using System.Collections.Generic;

namespace Compras{
    class Program{
        static void Main(string[] args){
            //Listas que indica el programa - Nombres de los productos y precios
            List<string> producto = new List<string>();
            List<double> precio = new List<double>();
            int opcion;

            Console.WriteLine("#########################");
            do{
                //Menú para ingresar los productos o comprar
                Console.WriteLine("Menú");
                Console.WriteLine("1) Añadir al carrito");
                Console.WriteLine("2) Carrito");
                Console.WriteLine("3) Salir");
                Console.WriteLine("#########################");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException FE)
                {
                    Console.WriteLine("Ingrese una número");
                    opcion = -1;
                    continue;
                }
                //Llama a los procedimientos de comprar o ver el carrito
                switch (opcion){
                    case 1:
                        Agregar(producto, precio);
                        break;
                    case 2:
                        Carrito(producto, precio);
                        break;
                    case 3:
                        Console.WriteLine("Vuelva pronto");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion != 3);
        }

        //Procedimiento para agregar productos y precios
        public static void Agregar(List<string> producto, List<double> precio){
            //Variables para guardar en la lista de nombres y precios
            string nombre;
            double costo;
            Console.WriteLine("Nombre del producto");
            nombre = Console.ReadLine();
            producto.Add(nombre);

            Console.WriteLine("Precio");
            do{
                try
                {
                    costo = Convert.ToDouble(Console.ReadLine());
                    precio.Add(costo);
                    break;
                }
                catch (FormatException FE)
                {
                    Console.WriteLine("Ingrese un número");
                    Console.ReadKey();
                }
            } while (true);
        }

        //Procedimiento para comprar o devolver un producto
        public static void Carrito(List<string> producto, List<double> precio){
            //Variables para opción del menú, borrar un elemento y compra del carrito
            int opcion2;
            int indice;
            double total;

            //Obtiene el resultado de la compra
            compraTotal = MostrarInformacion(producto, precio);

            //Menú para comprar o retirar del carrito
            do{
                Console.WriteLine("1) Comprar");
                Console.WriteLine("2) Dejar producto");
                Console.WriteLine("3) Salir");
                try
                {
                    opcion2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException FE)
                {
                    Console.WriteLine("Ingrese una número");
                    break;
                }
                switch (opcion2){
                    case 1:
                        //Si es mayor termina se repite el menú
                        if (total > 500.00){
                            Console.WriteLine("Precio Excedido");
                            Console.ReadKey();
                        }else{
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Dejar producto");
                        //Muestra los productos
                        MostrarInformacion(producto, precio);
                        Console.WriteLine("Indique el número del producto que desea dejar");
                        indice =  Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            producto.RemoveAt(indice);
                            precio.RemoveAt(indice);
                            total = MostrarInformacion(producto, precio);
                            break;
                        }
                        catch (IndexOutOfRangeException ioe)
                        {
                            Console.WriteLine("Ingrese un indice correcto");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        Console.WriteLine("Vuelva pronto");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion2 != 3);
        }

        //Función que regresa el total de la compra
        public static double MostrarInformacion(List<string> producto, List<double> precio){
            //Variable para obtener la compra
            double compra = 0;

            //Recorre las dos listas y muestra el producto, precio e indice
            for (int i = 0; i < producto.Count; i++){
                Console.WriteLine("{0} Producto: {1}  - Precio: {2}", i, producto[i], precio[i]);
                compra += precio[i];
            }

            return compra;
        }
    }
}
