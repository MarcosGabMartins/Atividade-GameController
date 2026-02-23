# 🎮 GameApplication API

Projeto prático desenvolvido como requisito para a disciplina de Arquitetura de Software e Desenvolvimento (Ciência da Computação - Unimar). 

Esta aplicação é uma Web API desenvolvida em **.NET 9** (C#) que implementa um CRUD completo de jogos utilizando o padrão **Controller**, injeção de dependência e armazenamento em memória.

## 🚀 Tecnologias Utilizadas
* **C#** e **.NET 9**
* **ASP.NET Core Web API**
* **Swagger** (Swashbuckle) para documentação interativa e testes
* Padrão DTO (Data Transfer Object)
* Injeção de Dependência (Services e Interfaces)

## ⚙️ Endpoints (API)
A API expõe os seguintes métodos através da `GameController`:

* `POST /api/game/cadastrar`: Cria um novo jogo.
* `GET /api/game/listar`: Retorna a lista de todos os jogos cadastrados.
* `GET /api/game/buscar/{id}`: Retorna os detalhes de um jogo específico.
* `PUT /api/game/editar`: Atualiza as informações (Nome, Imagem, Descrição) de um jogo existente.
* `DELETE /api/game/remover/{id}`: Remove um jogo da lista.

## 🏃 Como rodar o projeto
1. Clone este repositório.
2. Abra o projeto no **JetBrains Rider** ou Visual Studio.
3. Inicie o servidor clicando no Play.
4. Acesse o navegador no endereço: `http://localhost:5153/swagger` para visualizar a interface interativa e testar os endpoints.

---
Desenvolvido por **Marcos Gabriel de Paula Martins**.
