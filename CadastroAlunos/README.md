# Cadastro de Alunos - ASP.NET MVC

Projeto feito para a disciplina de **Desenvolvimento Web** 💻

## O que o projeto faz

Um formulário simples para cadastrar alunos com validação de dados. Quando o formulário é preenchido corretamente, redireciona para uma página de confirmação.

## Tecnologias usadas

- ASP.NET Core MVC
- C#
- Data Annotations para validação
- Bootstrap 5 (via CDN)
- Tag Helpers do Razor

## Como rodar

1. Clone o repositório
2. Abra no Visual Studio ou VS Code
3. Rode o comando:

```bash
dotnet run
```

4. Acesse `https://localhost:5001/Aluno/Cadastrar`

## Estrutura do projeto

```
CadastroAlunos/
├── Models/
│   └── Aluno.cs              # Model com Data Annotations
├── Controllers/
│   └── AlunoController.cs    # Controller com GET e POST
├── Views/
│   └── Aluno/
│       ├── Cadastrar.cshtml  # Formulário de cadastro
│       └── Confirmacao.cshtml # Página de sucesso
└── README.md
```

## Funcionalidades

- [x] Formulário com campos: Nome, Email, RA, Curso e Data de Nascimento
- [x] Validação com Data Annotations (Required, EmailAddress, StringLength)
- [x] Mensagens de erro inline com `asp-validation-for`
- [x] Página de confirmação exibindo os dados cadastrados
- [x] Botão "Cadastrar outro" para voltar ao formulário

## Aluno

Feito por: **[Seu Nome]**  
RA: **[Seu RA]**  
Curso: **[Seu Curso]**  
Disciplina: Desenvolvimento Web  
Professor: **[Nome do Professor]**
