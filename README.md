
# ATIVIDADE SOBRE ASSOCIAÇÃO E HERANÇA – Programação Orientada a Objetos (POO)

**Alunos:** João Pedro Z. S, Layssa Alves, Vitor Paladini

## Objetivo

Esta Atividade Prática tem como objetivo aplicar os principais conceitos de **Programação Orientada a Objetos (POO)** em C#, por meio do desenvolvimento de sistemas baseados em problemas do mundo real. Os exercícios exploram **associação entre objetos**, **composição**, **herança**, **polimorfismo**, e **validações**, reforçando a capacidade de modelagem e implementação de soluções orientadas a objetos.

---

## Exercícios Desenvolvidos

### 1. Sistema de Biblioteca com Empréstimos
- Cadastra livros e leitores.
- Permite realizar e devolver empréstimos.
- Garante que um livro não possa ser emprestado se já estiver indisponível.

### 2. Sistema de Cadastro Escolar com Herança
- Utiliza herança para modelar pessoas: `Aluno`, `Professor`, `Funcionário`.
- Permite manipular uma lista de pessoas heterogênea.
- Demonstra polimorfismo com métodos sobrescritos.

### 3. Plataforma de Cursos Online
- Alunos se matriculam em cursos (relação N:N).
- Cursos contêm aulas (composição).
- Matricula armazena data de inscrição e progresso.

### 4. Aplicativo de Pet Shop com Herança
- Hierarquia de pets: `Cachorro`, `Gato`, `Pássaro`.
- Serviços restritos a determinados tipos de animais.
- Associação com o dono do animal.

### 5. Sistema de Vendas com Composição
- `Pedido` contém `ItemPedido`, que referencia um `Produto`.
- Cálculo automático do valor total do pedido.
- Composição garante integridade dos itens dentro do pedido.

### 6. Controle de Veículos e Manutenções
- Cada veículo pode ter várias manutenções.
- Validação impede múltiplas manutenções no mesmo dia.
- Registro de histórico completo de serviços.

### 7. Sistema de Recrutamento
- Candidatos podem se candidatar a várias vagas (relação N:N).
- Candidatura armazena data e status.
- Permite consultas em ambas as direções: por vaga e por candidato.

### 8. Plataforma de Streaming com Herança
- Modelagem de `Mídia`: `Filme`, `Série`, `Documentário`.
- Série possui relação de composição com `Episódio`.
- Polimorfismo para exibir resumos de forma diferenciada.

### 9. Aplicativo de Controle de Treinos
- Alunos com treinos personalizados contendo exercícios.
- Exercício possui séries, repetições e carga.
- Calcula carga total do treino (séries × repetições × peso).

### 10. Sistema de Eventos Culturais
- Modelagem de `Evento`: `Oficina`, `Palestra`, `Show`.
- Participantes podem se inscrever em múltiplos eventos (relação N:N).
- Método polimórfico para exibir informações específicas de cada tipo.

---

## Como Executar

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

2. Navegue até o diretório de qualquer exercício:
```bash
cd CadastroEscolar
```

3. Execute o projeto:
```bash
dotnet run
```

---

## Organização do Repositório

Cada exercício está organizado em uma pasta separada:

```
├── CadastroEscolar/
├── Controle_de_Veículos_e_Manutenções/
├── CursosOnline/
├── PetShopApp/
├── Plataforma_de_Streaming_com_Herança/
├── SistemaBiblioteca/
├── SistemaDeVendas/
├── Sistema_de_Recrutamento/
├── 
├── 
```

---

## Observações

- Todos os sistemas utilizam **validações rigorosas** para garantir a integridade das informações.
- As implementações aplicam **encapsulamento**, **associação**, **herança**, **composição** e **polimorfismo** conforme o contexto de cada problema.
