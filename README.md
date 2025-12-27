## Sobre o projeto

O **Library Management** é uma API desenvolvida em **ASP.NET Core** com o objetivo de simular o gerenciamento de livros em uma biblioteca.  
O projeto foi criado com fins **educacionais**, permitindo praticar conceitos fundamentais de **Web API**, **DTOs**, **rotas HTTP**, **validações**, **CRUD** e **organização em camadas**, sem a utilização de banco de dados.

Todos os dados são armazenados **em memória**, utilizando listas estáticas, o que possibilita testes completos via **Swagger** ou **Postman** sem a necessidade de configurações externas.

---

## Objetivo

O principal objetivo do projeto é:

- Compreender o funcionamento de uma API REST
- Trabalhar com diferentes rotas HTTP (GET, POST, PUT)
- Separar responsabilidades utilizando DTOs e DALs
- Implementar validações de dados
- Simular persistência de dados sem banco de dados
- Realizar testes utilizando Swagger e Postman

---

## Funcionalidades

A API oferece as seguintes funcionalidades:

- Cadastro de livros
- Listagem de todos os livros cadastrados
- Busca de livro por **Id**
- Atualização de dados de um livro existente
- Validações de campos obrigatórios e regras de negócio

---

## Armazenamento dos dados

Este projeto **não utiliza banco de dados**.  
Os dados são mantidos em memória enquanto a aplicação está em execução.

⚠️ **Importante:**  
Ao reiniciar a aplicação, todos os dados são reinicializados para o estado inicial.

Essa abordagem foi escolhida para simplificar o projeto e focar no aprendizado da lógica da API.

---

## Tecnologias utilizadas

- .NET 8
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
- Postman

---

## Como executar o projeto

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git

cd Library_Management_Api

dotnet run

https://localhost:7144/swagger
