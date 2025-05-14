# Catalog.API - Microsserviço de Catálogo

Este repositório contém o **Catalog.API**, um microsserviço desenvolvido como parte de um sistema maior baseado em arquitetura de microsserviços. Este projeto foi criado para fins de aprendizado e estudo, com o objetivo de explorar conceitos como APIs RESTful, integração com MongoDB e boas práticas de desenvolvimento.

## O que é o Catalog.API?

O **Catalog.API** é responsável por gerenciar os produtos de um catálogo. Ele fornece endpoints para criar, atualizar, deletar e buscar produtos, incluindo a funcionalidade de busca por categoria com suporte a case-insensitive.

### Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção de APIs RESTful.
- **MongoDB**: Banco de dados NoSQL utilizado para armazenar os produtos.
- **Docker**: Para containerização do microsserviço.
- **Docker Compose**: Para orquestração de múltiplos serviços (ex.: API e banco de dados).
- **C#**: Linguagem de programação principal.

## Como Rodar o Projeto

### Pré-requisitos

- **Docker** e **Docker Compose** instalados.
- **.NET SDK** (caso queira rodar localmente sem Docker).

### Passos para Rodar com Docker

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/microservices.git
   cd microservices
   ```

2. Certifique-se de que o Docker está em execução.

3. Suba os containers com o Docker Compose:
   ```bash
   docker-compose up --build
   ```

4. Acesse o serviço na porta `8000`:
   - API: [http://localhost:8000/api/Catalog](http://localhost:8000/api/Catalog)

### Rodando Localmente (Sem Docker)

1. Certifique-se de que o MongoDB está rodando localmente na porta padrão (`27017`).

2. Configure a string de conexão no arquivo `appsettings.json`:
   ```json
   {
     "DatabaseSettings": {
       "ConnectionString": "mongodb://localhost:27017",
       "DatabaseName": "CatalogDb",
       "CollectionName": "Products"
     }
   }
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project Catalog.API
   ```

4. Acesse o serviço na porta configurada (ex.: `http://localhost:8000`).

## Endpoints Disponíveis

### Produtos

- **GET** `/api/Catalog`  
  Retorna todos os produtos.

- **GET** `/api/Catalog/{id}`  
  Retorna um produto pelo ID.

- **GET** `/api/Catalog/GetProductByCategory?category={category}`  
  Retorna produtos por categoria (case-insensitive).

- **POST** `/api/Catalog`  
  Cria um novo produto.

- **PUT** `/api/Catalog`  
  Atualiza um produto existente.

- **DELETE** `/api/Catalog/{id}`  
  Deleta um produto pelo ID.

## Observações

- Este projeto é **apenas uma parte** de um sistema maior baseado em microsserviços.
- Ele foi desenvolvido **exclusivamente para fins de aprendizado e estudo**.
- Não é recomendado para uso em produção sem as devidas adaptações e melhorias.

## Próximos Passos

- Adicionar autenticação e autorização.
- Implementar testes unitários e de integração.
- Integrar com outros microsserviços (ex.: carrinho, pedidos).

## Licença

Este projeto é livre para uso e modificação para fins educacionais.
````