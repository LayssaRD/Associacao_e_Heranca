using System;

namespace PetShopApp.Modelos;

public class Cachorro(string nome, int idade, double peso, string raca, string porte, string temperamento, Dono dono) : Animal(nome, idade, peso, dono)
{
    public string Raca { get; set; } = raca;
    public string Porte { get; set; } = porte;
    public string Temperamento { get; set; } = temperamento;

    public override void Notificar(Animal animal)
    {
        base.Notificar(animal);
        Console.WriteLine($"Raça: {Raca} - Porte: {Porte} - Temperamento: {Temperamento}");
    }

}
