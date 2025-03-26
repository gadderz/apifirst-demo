# Projeto de Documentação OpenAPI - Marketplace

## 📌 Descrição
Este projeto foi desenvolvido como exemplo para a matéria de APIs e Web Services na Pós-Graduação de Arquitetura de Software Distribuído da PUC Minas. O objetivo é demonstrar a abordagem API-First, onde a especificação da API é criada antes da implementação.

O sistema representa um marketplace básico com operações para:
- Gerenciamento de produtos
- Cadastro de usuários/vendedores
- Processamento de pedidos

## 🛠️ Tecnologias Utilizadas
- .NET 9+
- OpenAPI 3.0
- SwaggerUI
- ASP.NET Core

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone [URL_DO_REPOSITORIO]
   ```
2. Restaure as dependências:
   ```bash
   dotnet restore
   ```
3. Execute o projeto:
   ```bash
   dotnet run
   ```
4. Acesse a documentação Swagger em:
   ```bash
   https://localhost:[PORT]/swagger
   ```

## 🔍 Abordagem API-First
Este projeto segue a metodologia API-First, onde:

1. A especificação OpenAPI foi definida primeiro (em /openapi/v1.json e /openapi/v2.json)
2. Os controladores e modelos foram gerados/implementados com base na especificação
3. A documentação é o artefato principal, não o código

## 🧩 Estrutura do Projeto
```
/src/ApiFirst.Demo
│
├── Controllers/         # Controladores com anotações Swagger
├── Models/              # Modelos de dados (DTOs, Entidades)
├── appsettings.json     # Configurações
├── Program.cs           # Configuração do Swagger
└── README.md            # Este arquivo
```

## 📝 Licença
Este projeto é para fins educacionais e não possui licença específica. Desenvolvido para a Pós-Graduação em Arquitetura de Software Distribuído da PUC Minas (2025).
