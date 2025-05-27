using CursosOnline.Modelos;

Curso curso1 = new("Lógica de Programação");
curso1.AdicionarAula(new Aula("Introdução", 30, "Prof. Marcos"));
curso1.AdicionarAula(new Aula("Condicionais", 45, "Prof. Marcos"));

Curso curso2 = new("Banco de Dados");
curso2.AdicionarAula(new Aula("Modelagem ER", 40, "Prof. Ana"));
curso2.AdicionarAula(new Aula("SQL Básico", 50, "Prof. Ana"));

Aluno aluno1 = new("Layssa Alves");
Aluno aluno2 = new("Lorena Mendes");

Matricula.RealizarMatricula(aluno1, curso1);
Matricula.RealizarMatricula(aluno1, curso2);
Matricula.RealizarMatricula(aluno2, curso1);

aluno1.MostrarCursos();
aluno2.MostrarCursos();

curso1.MostrarAulas();
curso2.MostrarAulas();