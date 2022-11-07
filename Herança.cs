/*1. Construir uma classe para representar uma Pessoa com os seguintes dados: nome, endereço, CPF e RG. Considerando encapsulamento de dados, 
defina os construtores (padrão com passagem de parâmetros e sem passagem de parâmetros). Defina uma função chamada ImprimePessoa() que imprima os dados da pessoa.

2. Definir uma classe para representar um Aluno que obviamente é uma pessoa. 
Considere que o aluno tenha código de matrícula, nota P1, nota P2 e uma certa quantidade de faltas.
Considerando encapsulamento de dados, defina os construtores (padrão com passagem de parâmetros e sem passagem de parâmetros).
Considere também que o aluno com mais de 10 faltas está automaticamente reprovado (definir o limite de faltas = 10). 
A média de aprovação do aluno é a média aritmética das provas P1 e P2. Um aluno com média maior ou igual a 7.0 está aprovado 
(definir media_de_aprovacao = 7.0). Média abaixo de 3.0 está reprovado (definir media_de_reprovacao =3.0) e média entre 3.0 e 7.0 está de reavaliação (exame). 
Defina um método chamado ImprimeAluno() para imprimir todos os dados do aluno (inclusive os da classe Pessoa), 
um método ImprimeFaltas() para imprimir o total de faltas e outro método Resultado() para imprimir se aluno está aprovado, reprovado ou em reavaliação (exame).

3. Definir uma classe chamada TesteAluno() com o método main() e criar uma pessoa de nome “José”, endereço: “Rua Antonio Marques, 30”,  
CPF: “568.234.981-15” e RG: “3.698.222-8”. Imprimir os dados da pessoa. Criar um aluno de nome “Pedro”, endereço: “Rua Almeida, 20”, CPF: “456.876.123-12”, 
RG: “4.687.098-2”, código de matrícula: 59751, nota P1 = 4.5, nota P2 = 8.0, total de faltas = 10. Imprimir todos os dados do aluno. 
Imprimir o status do aluno (reprovado, aprovado ou em exame). Criar um outro aluno a partir do aluno anteriormente criado, 
ou seja exatamente com os mesmos atributos de dados.  Após a criação do novo aluno, 
alterar seu nome para “Francisco” e suas notas para: Nota P1 = 9.0, Nota P2 = 9.5. Imprimir todos os dados do novo aluno. 
Imprimir o status do novo aluno (reprovado, aprovado ou em exame). Alterar o número de faltas para 11 e imprimir o status do novo aluno (aprovado ou reprovado). 
Alterar as notas do novo aluno para 8.0 e 9.5. Imprimir o status do novo aluno (aprovado ou reprovado).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3009_heranca
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private string endereco;
        private string rg;

        public Pessoa(string nome, string cpf, string endereco, string rg)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.rg = rg;
        }

        public Pessoa()
        {
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public void ImprimePessoa()
        {
            Console.WriteLine(this.nome + " " + this.cpf + " " + this.endereco + " " + this.cpf);
        }

    }
}


namespace _3009_heranca
{
    class Aluno : Pessoa
    {
        private int matricula;
        private int falta;
        private float p1;
        private float p2;

        public Aluno(string nome, string cpf, string endereco, string rg, int matricula, int falta, float p1, float p2) : base(nome, cpf, endereco, rg)
        {
            this.matricula = matricula;
            this.falta = falta;
            this.p1 = p1;
            this.p2 = p2;
        }

        public Aluno()
        {
        }

        public int getMatricula()
        {
            return this.matricula;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public int getFalta()
        {
            return this.falta;
        }
        public void setFalta(int falta)
        {
            this.falta = falta;
        }

        public float getP1()
        {
            return this.p1;
        }
        public void setP1(float p1)
        {
            this.p1 = p1;
        }

        public float getP2()
        {
            return this.p2;
        }
        public void setP2(float p2)
        {
            this.p2 = p2;
        }

        public void imprimeAluno()
        {
            Console.WriteLine("Dados do aluno>>  Nome: " + getNome() + " CPF: " + getCpf() + " endereco: " + getEndereco() + " RG: " + getRg() + " Matricula: " + this.matricula);
        }

        public void imprimeFaltas()
        {
            Console.WriteLine("Total de faltas: " + this.falta);
        }

        public void imprimeResultado()
        {
            float media = (this.p1 + this.p2) / 2;

            if (this.falta > 10 || media < 3.0)
            {
                Console.WriteLine("Reprovado.");
            }
            if (media > 7.0)
            {
                Console.WriteLine("Aprovado.");
            }
            if (media > 3.0 && media < 7.0)
            {
                Console.WriteLine("Reavaliação.");
            }
            
        }
            

    }
}

namespace _3009_heranca
{
    class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.setNome("Pedro");
            a1.setEndereco("Rua Almeida, 20");
            a1.setCpf("456.876.123-12");
            a1.setRg("4.687.098-2");
            a1.setMatricula(59751);
            a1.setP1(4.5f);
            a1.setP2(8.0f);
            a1.setFalta(10);

            a1.imprimeAluno();
            a1.imprimeFaltas();
            a1.imprimeResultado();

        }
    }
}


