using System;
using System.Collections.Generic;
using System.Text;

namespace banco_console
{
    class contaBancaria
    {
        public int numero;
        public Cliente titular;
        public double saldo;
        public double valor;


        public double MostraSaldo()
        {
            return this.saldo;
        }

        public bool Transferir(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public int MostraNumero()
        {
            return this.numero;
        }

        public string MostraTitular()
        {
            return titular.nome + " " + titular.cpf;
        }

        public double MostraValor()
        {
            return this.valor;
        }
    }
}

namespace banco_console
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;

    }
}

namespace banco_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Joaquim Jose";
            cliente1.cpf = "123456";
            cliente1.rg = "16789";
            cliente1.endereco = "Rua xxxx, 30";

            contaBancaria c1 = new contaBancaria();
            c1.numero = 3;
            c1.titular = cliente1;
            c1.saldo = 1500;

            Console.WriteLine(c1.MostraNumero());
            Console.WriteLine(c1.MostraTitular());
            Console.WriteLine(c1.MostraSaldo());
            Console.WriteLine(c1.MostraValor());
            c1.Transferir(500);
            Console.WriteLine(c1.MostraSaldo());
           

            Console.ReadKey();
        }
    }
}
