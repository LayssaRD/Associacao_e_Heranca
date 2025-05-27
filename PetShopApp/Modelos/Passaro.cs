using System;

namespace PetShopApp.Modelos;

public class Passaro(string nome, int idade, double peso, string especie, double envergadura, Dono dono) : Animal(nome, idade, peso, dono)
{
    public string Especie { get; set; } = especie;
    public double Envergadura { get; set; } = envergadura;

    public override void Notificar(Animal animal)
    {
        base.Notificar(animal);
        Console.WriteLine($"Espécie: {Especie} - Envergadura: {Envergadura}");
    }

}
