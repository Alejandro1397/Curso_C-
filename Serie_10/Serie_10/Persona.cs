using System;
using System.Collections.Generic;
using System.Text;

namespace Serie_10{
    class Persona{
         // Declaramos los atributos
        public string Nombre;
        public int Estatura; //En cm
        public int Peso; // En kg.

        //Declaramos el constructor
        public Persona(string nombre, int estatura, int peso){
            Nombre = nombre;
            Estatura = estatura;
            Peso = peso;
        }

        //Declaramos los métodos
        public void cmToft(int estatura){
            double pies = estatura * 0.032808; 
            Console.WriteLine("\n{0} mide {1} ft. ({2} cm)", Nombre, pies, estatura);
        }

        public void kgTolb(int peso){
            double libras = peso * 2.20462;
            Console.WriteLine("\n{0} pesa {1} libras. ({2} kg)", Nombre, libras, peso);
        } 
    }
}
