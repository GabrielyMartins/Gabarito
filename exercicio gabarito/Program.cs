Gabarito g = new Gabarito();
Prova p = new Prova(g);

Console.WriteLine("Informe o nome do aluno!");
string nome = Console.ReadLine();

for(int i = 0; i < p.respostaAluno.Length; i++)
{
    Console.WriteLine($"Informe a resposta da questão {i+1} ");  
    char resposta = Convert.ToChar(Console.ReadLine());
    p.RespostaAluno(char.ToUpper(resposta));
}
Console.WriteLine($"A quantidade de acertos é {p.Acertos()}");
Console.WriteLine($"A sua nota é {p.Nota()}");