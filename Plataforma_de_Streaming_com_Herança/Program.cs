using Plataforma_de_Streaming_com_Herança.Modelos;

var filme = new Filme("A Origem", TimeSpan.FromMinutes(148), "Ficção", "Christopher Nolan", 2010,
            new List<string> { "Leonardo DiCaprio", "Elliot Page", "Tom Hardy" });

        var serie = new Serie("Dark", TimeSpan.FromMinutes(500), "Suspense", 3);
        serie.AdicionarEpisodio(new Episodio("Segredos", 1, TimeSpan.FromMinutes(45)));
        serie.AdicionarEpisodio(new Episodio("Mentiras", 2, TimeSpan.FromMinutes(50)));

        var doc = new Documentario("Terra", TimeSpan.FromMinutes(60), "Natureza", "Planeta Terra", "David Attenborough");

        var catalogo = new List<Midia> { filme, serie, doc };

        Console.WriteLine("=== CATÁLOGO DE STREAMING ===\n");
        foreach (var midia in catalogo)
        {
            midia.ExibirResumo();
        }

