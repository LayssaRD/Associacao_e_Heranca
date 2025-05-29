using Controle_de_Veículos_e_Manutenções.Modelos;

var carro = new Veiculo("Honda Civic", "ABC-1234", "passeio");

carro.AdicionarManutencao(new Manutencao(new DateTime(2025, 5, 29), "Troca de óleo", "preventiva"));
carro.AdicionarManutencao(new Manutencao(new DateTime(2025, 5, 29), "Reparo na suspensão", "corretiva")); 
carro.AdicionarManutencao(new Manutencao(new DateTime(2025, 6, 1), "Alinhamento", "preventiva"));
carro.AdicionarManutencao(new Manutencao(new DateTime(2025, 5, 1), "Troca de Pneus", "corretiva"));

carro.ListarManutencoes();

