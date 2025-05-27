using System;
using PetShopApp.Modelos.Interfaces;

namespace PetShopApp.Modelos;

public abstract class Animal(string nome, int idade, double peso, Dono dono): INotificacao
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public double Peso { get; set; } = peso;
    public Dono Dono { get; set; } = dono;

    public virtual void Notificar(Animal animal)
    {
        Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Peso: {Peso} - Dono: {Dono.Nome}");
    }
}
