<h1 align="center">HungryPizza API</h1> 

<p align="center">
  <img src="https://img.shields.io/badge/6.0.0-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
  <img src="https://img.shields.io/static/v1?label=C%20Sharp&message=10.0.0&color=blue&style=for-the-badge&logo=c-sharp"/>
  <img src="https://img.shields.io/static/v1?label=nuget&message=Dependencies&color=blue&style=for-the-badge&logo=NUGET"/>
<br>
  <img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white" />
</p>

## Sobre o projeto 

<p align="justify">
  Este projeto se propõe a realizar o gerenciamento de pedidos da pizzaria Hungry. Escrito em C# para fins de estudo;
</p>

## Funcionalidades

<p align="justify">
o sistema visa otimizar e automatizar o processo de recebimento, processamento e acompanhamento de pedidos, proporcionando uma experiência mais eficiente tanto para os funcionários quanto para os clientes.
</p>


## Tecnologias
<p align="justify">
  Foi utilizado o entity framework como ORM com a solução em memória, Flur.HTTP para facilitar as requisições aos links que foram passados, além do Mock para os testes unitários;
</p>

## Observações

<p align="justify">
  Para o projeto, foi utilizado o banco de dados PostgreSQL, pois ele é adequado para um projeto que não terá um volume massivo de dados. Além disso, a maioria das plataformas em nuvem oferece suporte ao PostgreSQL, e a ferramenta possui uma grande comunidade devido ao seu caráter open-source.

Decidi modelar as tabelas de pedidos e opções_pizza separadamente para permitir o cadastro individual e a relação entre elas através de uma terceira tabela chamada pedido_opcoes_pizza. Também criei uma tabela adicional para armazenar os endereços associados aos pedidos.

Foi utilizado o Entity Framework como ORM para facilitar as operações com o banco de dados, FluentValidation para validar as regras de cadastro dos itens necessários, Swagger para documentação.

Pontos de Melhoria:
Adicionar ingredientes no cadastro de opções de pizza.
Validar o status do pedido, impedindo, por exemplo, que um pedido com status "Em entrega" volte para "Registrado".
Implementar filtro e paginação na listagem das opções de pizza.
Adicionar autenticação.
Gerenciar transações com begin transaction para garantir maior consistência dos dados.

</p>

## Pré-requisitos

 [.Net 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0) 
 [Nuget](https://www.nuget.org)

## Como executar o projeto

```Bash

git clone https://github.com/AngeloRNeto/hungry-pizza.git

cd hungry-pizza
cd src
nuget install # Baixe as dependencias
dotnet run # Executa a aplicação

```
 
