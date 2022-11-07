/*1. Fazer classe Funcionario contedo os atributos nome (string), matricula (int) e cpf (string). Faça encapsulamento usando métodos get/set.
Crie construtor com todos atributos. Crie o método imprimeFuncionario() que lista na console os valores de todos atributos.

2. Fazer classe Departamento contendo os atributos nome (string) e lista de funcionarios(arraylist). Crie um construtor com atributo nome. 
Crie o método adicionaFuncionario que recebe um funcionário f e o adiciona na lista de funcionarios. Crie método imprimeDepartamento que lista na console os dados
de todos funcionários que estão dentro do departamento.

3. Fazer classe Programa contendo o método Main. Crie um departamento: ("vendas"). Crie 2 empregados: ("maria", 123, "6765657") e ("pedro", 789, "2213438") e
adicione-os no departamento de vendas. Liste os dados da maria e pedro usando o método imprimeDepartamento.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecoes_071022
{
    class Departamento
    {
        public string nome;
        ArrayList lista = new ArrayList();

        public Departamento(string nome)
        {
            this.nome = nome;
        }

        public void adicionaFuncionario(Funcionario f)
        {
            lista.Add(f);
        }

        public void imprimeDepartamento()
        {
            foreach (Funcionario funcionario in lista)
            {
                Console.WriteLine(funcionario.getNome()+" "+funcionario.getMatricula()+" "+funcionario.getCpf());
            }
        }
    }
}

namespace colecoes_071022
{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private string cpf;

        public Funcionario (string nome,int matricula,string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void imprimeFuncionario()
        {
            Console.WriteLine("Nome: " + this.nome + " Matricula: " + this.matricula + " CPF: " + this.cpf);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Departamento d1 = new Departamento("vendas");
        Funcionario f1 = new Funcionario("maria", 123, "6765657");
        Funcionario f2 = new Funcionario("pedro", 789, "2213438");
        d1.adicionaFuncionario(f1);
        d1.adicionaFuncionario(f2);
        d1.imprimeDepartamento();
    }
}
