# API de Clientes

API simples para cadastro e listagem de clientes, desenvolvida como desafio técnico utilizando .NET.

## Como rodar o projeto

### Pré-requisitos
- .NET SDK **6 ou superior** (o projeto foi desenvolvido em .NET 9)

Verifique a versão instalada:
bash
dotnet --version

### Executando a aplicação
- Clone o repositório
- Acesse a pasta do projeto (DesafioSGBR)
- Execute o comando no terminal: dotnet run
- A API estará disponível em: http://localhost:5149

## Endpoints disponíveis
POST /clientes
Body:
{
  "nome": "João Pedro",
  "email": "joao@email.com"
}
Regras:
- Nome é obrigatório
- Email é obrigatório
- Email deve ser válido
- Não é permitido email duplicado

GET /clientes
Retorno:
[
  {
    "id": "guid",
    "nome": "João Pedro",
    "email": "joao@email.com"
  }
]

## Tecnologias Utilizadas
- .NET 9
- C#
- Minimal API

## Decisões Técnicas
- Minimal API foi utilizada para manter o projeto simples, com menos boilerplate e foco nas regras de negócio.
- A persistência em memória foi escolhida por atender ao escopo do desafio e reduzir complexidade, conforme permitido nas instruções.
- As validações foram feitas manualmente, garantindo controle total das regras e das mensagens de erro, todas retornadas em português e com formato padronizado.
- A validação foi centralizada em uma classe de Validator para manter os endpoints mais limpos e organizados.
- Em um cenário real, a persistência em memória poderia ser facilmente substituída por um banco de dados como SQLite, SQL Server, PostgreSQL, dentre outros.

## Observações Finais
Este projeto foi desenvolvido respeitando o escopo do desafio, evitando overengineering e priorizando clareza, organização e boas práticas.
