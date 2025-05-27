using System;

namespace CursosOnline.Modelos;

public class Aula(string descricao, int duracao, string professor)
{
    public string Descricao { get; set; } = descricao;
    public int Duracao { get; set; } = duracao;
    public string Professor { get; set; } = professor;

}
