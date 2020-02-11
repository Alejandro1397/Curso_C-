using System;
using System.Collections.Generic;
using System.Text;

namespace Serie_8{
    class Auto {
        //Declaramos los atributos
        string marca;
        public string Marca {
            get { return marca; }
            set { marca = value; }
        }
        double precio;
        public double Precio {
            get { return precio; }
            set { precio = value; } 
        }
        int serie;
        public int noSerie {
            get { return serie; }
            set { serie = value; } 
        }
        //creamos el constructor por defecto
        public Auto() {
            Console.WriteLine("BMW" + " " + "8795412578924" + " " +"$2000000");
        }
        //creamos la sobrecarga del constructor
        public Auto(string marc, int seri, double preci){
            marca = marc;
            precio = preci;
            serie = seri;
        }
        //creamos los metodos
        public void Encender(){
            Console.WriteLine("Saludos, soy Kit el auto increible");
        }

        public void Acelerar(){
            Console.WriteLine("A volar cual cohete a correr como volido");
        }

        public void Apagar(){
            Console.WriteLine("No me quiero ir señor stark");
        }


    }
}
