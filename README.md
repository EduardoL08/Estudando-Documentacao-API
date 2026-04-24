# 📚 API Biblioteca

API REST desenvolvida em ASP.NET Core para gerenciamento de autores, livros e empréstimos.

---

## 🚀 Tecnologias utilizadas

* .NET 6 / .NET 7
* ASP.NET Core Web API
* Swagger (OpenAPI)
* C#

---

## 📂 Estrutura do Projeto

```
BibliotecaApi/
├── Controllers/
│   ├── AutoresController.cs
│   ├── LivrosController.cs
│   └── EmprestimosController.cs
├── Models/
│   ├── Autor.cs
│   ├── Livro.cs
│   ├── Emprestimo.cs
│   └── RespostaPaginada.cs
├── Data/
│   └── BibliotecaRepository.cs
├── Program.cs
└── appsettings.json
```

---

## 📌 Funcionalidades

### 👤 Autores

* Listar autores
* Buscar autor por ID
* Criar autor
* Atualizar autor
* Remover autor

---

### 📖 Livros

* Listar livros com paginação
* Buscar livro por ID
* Buscar livros por filtros (título, gênero, autor)
* Criar livro
* Atualizar livro
* Remover livro

---

### 🔄 Empréstimos

* Listar empréstimos
* Buscar empréstimo por ID
* Realizar empréstimo de livro
* Registrar devolução

---

## 📊 Padrão de respostas HTTP

| Código | Descrição                         |
| ------ | --------------------------------- |
| 200    | Sucesso                           |
| 201    | Criado com sucesso                |
| 204    | Sem conteúdo                      |
| 400    | Erro de validação                 |
| 404    | Não encontrado                    |
| 409    | Conflito (ex: livro indisponível) |

---

## 📄 Documentação (Swagger)

A API possui documentação interativa com Swagger.

Após rodar o projeto, acesse:

```
https://localhost:{porta}/swagger
```

---

## ▶️ Como executar o projeto

### 1. Clonar o repositório

```
git clone https://github.com/seu-usuario/seu-repositorio.git
```

---

### 2. Acessar a pasta

```
cd BibliotecaApi
```

---

### 3. Executar a aplicação

```
dotnet run
```

ou

```
dotnet watch run
```

---

## 🧪 Exemplos de uso

### Criar autor

```json
POST /api/autores

{
  "nome": "Machado de Assis"
}
```

---

### Criar empréstimo

```json
POST /api/emprestimos

{
  "livroId": 1,
  "nomeUsuario": "João Silva"
}
```

---

## 📚 Conceitos aplicados

* API RESTful
* Injeção de dependência (Dependency Injection)
* Paginação de dados
* Validação com Data Annotations
* Documentação com Swagger
* Boas práticas de organização de código

---

## 👨‍💻 Autor

Projeto desenvolvido para fins de estudo em documentação de APIs e boas práticas com ASP.NET Core.

---

## 📌 Observações

* Projeto acadêmico voltado para aprendizado
* Não utiliza banco de dados (dados em memória)
* Foco em estrutura e documentação da API

---
