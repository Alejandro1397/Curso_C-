using System;
using System.Collections.Generic;
using System.Text;

namespace Serie_6{
    class CuentaBancaria{
      //Se crea la variable donde se guardara el nombre de la cuenta
        private string cuenta;
        //Se crea la variable donde se guarda el saldo de la cuenta
        private double saldo;
        //Se crea el constructor de la clase el cual solicita un nombre y un saldo incial para poder ser creado y al crearse
        //regresa informacion del nombre de la cuenta y el saldo
        public CuentaBancaria(string Cuenta, double Saldo){
            //Se asignan los datos del constructor
            cuenta = Cuenta;
            saldo = Saldo;
            //Regresa la informacion de la cuenta creada
            Console.WriteLine("Cuenta {0} creada con exito, saldo de: {1}", cuenta, saldo);
        }
        //Se crea el metodo mostarInformacion el cual nos regresa los datos de una cuenta
        public string mostarInformacion(){
            return string.Format("Cuenta: {0}\n Saldo: {1}", cuenta, saldo);
        }
        //Se crea el metodo depositar para aumentar el saldo en una cuenta
        public void depositar(double deposito){
            //Se crea una variable que almacena el saldo anterior antes del deposito para poder mostrar el resmuen de la transaccion
            double anterior = saldo;
            //Sumamos la cantidad depositada al saldo previo
            saldo += deposito;
            //Se muestra el resumen del movimiento
            Console.WriteLine("Cuenta: {0} \n Saldo incial: ${1}\n Cantidad depositada: ${2} \n Saldo actual: ${3}", cuenta, anterior, deposito, saldo);
        }
        //Se crea el metodo retirar
        public void retirar(double retiro){
            //Se verifica que la cantidad a retirar no sea mayor al saldo en la cuenta
            if (retiro > saldo){
                //Si lo que se desea retirar es mayor al saldo disponible nos regresa un error
                Console.WriteLine("Cuenta: {0}", cuenta);
                Console.WriteLine("Saldo insuficiente");
            }
            else{
                //Si el saldo es suficiente entonces se creamos una variable donde guardamos el saldo antes del retiro para mostrarlo en el resumen
                double anterior = saldo;
                //Se resta la cantidad retirada al saldo previo
                saldo -= retiro;
                //Se muestra el resumen del movimiento
                Console.WriteLine("Cuenta: {0} \n Saldo incial: ${1}\n Retiro de: ${2} \n Saldo actual: ${3}", cuenta, anterior, retiro, saldo);
            }
        }
    }
}
