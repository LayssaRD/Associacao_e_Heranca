using System;

namespace PetShopApp.Modelos;

public static class Servico
{
    public static void ConsultaVeterinaria(Animal animal)
    {
        Console.WriteLine($"Consulta veterinária agendada para {animal.Nome}.");
    }
    
    public static void BanhoTosa(Animal animal)
    {
        if (animal is Cachorro)
        {
            Console.WriteLine($"Banho & Tosa realizado no cachorro {animal.Nome}.");
        }
        else
        {
            Console.WriteLine($"O serviço de Banho & Tosa só está disponível para cachorros. {animal.Nome} não é um cachorro.");
        }
    }

    public static void LimpezaGaiola(Animal animal)
    {
        if (animal is Passaro)
        {
            Console.WriteLine($"Gaiola do pássaro {animal.Nome} foi limpa com sucesso.");
        }
        else
        {
            Console.WriteLine($"A limpeza de gaiola é exclusiva para pássaros. {animal.Nome} não é um pássaro.");
        }
    }

    public static void EscovarPelos(Animal animal)
    {
        if (animal is Cachorro || animal is Gato)
        {
            Console.WriteLine($"Pelagem de {animal.Nome} escovada com sucesso.");
        }
        else
        {
            Console.WriteLine($"{animal.Nome} não possui pelagem escovável.");
        }
    }

}
