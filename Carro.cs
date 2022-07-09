using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicosCPracticas
{
    public class Carro
    {
        public string Modelo = "Fox";
        public string Marca = "Volkswagen";
        public string Chassi = "HHHGGUU";
        public string Fabricante = "Alemania";

        public void Encender()
        {
            Console.WriteLine("Carro encendido!");
        }

        public void Apagar()
        {
            Console.WriteLine("Carro apagado!");
        }

        public void Acelerar()
        {
            Console.WriteLine("Carro acelerando...");
        }

        public void Frenar()
        {
            Console.WriteLine("Carro frenando...");
        }
    }


}


