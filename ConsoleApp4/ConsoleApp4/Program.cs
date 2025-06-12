using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Expediente { get; set; }
        public float Salario { get; set; }
        public char Sexo { get; set; }
        public Funcionario(string nome, int idade, string expediente, float salario, char sexo)
        {
            Nome = nome;
            Idade = idade;
            Expediente = expediente;
            Salario = salario;
            Sexo = sexo;
        }
        public void CadastraFuncionario()
        {
            Console.WriteLine("Digite o nome do Funcionário:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do Funcionário:");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expediente do Funcionário:");
            Expediente = Console.ReadLine();
            Console.WriteLine("Digite o salário do Funcionário:");
            Salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo do Funcionário (M/F):");
            Sexo = char.Parse(Console.ReadLine().ToUpper());
        }

        public void ConsultaFuncionario()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Expediente: {Expediente}, Salário: {Salario}, Sexo: {Sexo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            while (true)
            {
                Console.WriteLine("Bem-vindo ao sistema de cadastro de funcionários! Digite 1 para cadastrar e 2 para consultar");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Funcionario funcionario = new Funcionario("", 0, "", 0.0f, ' ');
                    funcionario.CadastraFuncionario();
                    funcionarios.Add(funcionario);
                    Console.WriteLine("Funcionário cadastrado com sucesso!");
                }
                else if (opcao == "2")
                {
                    if (funcionarios.Count == 0)
                    {
                        Console.WriteLine("Nenhum funcionário cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Funcionários cadastrados:");
                        foreach (var funcionario in funcionarios)
                        {
                            funcionario.ConsultaFuncionario();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                string voltar = Console.ReadLine();
                if (!voltar.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}