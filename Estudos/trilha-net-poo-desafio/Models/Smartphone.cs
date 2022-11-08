using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            this.Memoria = memoria;
        }
        public void DadosCelular()
        {
            Console.WriteLine($"\nNúmero: {Numero} \nModelo: {Modelo} \nImei: {Imei} \nMemória: {Memoria} GB\n");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}