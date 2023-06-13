class Prova
{
    public char[] respostaAluno = new char[15];
    Gabarito gaba;

    public Prova(Gabarito gaba)
    {
        this.gaba = gaba;
    }
    public void RespostaAluno(char respostaAlu) 
    { 
        for(int i = 0; i < respostaAluno.Length; i++) 
        {
            if (respostaAluno[i] == 0)
            {
                respostaAluno[i] = respostaAlu;
                break;
            }
        }
    }
    public int Acertos()
    {
        int qtdAcertos = 0;
        for(int i = 0; i < respostaAluno.Length;i++) 
        {
            if (respostaAluno[i] == gaba.RespostaQuestao(i))
            {
                qtdAcertos += 1;
            }
        }
        return qtdAcertos;
    }

    public double Nota()
    {
        double nota = 0;
        for( int i = 0; i < respostaAluno.Length; i++)
        {
            if (respostaAluno[i] == gaba.RespostaQuestao(i))
            {
                if(i < 10)
                {
                    nota += 0.5;
                }
                else
                {
                    nota += 1;
                }
            }
        }
        return nota;
    }
}                         