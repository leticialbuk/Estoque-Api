#  Documentação do Projeto - Sistema de Estoque

##  Descrição Geral

Este projeto consiste na criação de um sistema de estoque com **backend em ASP.NET Core com Entity Framework** e **frontend em Angular**. O objetivo é exibir dados da tabela **Produtos** do banco de dados SQL Server em uma aplicação web.

---

## 🗃️ Banco de Dados

No **SQL Server**, foi criado um banco de dados chamado `Estoque`, contendo a tabela `Produtos`, estruturada da seguinte forma:

| Campo      | Tipo                | Descrição                                         |
|------------|---------------------|---------------------------------------------------|
| `Id`       | `INT`, PRIMARY KEY, IDENTITY(1,1) | Identificador único do produto, gerado automaticamente |
| `Nome`     | `NVARCHAR(100)`     | Nome do produto                                   |
| `Preço`    | `DECIMAL(18, 2)`    | Preço unitário do produto                         |
| `Quantidade` | `INT`             | Quantidade disponível em estoque                  |

---

## 💻 Backend

API desenvolvida utilizando **C#** e **Entity Framework Core** para acesso à base de dados **SQL Server**.

###  Tecnologias

- ASP.NET Core  
- Entity Framework Core

###  Estrutura

- **Modelo Produto**  
  Representa a tabela `Produtos` com os campos: `Id`, `Nome`, `Preço`, e `Quantidade`.

- **DataContext**  
  Responsável pela conexão com o banco e mapeamento da entidade.

###  Endpoint

- `GET /api/produtos` – Retorna todos os produtos cadastrados.

###  CORS

- Ativado para permitir requisições do frontend Angular.

###  Documentação de Código

- Utilização de `<summary>` e comentários de linha para explicar métodos e classes.

---

## 💻 Frontend

###  Tecnologia

- Angular

###  Componente

- `lista-produtos`  
  Componente responsável por consumir os dados da API e exibir a lista de produtos em uma tabela na página web.

###  Destaques da Implementação

- Uso de `HttpClientModule` para realizar requisição `GET`
- Criação de `interface Produto` para tipagem e organização dos dados

---

