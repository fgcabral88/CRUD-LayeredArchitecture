## Sobre o Projeto

Este projeto é um CRUD para a entidade **Tax** (Imposto), desenvolvido em .NET 8 utilizando o padrão de arquitetura em camadas (Layered Architecture). O objetivo é demonstrar uma estrutura de código organizada, separando responsabilidades em camadas distintas para facilitar manutenção, testes e escalabilidade.

## Tecnologias Utilizadas

- .NET 8  
- ASP.NET Core  
- Entity Framework Core  
- MySQL  

## Estrutura do Projeto

- **Domain:** Contém as entidades de domínio e interfaces dos repositórios.
- **Application:** Inclui os serviços de aplicação e DTOs.
- **Infrastructure:** Implementa os repositórios e o contexto de dados.
- **Presentation (Controllers):** Expõe as APIs para interação externa.

## Endpoints Principais

- `GET /api/tax` — Lista todos os impostos
- `GET /api/tax/{id}` — Busca imposto por ID
- `POST /api/tax` — Cria um novo imposto
- `PUT /api/tax/{id}` — Atualiza um imposto existente
- `DELETE /api/tax/{id}` — Remove um imposto

## Boas Práticas Adotadas

- Separação de responsabilidades por camadas (Layered Architecture)
- Injeção de dependência para facilitar testes e manutenção
- Uso de DTOs para transferência de dados entre camadas

## Contribuição

Contribuições são bem-vindas! Para grandes mudanças, abra uma issue para discussão prévia.
