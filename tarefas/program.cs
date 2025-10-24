Console.WriteLine("Salve tropa!");

Console.WriteLine("Preenchendo dados tarefa 01");
var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazer compras";
tarefa01.Descricao  = "Comprar arroz, feijão e frutas";
tarefa01.DataCriacao = DateTime.Now; 
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");


Console.WriteLine("Teste para alterar:");
var tarefaParaAlterar = new Tarefa
{
    Id = idInserido, 
    Nome = "Fazer compras (ATUALIZADO)",
    Descricao = "Comprar Arroz, Feijão, Frutas, e adicionar CARNE.",
    DataCriacao = tarefa01.DataCriacao,
    Status = 2, 
    DataExecucao = DateTime.Now.AddDays(3) 
};
Console.WriteLine($"Tarefa com ID {idInserido} ALTERADA com sucesso!");


Console.WriteLine("Testando metodo excluir:");
int idParaExcluir = idInserido;
operacoes.Excluir(idParaExcluir);
Console.WriteLine($"Tarefa com ID {idParaExcluir} excluída com sucesso!");


