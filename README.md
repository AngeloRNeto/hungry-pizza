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

## Arquitetura

<p align="justify">
  Foi implementado o modelo de arquitetura hexagonal, aonde é separado os adaptadores por driven (acesso externo para a API) e driving (acesso da API para o externo). 
  Além do Core da aplicação com os modelos e a Application responsável pela regra de negócio. Tal modelo facilita a escalabilidade do projeto e o acoplamento de novas features;
  (ex: filas(consumer/producer), novo database, nova consulta api externa).
</p>

<img src="https://miro.medium.com/v2/resize:fit:1400/format:webp/1*vz61CjLHGfiZ-P0IGXD9zg.png">


## Pré-requisitos

 [.Net 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0) 
 [Nuget](https://www.nuget.org)

## Como executar o projeto

```Bash

git clone https://github.com/AngeloRNeto/JuntosSomosMais.CodeChallenge.git

cd JuntosSomosMais.CodeChallenge
nuget install # Baixe as dependencias
dotnet test # Realiza os testes unitários 
dotnet run # Executa a aplicação

```
 
