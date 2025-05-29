using Plataforma_de_Streaming_com_Herança.Modelos;

var filme = new Filme("A Origem", TimeSpan.FromMinutes(148), "Ficção", "Christopher Nolan", 2010,
            new List<string> { "Leonardo DiCaprio", "Elliot Page", "Tom Hardy" });

        var serieDark = new Serie("Dark", TimeSpan.FromMinutes(500), "Suspense", 3);
        serieDark.AdicionarEpisodio(new Episodio("Segredos", 1, TimeSpan.FromMinutes(45)));
        serieDark.AdicionarEpisodio(new Episodio("Mentiras", 2, TimeSpan.FromMinutes(50)));

        var serieStrangerThings = new Serie("Stranger Things", TimeSpan.FromMinutes(600), "Ficção", 4);
        serieStrangerThings.AdicionarEpisodio(new Episodio("Desaparecimento", 1, TimeSpan.FromMinutes(50)));
        serieStrangerThings.AdicionarEpisodio(new Episodio("A Verdade", 2, TimeSpan.FromMinutes(55)));

        var doc = new Documentario("Terra", TimeSpan.FromMinutes(60), "Natureza", "Planeta Terra", "David Attenborough");

        var catalogo = new List<Midia> { filme, serieDark, serieStrangerThings, doc };

        Console.WriteLine("=== CATÁLOGO DE STREAMING - ANTES DA EXCLUSÃO ===\n");
        foreach (var midia in catalogo)
        {
            midia.ExibirResumo();
        }

        // Removendo a série "Dark"
        catalogo.Remove(serieDark);

        Console.WriteLine("=== CATÁLOGO DE STREAMING - APÓS REMOVER 'Dark' ===\n");
        foreach (var midia in catalogo)
        {
            midia.ExibirResumo();
        }



