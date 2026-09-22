using System;
using System.Collections.Generic;


// ==========================================================
// EXERCÍCIO 01 - CADASTRO DE PRODUTOS
// ==========================================================

/*
class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        int opcao = 0;

        while (opcao != 3)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       CADASTRO DE PRODUTOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarProduto(produtos);
            }
            else if (opcao == 2)
            {
                ListarProdutos(produtos);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarProduto(List<Produto> produtos)
    {
        Console.Clear();

        Produto produto = new Produto();

        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Categoria: ");
        produto.Categoria = Console.ReadLine();

        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        produtos.Add(produto);

        Console.WriteLine();
        Console.WriteLine("Produto cadastrado com sucesso!");
        Console.ReadKey();
    }

    static void ListarProdutos(List<Produto> produtos)
    {
        Console.Clear();

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Produto " + (i + 1));
                Console.WriteLine("---------------------------------");

                produtos[i].MostrarProduto();
            }
        }

        Console.ReadKey();
    }
}
*/

// ==========================================================
// EXERCÍCIO 02 - CADASTRO DE LIVROS
// ==========================================================



class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>();
        int opcao = 0;

        while (opcao != 3)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("         CADASTRO DE LIVROS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarLivro(livros);
            }
            else if (opcao == 2)
            {
                ListarLivros(livros);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarLivro(List<Livro> livros)
    {
        Console.Clear();

        Livro livro = new Livro();

        Console.Write("Título: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Autor: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Ano: ");
        livro.Ano = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        livro.Categoria = Console.ReadLine();

        Console.Write("Está disponível? (true/false): ");
        livro.Disponivel = bool.Parse(Console.ReadLine());

        livros.Add(livro);

        Console.WriteLine();
        Console.WriteLine("Livro cadastrado com sucesso!");
        Console.ReadKey();
    }

    static void ListarLivros(List<Livro> livros)
    {
        Console.Clear();

        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
        }
        else
        {
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Livro " + (i + 1));
                Console.WriteLine("---------------------------------");

                livros[i].MostrarLivro();
            }
        }

        Console.ReadKey();
    }
}




// ==========================================================
// EXERCÍCIO 03 - CADASTRO DE FUNCIONÁRIOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        int opcao = 0;

        while (opcao != 3)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("      CADASTRO DE FUNCIONÁRIOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Listar funcionários");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarFuncionario(funcionarios);
            }
            else if (opcao == 2)
            {
                ListarFuncionarios(funcionarios);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarFuncionario(List<Funcionario> funcionarios)
    {
        Console.Clear();

        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        funcionario.Idade = int.Parse(Console.ReadLine());

        Console.Write("Cargo: ");
        funcionario.Cargo = Console.ReadLine();

        Console.Write("Salário: ");
        funcionario.Salario = double.Parse(Console.ReadLine());

        Console.Write("Setor: ");
        funcionario.Setor = Console.ReadLine();

        funcionarios.Add(funcionario);

        Console.WriteLine("Funcionário cadastrado!");
        Console.ReadKey();
    }

    static void ListarFuncionarios(List<Funcionario> funcionarios)
    {
        Console.Clear();

        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado.");
        }
        else
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Funcionário " + (i + 1));
                Console.WriteLine("---------------------------------");

                funcionarios[i].Apresentar();

                Console.WriteLine("Salário anual: R$ " +
                    funcionarios[i].CalcularSalarioAnual());
            }
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 04 - CADASTRO DE VEÍCULOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       CADASTRO DE VEÍCULOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - Pesquisar veículo");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarVeiculo(veiculos);
            }
            else if (opcao == 2)
            {
                ListarVeiculos(veiculos);
            }
            else if (opcao == 3)
            {
                PesquisarVeiculo(veiculos);
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarVeiculo(List<Veiculo> veiculos)
    {
        Console.Clear();

        Veiculo veiculo = new Veiculo();

        Console.Write("Marca: ");
        veiculo.Marca = Console.ReadLine();

        Console.Write("Modelo: ");
        veiculo.Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        veiculo.Ano = int.Parse(Console.ReadLine());

        Console.Write("Cor: ");
        veiculo.Cor = Console.ReadLine();

        Console.Write("Placa: ");
        veiculo.Placa = Console.ReadLine();

        veiculos.Add(veiculo);

        Console.WriteLine("Veículo cadastrado!");
        Console.ReadKey();
    }

    static void ListarVeiculos(List<Veiculo> veiculos)
    {
        Console.Clear();

        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo cadastrado.");
        }
        else
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Veículo " + (i + 1));
                Console.WriteLine("---------------------------------");

                veiculos[i].MostrarVeiculo();
            }
        }

        Console.ReadKey();
    }

    static void PesquisarVeiculo(List<Veiculo> veiculos)
    {
        Console.Clear();

        Console.Write("Digite a marca ou modelo: ");
        string pesquisa = Console.ReadLine().ToLower();

        bool encontrou = false;

        for (int i = 0; i < veiculos.Count; i++)
        {
            if (veiculos[i].Marca.ToLower() == pesquisa ||
                veiculos[i].Modelo.ToLower() == pesquisa)
            {
                veiculos[i].MostrarVeiculo();
                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Nenhum veículo encontrado.");
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 05 - CADASTRO DE FILMES
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>();
        int opcao = 0;

        while (opcao != 3)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("         CADASTRO DE FILMES");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar filme");
            Console.WriteLine("2 - Listar filmes");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarFilme(filmes);
            }
            else if (opcao == 2)
            {
                ListarFilmes(filmes);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarFilme(List<Filme> filmes)
    {
        Console.Clear();

        Filme filme = new Filme();

        Console.Write("Título: ");
        filme.Titulo = Console.ReadLine();

        Console.Write("Gênero: ");
        filme.Genero = Console.ReadLine();

        Console.Write("Ano: ");
        filme.Ano = int.Parse(Console.ReadLine());

        Console.Write("Duração em minutos: ");
        filme.Duracao = int.Parse(Console.ReadLine());

        Console.Write("Nota: ");
        filme.Nota = double.Parse(Console.ReadLine());

        filmes.Add(filme);

        Console.WriteLine("Filme cadastrado!");
        Console.ReadKey();
    }

    static void ListarFilmes(List<Filme> filmes)
    {
        Console.Clear();

        if (filmes.Count == 0)
        {
            Console.WriteLine("Nenhum filme cadastrado.");
        }
        else
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Filme " + (i + 1));
                Console.WriteLine("---------------------------------");

                filmes[i].ExibirInformacoes();
            }
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 06 - CADASTRO DE CLIENTES
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("        CADASTRO DE CLIENTES");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Pesquisar cliente");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarCliente(clientes);
            }
            else if (opcao == 2)
            {
                ListarClientes(clientes);
            }
            else if (opcao == 3)
            {
                PesquisarCliente(clientes);
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarCliente(List<Cliente> clientes)
    {
        Console.Clear();

        Cliente cliente = new Cliente();

        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        cliente.Idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cliente.Cidade = Console.ReadLine();

        Console.Write("Email: ");
        cliente.Email = Console.ReadLine();

        Console.Write("Telefone: ");
        cliente.Telefone = Console.ReadLine();

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado!");
        Console.ReadKey();
    }

    static void ListarClientes(List<Cliente> clientes)
    {
        Console.Clear();

        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cliente " + (i + 1));
                Console.WriteLine("---------------------------------");

                clientes[i].ApresentarCliente();
            }
        }

        Console.ReadKey();
    }

    static void PesquisarCliente(List<Cliente> clientes)
    {
        Console.Clear();

        Console.Write("Digite o nome do cliente: ");
        string pesquisa = Console.ReadLine().ToLower();

        bool encontrou = false;

        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].Nome.ToLower() == pesquisa)
            {
                clientes[i].ApresentarCliente();
                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Cliente não encontrado.");
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 07 - CADASTRO DE CURSOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Curso> cursos = new List<Curso>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("          CADASTRO DE CURSOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar curso");
            Console.WriteLine("2 - Listar cursos");
            Console.WriteLine("3 - Ver cursos disponíveis");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarCurso(cursos);
            }
            else if (opcao == 2)
            {
                ListarCursos(cursos);
            }
            else if (opcao == 3)
            {
                ListarCursosDisponiveis(cursos);
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarCurso(List<Curso> cursos)
    {
        Console.Clear();

        Curso curso = new Curso();

        Console.Write("Nome: ");
        curso.Nome = Console.ReadLine();

        Console.Write("Carga horária: ");
        curso.CargaHoraria = int.Parse(Console.ReadLine());

        Console.Write("Professor: ");
        curso.Professor = Console.ReadLine();

        Console.Write("Modalidade: ");
        curso.Modalidade = Console.ReadLine();

        Console.Write("Quantidade de vagas: ");
        curso.QuantidadeVagas = int.Parse(Console.ReadLine());

        cursos.Add(curso);

        Console.WriteLine("Curso cadastrado!");
        Console.ReadKey();
    }

    static void ListarCursos(List<Curso> cursos)
    {
        Console.Clear();

        if (cursos.Count == 0)
        {
            Console.WriteLine("Nenhum curso cadastrado.");
        }
        else
        {
            for (int i = 0; i < cursos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Curso " + (i + 1));
                Console.WriteLine("---------------------------------");

                cursos[i].MostrarCurso();
            }
        }

        Console.ReadKey();
    }

    static void ListarCursosDisponiveis(List<Curso> cursos)
    {
        Console.Clear();

        bool encontrou = false;

        for (int i = 0; i < cursos.Count; i++)
        {
            if (cursos[i].QuantidadeVagas > 0)
            {
                cursos[i].MostrarCurso();
                Console.WriteLine();

                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Nenhum curso disponível.");
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 08 - CADASTRO DE PEDIDOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Pedido> pedidos = new List<Pedido>();
        int opcao = 0;

        while (opcao != 3)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("         CADASTRO DE PEDIDOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar pedido");
            Console.WriteLine("2 - Listar pedidos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarPedido(pedidos);
            }
            else if (opcao == 2)
            {
                ListarPedidos(pedidos);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarPedido(List<Pedido> pedidos)
    {
        Console.Clear();

        Pedido pedido = new Pedido();

        Console.Write("Número do pedido: ");
        pedido.Numero = int.Parse(Console.ReadLine());

        Console.Write("Cliente: ");
        pedido.Cliente = Console.ReadLine();

        Console.Write("Produto: ");
        pedido.Produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        pedido.Quantidade = int.Parse(Console.ReadLine());

        Console.Write("Valor unitário: ");
        pedido.ValorUnitario = double.Parse(Console.ReadLine());

        pedidos.Add(pedido);

        Console.WriteLine("Pedido cadastrado!");
        Console.ReadKey();
    }

    static void ListarPedidos(List<Pedido> pedidos)
    {
        Console.Clear();

        if (pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido cadastrado.");
        }
        else
        {
            for (int i = 0; i < pedidos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Pedido: " + pedidos[i].Numero);
                Console.WriteLine("Cliente: " + pedidos[i].Cliente);
                Console.WriteLine("Produto: " + pedidos[i].Produto);
                Console.WriteLine("Quantidade: " + pedidos[i].Quantidade);
                Console.WriteLine("Valor unitário: R$ " + pedidos[i].ValorUnitario);
                Console.WriteLine("Total: R$ " + pedidos[i].CalcularTotal());
                Console.WriteLine("---------------------------------");
            }
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 09 - CADASTRO DE EQUIPAMENTOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Equipamento> equipamentos = new List<Equipamento>();
        int opcao = 0;

        while (opcao != 5)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("      CADASTRO DE EQUIPAMENTOS");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar equipamento");
            Console.WriteLine("2 - Listar equipamentos");
            Console.WriteLine("3 - Pesquisar equipamento");
            Console.WriteLine("4 - Equipamentos em manutenção");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarEquipamento(equipamentos);
            }
            else if (opcao == 2)
            {
                ListarEquipamentos(equipamentos);
            }
            else if (opcao == 3)
            {
                PesquisarEquipamento(equipamentos);
            }
            else if (opcao == 4)
            {
                ListarManutencao(equipamentos);
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarEquipamento(List<Equipamento> equipamentos)
    {
        Console.Clear();

        Equipamento equipamento = new Equipamento();

        Console.Write("Patrimônio: ");
        equipamento.Patrimonio = Console.ReadLine();

        Console.Write("Tipo: ");
        equipamento.Tipo = Console.ReadLine();

        Console.Write("Marca: ");
        equipamento.Marca = Console.ReadLine();

        Console.Write("Modelo: ");
        equipamento.Modelo = Console.ReadLine();

        Console.Write("Número de série: ");
        equipamento.NumeroSerie = Console.ReadLine();

        Console.Write("Status: ");
        equipamento.Status = Console.ReadLine();

        equipamentos.Add(equipamento);

        Console.WriteLine("Equipamento cadastrado!");
        Console.ReadKey();
    }

    static void ListarEquipamentos(List<Equipamento> equipamentos)
    {
        Console.Clear();

        if (equipamentos.Count == 0)
        {
            Console.WriteLine("Nenhum equipamento cadastrado.");
        }
        else
        {
            for (int i = 0; i < equipamentos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Equipamento " + (i + 1));
                Console.WriteLine("---------------------------------");

                equipamentos[i].MostrarEquipamento();
            }
        }

        Console.ReadKey();
    }

    static void PesquisarEquipamento(List<Equipamento> equipamentos)
    {
        Console.Clear();

        Console.Write("Digite o patrimônio: ");
        string pesquisa = Console.ReadLine().ToLower();

        bool encontrou = false;

        for (int i = 0; i < equipamentos.Count; i++)
        {
            if (equipamentos[i].Patrimonio.ToLower() == pesquisa)
            {
                equipamentos[i].MostrarEquipamento();
                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Equipamento não encontrado.");
        }

        Console.ReadKey();
    }

    static void ListarManutencao(List<Equipamento> equipamentos)
    {
        Console.Clear();

        bool encontrou = false;

        for (int i = 0; i < equipamentos.Count; i++)
        {
            if (equipamentos[i].Status.ToLower() == "manutenção")
            {
                equipamentos[i].MostrarEquipamento();
                Console.WriteLine();

                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Nenhum equipamento em manutenção.");
        }

        Console.ReadKey();
    }
}

*/


// ==========================================================
// EXERCÍCIO 10 - DESAFIO FINAL - ALUNOS
// ==========================================================

/*

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();

            Console.WriteLine("=============================================");
            Console.WriteLine("          SISTEMA DE CADASTRO DE ALUNOS");
            Console.WriteLine("=============================================");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Pesquisar aluno");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarAluno(alunos);
            }
            else if (opcao == 2)
            {
                ListarAlunos(alunos);
            }
            else if (opcao == 3)
            {
                PesquisarAluno(alunos);
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarAluno(List<Aluno> alunos)
    {
        Console.Clear();

        Aluno aluno = new Aluno();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        aluno.Cidade = Console.ReadLine();

        Console.Write("Curso: ");
        aluno.Curso = Console.ReadLine();

        Console.Write("Nota: ");
        aluno.Nota = double.Parse(Console.ReadLine());

        alunos.Add(aluno);

        Console.WriteLine("Aluno cadastrado com sucesso!");
        Console.ReadKey();
    }

    static void ListarAlunos(List<Aluno> alunos)
    {
        Console.Clear();

        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
        }
        else
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Aluno " + (i + 1));
                Console.WriteLine("---------------------------------");

                alunos[i].Apresentar();
            }
        }

        Console.ReadKey();
    }

    static void PesquisarAluno(List<Aluno> alunos)
    {
        Console.Clear();

        Console.Write("Digite o nome do aluno: ");
        string pesquisa = Console.ReadLine().ToLower();

        bool encontrou = false;

        for (int i = 0; i < alunos.Count; i++)
        {
            if (alunos[i].Nome.ToLower() == pesquisa)
            {
                alunos[i].Apresentar();
                encontrou = true;
            }
        }

        if (encontrou == false)
        {
            Console.WriteLine("Aluno não encontrado.");
        }

        Console.ReadKey();
    }
}

*/
