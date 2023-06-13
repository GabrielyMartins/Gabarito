public class Gabarito
{
    char[] gabaritoCorreto = { 'A', 'B', 'C', 'B', 'A', 'D', 'E', 'E', 'B', 'A', 'D', 'C', 'A', 'E', 'B' };

    public char RespostaQuestao(int numeroQuestao)
    {
        return this.gabaritoCorreto[numeroQuestao];
    }
}
