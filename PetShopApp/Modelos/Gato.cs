using System;

namespace PetShopApp.Modelos;

public class Gato(string nome, int idade, double peso, string pelagem, string comportamento, Dono dono) : Animal(nome, idade, peso, dono)
{
    public string Pelagem { get; set; } = pelagem;
    public string Comportamento { get; set; } = comportamento;

    public override void Notificar(Animal animal)
    {
        base.Notificar(animal);
        Console.WriteLine($"Pelagem: {Pelagem} - Comportamento: {Comportamento}");
    }

}
