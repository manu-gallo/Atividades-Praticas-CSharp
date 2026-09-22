using System;

// ==========================================================
// EXERCÍCIO 01 - PRODUTO
// ==========================================================

class Produto
{
    public string Nome;
    public string Categoria;
    public double Preco;
    public int Quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Categoria: " + Categoria);
        Console.WriteLine("Preço: R$ " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor total em estoque: R$ " + (Preco * Quantidade));
    }
}


// ==========================================================
// EXERCÍCIO 02 - LIVRO
// ==========================================================

class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public string Categoria;
    public bool Disponivel;

    public void MostrarLivro()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Categoria: " + Categoria);

        if (Disponivel == true)
        {
            Console.WriteLine("Status: DISPONÍVEL");
        }
        else
        {
            Console.WriteLine("Status: EMPRESTADO");
        }
    }
}


// ==========================================================
// EXERCÍCIO 03 - FUNCIONÁRIO
// ==========================================================

class Funcionario
{
    public string Nome;
    public int Idade;
    public string Cargo;
    public double Salario;
    public string Setor;

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Setor: " + Setor);
        Console.WriteLine("Salário: R$ " + Salario);
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }
}


// ==========================================================
// EXERCÍCIO 04 - VEÍCULO
// ==========================================================

class Veiculo
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public string Placa;

    public void MostrarVeiculo()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Cor: " + Cor);
        Console.WriteLine("Placa: " + Placa);
    }
}


// ==========================================================
// EXERCÍCIO 05 - FILME
// ==========================================================

class Filme
{
    public string Titulo;
    public string Genero;
    public int Ano;
    public int Duracao;
    public double Nota;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Duração: " + Duracao + " minutos");
        Console.WriteLine("Nota: " + Nota);

        if (Nota >= 8)
        {
            Console.WriteLine("Filme com nota maior ou igual a 8!");
        }
    }
}


// ==========================================================
// EXERCÍCIO 06 - CLIENTE
// ==========================================================

class Cliente
{
    public string Nome;
    public int Idade;
    public string Cidade;
    public string Email;
    public string Telefone;

    public void ApresentarCliente()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cidade: " + Cidade);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Telefone: " + Telefone);
    }
}


// ==========================================================
// EXERCÍCIO 07 - CURSO
// ==========================================================

class Curso
{
    public string Nome;
    public int CargaHoraria;
    public string Professor;
    public string Modalidade;
    public int QuantidadeVagas;

    public void MostrarCurso()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Carga horária: " + CargaHoraria + " horas");
        Console.WriteLine("Professor: " + Professor);
        Console.WriteLine("Modalidade: " + Modalidade);
        Console.WriteLine("Quantidade de vagas: " + QuantidadeVagas);
    }
}


// ==========================================================
// EXERCÍCIO 08 - PEDIDO
// ==========================================================

class Pedido
{
    public int Numero;
    public string Cliente;
    public string Produto;
    public int Quantidade;
    public double ValorUnitario;

    public double CalcularTotal()
    {
        return Quantidade * ValorUnitario;
    }
}


// ==========================================================
// EXERCÍCIO 09 - EQUIPAMENTO
// ==========================================================

class Equipamento
{
    public string Patrimonio;
    public string Tipo;
    public string Marca;
    public string Modelo;
    public string NumeroSerie;
    public string Status;

    public void MostrarEquipamento()
    {
        Console.WriteLine("Patrimônio: " + Patrimonio);
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Número de série: " + NumeroSerie);
        Console.WriteLine("Status: " + Status);
    }
}


// ==========================================================
// EXERCÍCIO 10 - ALUNO
// ==========================================================

class Aluno
{
    public string Nome;
    public int Idade;
    public string Cidade;
    public string Curso;
    public double Nota;

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cidade: " + Cidade);
        Console.WriteLine("Curso: " + Curso);
        Console.WriteLine("Nota: " + Nota);
    }
}