
using PetShopApp.Modelos;

Dono dono1 = new("Layssa");
Dono dono2 = new("Marcos");

Animal dog = new Cachorro("Rex", 5, 12.5, "Labrador", "Grande", "Brincalhão", dono1);
Animal gato = new Gato("Mimi", 3, 4.2, "Curta", "Independente", dono2);
Animal passaro = new Passaro("Piu", 1, 0.3, "Canário", 25.5, dono1);

List<Animal> pets = [dog, gato, passaro];

foreach (var pet in pets)
{
    Console.WriteLine("\n--- Dados do animal ---");
    pet.Notificar(pet);
    Servico.ConsultaVeterinaria(pet);
    Servico.BanhoTosa(pet);
    Servico.EscovarPelos(pet);
    Servico.LimpezaGaiola(pet);

}
