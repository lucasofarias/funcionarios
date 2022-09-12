using System;

namespace exercício;

class Program {
    static void Main(string[] args) {

        List<Funcionario> listaFuncionario = new List<Funcionario>();

        int opcaoMenu;

        do {
            Console.WriteLine("                Menu");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1) Adicionar funcionário");
            Console.WriteLine("2) Aumentar salário de um funcionário");
            Console.WriteLine("3) Listar funcionários");
            Console.WriteLine("4) Procurar por funcionário");
            Console.WriteLine("5) Editar funcionário");
            Console.WriteLine("6) Remover funcionário");
            Console.WriteLine("7) Fim");

            Console.Write("\n--> ");
            opcaoMenu = int.Parse(Console.ReadLine());

            switch(opcaoMenu) {
                
                case 1:
                    Console.WriteLine("Para adicionar um funcionário, entre com os dados abaixo:\n");
                    
                    Console.WriteLine("Funcionário Nº " + (listaFuncionario.Count + 1));
                    Console.Write("ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Salário: ");
                    double salario = double.Parse(Console.ReadLine());

                    listaFuncionario.Add(new Funcionario(id, nome, salario));
                    Console.WriteLine();
                break;
                
                case 2:
                    
                    if(listaFuncionario.Any()) {
                        Console.Write("Digite o ID de um funcionário para aumentar seu salário: ");
                        string procurarId = Console.ReadLine();

                        Console.Write("Digite a porcentagem do aumento: ");
                        double porcentagem = double.Parse(Console.ReadLine());

                        Funcionario procurarFuncionario = listaFuncionario.Find(x => x.Id == procurarId);

                        if(procurarFuncionario != null) {
                            procurarFuncionario.AumentarSalario(porcentagem);
                            Console.WriteLine("*** Aumento realizado com sucesso ***");
                        }

                        else {
                            Console.WriteLine("*** O ID informado não existe ***");
                        }
                    }

                    else {
                        Console.WriteLine("*** A lista de funcionários está vazia ***");
                    }
                break;

                case 3:

                    if(listaFuncionario.Any()) {
                        Console.WriteLine("Lista de funcionários:");
                        Console.WriteLine();

                        foreach(Funcionario funcionario in listaFuncionario) {
                            Console.WriteLine(funcionario);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Número total de funcionários: " + listaFuncionario.Count);
                    }

                    else {
                        Console.WriteLine("*** A lista de funcionários está vazia ***");
                    }
                break;

                case 4:

                    if(listaFuncionario.Any()) {
                        Console.Write("Digite o ID do funcionário: ");
                        string procurarId = Console.ReadLine();

                        Funcionario procurarFuncionario = listaFuncionario.Find(x => x.Id == procurarId);

                        if(procurarFuncionario != null) {
                            Console.WriteLine("Funcionário encontrado:");
                            Console.WriteLine(procurarFuncionario);
                        }

                        else {
                            Console.WriteLine($"*** Funcionário com ID {procurarId} não foi encontrado ***");
                        }
                    }

                    else {
                        Console.WriteLine("*** A lista de funcionários está vazia ***");
                    }
                break;

                case 5:
                    
                    if(listaFuncionario.Any()) {
                        Console.Write("Digite o ID do funcionário: ");
                        string procurarId = Console.ReadLine();

                        Funcionario procurarFuncionario = listaFuncionario.Find(x => x.Id == procurarId);

                        if(procurarFuncionario != null) {
                            Console.WriteLine("Funcionário encontrado:");
                            Console.WriteLine(procurarFuncionario);

                            Console.WriteLine("Editar informações do funcionário");
                            Console.WriteLine("---------------------------------");
                            
                            Console.Write("ID: ");
                            id = Console.ReadLine();

                            Console.Write("Nome: ");
                            nome = Console.ReadLine();

                            foreach(Funcionario funcionario in listaFuncionario) {
                                
                                if(funcionario.Id == procurarId) {
                                    funcionario.Id = id;
                                    funcionario.Nome = nome;
                                }
                            }

                            procurarFuncionario = new Funcionario(id, nome);
                        }

                        else {
                            Console.WriteLine($"*** Funcionário com ID {procurarId} não foi encontrado ***");
                        }
                    }

                    else {
                        Console.WriteLine("*** A lista de funcionários está vazia ***");
                    }
                break;

                case 6:
                    
                    if(listaFuncionario.Any()) {
                        Console.Write("Digite o ID do funcionário: ");
                        string procurarId = Console.ReadLine();

                        Funcionario procurarFuncionario = listaFuncionario.Find(x => x.Id == procurarId);

                        if(procurarFuncionario != null) {
                            Console.WriteLine("Funcionário encontrado:");
                            Console.WriteLine(procurarFuncionario);

                            Console.Write("Tem certeza de que quer excluir o funcionário? (S/N): ");
                            char resposta = char.Parse(Console.ReadLine());

                            if(resposta == 'S' || resposta == 's') {
                                listaFuncionario.Remove(procurarFuncionario);
                                Console.WriteLine("*** Funcionário excluído com sucesso ***");
                            }
                        }

                        else {
                            Console.WriteLine($"*** Funcionário com ID {procurarId} não foi encontrado ***");
                        }
                    }
                    
                    else {
                        Console.WriteLine("*** A lista de funcionários está vazia ***");
                    }
                break;

                case 7:
                    Console.WriteLine("Saindo...");
                break;

                default:
                    Console.WriteLine("Por favor, digite uma opção válida.");
                break;
            }

            Console.ReadLine();
            Console.Clear();

        } while(opcaoMenu != 7);   
    }
}