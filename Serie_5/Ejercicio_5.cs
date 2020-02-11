using System;
using System.Collections.Generic;

namespace Ejercicio_5{
    class Program{
        static void Main(string[] args){
            //Se crea el diccionario para guardar los datos
            Dictionary<string, int> agenda = new Dictionary<string, int>();
            //Se crea una variable para guardar la opcion seleccionada por el usuario y se inicializa en 0
            int opcion = 0;
            //Se crea un ciclo que se repetira mientras el usuario no seleccione salir que es la opcion 4
            while (opcion != 4){
                try
                {
                    //Se crea un ciclo que verifica que la entrada del usuario sea valida
                    while (opcion > 4 || opcion == 0 || opcion < 1){
                        //Se muestra el menu con las opciones
                        Console.WriteLine("###### Menu ######");
                        Console.WriteLine(" 1) Agregar Contacto");
                        Console.WriteLine(" 2) Eliminar Contacto");
                        Console.WriteLine(" 3) Mostrar Contacto");
                        Console.WriteLine(" 4) Salir");
                        //Se lee la opcion seleccionada por el usuario
                        opcion = Convert.ToInt32(Console.ReadLine());
                        //Se verifica que la opcion sea alguna de las 4 validas si no mostrara el siguiente mensaje
                        if (opcion > 4 || opcion < 1){
                            //Se muestra el mensaje de error si la opcion no es vaida
                            Console.WriteLine("Ingrese una opcion valida");
                        }
                    }
                }
                catch (FormatException)
                {
                    //En caso de que ocurra un error en la seleccion de la opcion se muestra este mensaje
                    Console.WriteLine("Ingrese solo numeros enteros");
                }
                finally
                {
                    //Se evalua la opcion que ingreso el usuario
                    switch (opcion){
                        //En caso de que no seleccione nada nos regresara el menu principal
                        case 0:
                            break;
                        //Si su opcion es 1 entra en esta seccion
                        case 1:
                            //Se solicita el nombre con el que desea guardar al contacto
                            Console.WriteLine("Nombre del contacto: ");
                            //Se lee el nombre y se guarda en una variable
                            string contacto = Console.ReadLine();
                            //Se solicita el número de telefono del contacto
                            Console.WriteLine("Ingrese el número de " + contacto);
                            //Se lee el número de telefono ingresado
                            string numero = "";
                            numero = Console.ReadLine();
                            //Se verifica que el numero ingresado tenga la longitud valida para un numero de telefono si no se solicita de nuevo
                            while (numero.Length != 10){
                                //Se muesta este mensaje si el numero no es valdio para que lo intente de nuevo
                                Console.WriteLine("Longitud demasiasda corta o demasiada larga, intente de nuevo");
                                //Se vuelve a leer el numero para su nueva evaluacion
                                numero = Console.ReadLine();
                            }
                            try
                            {
                                //Se verifica que el numero ingresado sean puros numeros y no contenga ningun caracter no valido
                                int num = Convert.ToInt32(numero);
                                //Si todo sale bien se agrega el numero con el nombre del contacto al diccionario
                                agenda.Add(contacto, num);
                                //Se muestra un menaje de que se logro la operacion con exito
                                Console.WriteLine("Se ha agregado a {0} con exito", contacto);
                            }
                            catch (FormatException)
                            {
                                //Si algo sale como que el numero no tenga numeros se muestra el siguiente mensjae
                                Console.WriteLine("Solo ingrese numeros para el número de telefono");
                            }
                            finally
                            {
                                //Se regresa la opciona 0 para volver a mostrar el menu principal
                                opcion = 0;
                            }
                            //Se sale de la evaluacion de las opciones para voler al menu principal
                            break;
                        //Si la opcion es 2 ingresa en este apartado
                        case 2:
                            //Se solicita el nombre del contacto a eliminar
                            Console.WriteLine("Nombre del contacto a eliminar: ");
                            //Se lee el nombre del contacto que se desea eliminar
                            contacto = Console.ReadLine();
                            //Se crea una bandera para verificar si el nombre ingresado existe en el diccionario
                            bool existe = agenda.ContainsKey(contacto);
                            //Se verifica el resultado de la bandera para poder continuar
                            if (existe){
                                //Si el nombre del contacto existe entonces se elimina del diccionario
                                agenda.Remove(contacto);
                                Console.WriteLine("Se elimino a {0} con exito", contacto);
                            }
                            else
                                //En caso de que no exista el contacto ingresado se regresa un mensaje de error y nos devuelve al menu principal
                                Console.WriteLine("{0} no existe en la agenda", contacto);
                            //Se regresa la opciona 0 para volver a mostrar el menu principal
                            opcion = 0;
                            //Se regresa al menu principal
                            break;
                        //Si la opcion es 3 ingresa en este apartado
                        case 3:
                            //Se solicita el nombre del contacto
                            Console.WriteLine("Nombre del contacto que desea ver: ");
                            //Se lee el nombre del contacto que se desea eliminar
                            contacto = Console.ReadLine();
                            //Se crea una bandera para verificar si el nombre ingresado existe
                            existe = agenda.ContainsKey(contacto);
                            //Se verifica el resultado de la bandera para poder continuar
                            if (existe)
                                //Si el usuario existe en el diccionario se muestra su nombre y número telefonico
                                Console.WriteLine("{0}: {1}", contacto, agenda[contacto]);
                            else
                                //En caso de que no exista el contacto ingresado se regresa un mensaje de error y nos regresa al menu principal
                                Console.WriteLine("{0} no existe en la agenda", contacto);
                            //Se regresa la opciona 0 para volver a mostrar el menu principal
                            opcion = 0;
                            //Se regresa al menu principal
                            break;
                    }

                }
            }
        }

    }
}
