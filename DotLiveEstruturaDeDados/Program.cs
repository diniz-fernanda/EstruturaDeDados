//Pilha
using System.Reflection.Metadata;

Stack<string> historico = new Stack<string>();

historico.Push("luisdev.com.br");           //Adicionar na pilha o último dado
historico.Push("luisdev.com.br/artigo-1");
historico.Push("luisdev.com.br/cursos-e-mentorias");

Console.WriteLine("PILHA");
Console.WriteLine();

Console.WriteLine(historico.Peek());        //Retornar o dado 

var paginaAnterior = historico.Pop();       //Retorna e remove o dado

Console.WriteLine($"Página anterior: {paginaAnterior}");
Console.WriteLine($"Página atual: {historico.Peek()}");

Console.WriteLine("-----------------");

//Fila
Queue<string> filaAtendimento = new Queue<string>();

filaAtendimento.Enqueue("A-001");
filaAtendimento.Enqueue("A-002");
filaAtendimento.Enqueue("A-003");

Console.WriteLine("FILA");
Console.WriteLine();

Console.WriteLine(filaAtendimento.Peek());

var atendido = filaAtendimento.Dequeue();

Console.WriteLine($"Atendido: {atendido}");
Console.WriteLine($"Próximo da fila: {filaAtendimento.Peek()}");
Console.WriteLine("-----------------");

//Matriz
int[] notas1d = new int[2]; // 0 => 85, 1 => 90

notas1d[0] = 85;
notas1d[1] = 90;

Console.WriteLine("MATRIZES");
Console.WriteLine();

Console.WriteLine("Notas de Estudante na Matriz 1D");

for(var i = 0; i < notas1d.Length; i++)
{
    Console.WriteLine(notas1d[i]);
}

int[,] notas2d = new int[3, 2];

notas2d[0, 0] = 85; //A, Primeiro Bimestre
notas2d[0, 1] = 90; //A, Segundo Bimestre
notas2d[1, 0] = 55; //B, Primeiro Bimestre
notas2d[1, 1] = 100; //B, Segundo Bimestre
notas2d[2, 0] = 60; //C, Primeiro Bimestre
notas2d[2, 1] = 90; //C, Segundo Bimestre

Console.WriteLine("Notas de Estudantes na Matriz 2D");

for(var i = 0; i < notas2d.GetLength(0); i++)
{
    Console.WriteLine($"Estudante {i}");
    for(var j = 0; j < notas2d.GetLength(1); j++)
    {
        Console.WriteLine(notas2d[i, j] + "");
    }

    Console.WriteLine();
}
//HashSet
HashSet<string> youTubePlaylist = new HashSet<string>();

youTubePlaylist.Add("Video1");
youTubePlaylist.Add("Video2");
youTubePlaylist.Add("Video3");
youTubePlaylist.Add("Video2");

Console.WriteLine($"Tamanho da Playlist: {youTubePlaylist.Count}");

youTubePlaylist.Remove("Video2");

var contemVideo3 = youTubePlaylist.Contains("Video3");

Console.WriteLine($"Contem video 3: {contemVideo3}");

Console.WriteLine($"Tamanho da Playslist: {youTubePlaylist.Count}");

//Dicionário


//Lista Ligada
