# TasksApp Backend

Este é o backend do projeto **TasksApp**, uma aplicação para gerenciamento de tarefas. Este projeto foi desenvolvido em C# utilizando o ASP.NET, aplicando conceitos de Clean Architecture e CQRS pois é o que estou estudando
e buscando aplicar para aprender ainda mais.

#Observação: o projeto ainda está em andamento...

## Tecnologias Utilizadas

- **C#**
- **ASP.NET Core**
- **Entity Framework Core**
- **MediatR**
- **Fluent Validation**
- **Sql Server

## Estrutura do Projeto

O projeto segue a arquitetura limpa (Clean Architecture) e implementação do padrão CQRS:

- **Domain**: Contém as entidades e regras de negócio.
- **Application**: Contém os casos de uso, serviços e comandos.
- **Infrastructure**: Implementações específicas de infraestrutura, como acesso a banco de dados.
- **API**: Camada que expõe os endpoints da aplicação.
- **CQRS**: Utilizado para melhorar a questão das ações e da leitura das informações. Inclusive implentado os handlers para lidar com a lógica de um determinado comand.
