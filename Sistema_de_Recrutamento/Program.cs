using Sistema_de_Recrutamento.Modelos;

        var vaga1 = new Vaga("Desenvolvedor C#", "Tech Solutions", "Desenvolvimento de aplicações web");
        var vaga2 = new Vaga("Analista de Dados", "DataCorp", "Análise e interpretação de dados");

        var candidato1 = new Candidato("Ana Silva", "ana@email.com", "Formação em TI e 3 anos de experiência");
        var candidato2 = new Candidato("Bruno Souza", "bruno@email.com", "Especialista em análise de dados");

      
        var cand1 = new Candidatura(candidato1, vaga1, DateTime.Today.AddDays(-5), "Enviada");
        var cand2 = new Candidatura(candidato2, vaga1, DateTime.Today.AddDays(3), "Em análise");
        var cand3 = new Candidatura(candidato2, vaga2, DateTime.Today.AddDays(2), "Enviada");

        
        vaga1.AdicionarCandidatura(cand1);
        vaga1.AdicionarCandidatura(cand2);
        vaga2.AdicionarCandidatura(cand3);

        candidato1.AdicionarCandidatura(cand1);
        candidato2.AdicionarCandidatura(cand2);
        candidato2.AdicionarCandidatura(cand3);


        var vagas = new List<Vaga> { vaga1, vaga2 };

        Console.WriteLine("=== VAGAS E CANDIDATOS ===");
        foreach (var vaga in vagas)
        {
            Console.WriteLine($"\n{vaga}");
            if (vaga.Candidaturas.Count == 0)
            {
                Console.WriteLine("Nenhum candidato.");
            }
            else
            {
                foreach (var candidatura in vaga.Candidaturas)
                {
                    Console.WriteLine($"- {candidatura}");
                }
            }
        }

      
        Console.WriteLine($"\nVagas que {candidato2.Nome} se candidatou:");
        foreach (var cand in candidato2.Candidaturas)
            Console.WriteLine(cand);
