# Documentação de APIs ASP.NET com Swagger

Este repositório contém exemplos de código para documentar APIs ASP.NET usando o Swagger, abordando desde a configuração inicial até a personalização de documentação e autenticação com JWT.

## Visão Geral

Swagger é uma ferramenta poderosa que automatiza a criação de documentação para APIs REST, tornando o desenvolvimento mais ágil e facilitando a integração com outras aplicações. Este repositório fornece exemplos de código para:

- Configuração inicial do Swagger
- Personalização da documentação
- Uso de comentários XML
- Configuração de segurança com autenticação JWT

## Pré-requisitos

- .NET Core 6 ou superior
- Visual Studio 2022 (ou um editor de sua preferência)
- Pacote [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/)

## Instalação

Clone este repositório e instale os pacotes necessários:

## Estrutura do Projeto

Os exemplos são organizados da seguinte forma:

- **ConfiguracaoSwagger**: Configuração inicial para adicionar Swagger no pipeline da aplicação.
- **CustomizacaoSwagger**: Personalização da documentação utilizando XML e comentários detalhados nos endpoints.
- **AutenticacaoSwagger**: Exemplo de autenticação com JWT, configurando o Swagger para inserir o token diretamente na interface.

## Exemplo de Uso

1. Abra o projeto em seu editor preferido.
2. Execute o projeto usando o comando de inicialização.
3. Acesse `http://localhost:<porta>/swagger` no seu navegador para visualizar a interface Swagger da API.

## Configuração Inicial

Para configurar o Swagger, é necessário instalar o pacote `Swashbuckle.AspNetCore` e inicializar o Swagger adicionando-o ao pipeline de serviços da aplicação. Em seguida, configure o middleware para usar o Swagger no ambiente de desenvolvimento.

## Customização da Documentação

Para enriquecer a documentação, é possível ativar a geração de comentários XML e configurar o Swagger para incluir esses comentários, além de adicionar descrições detalhadas nos métodos e respostas dos endpoints da API.

## Autenticação JWT

Para habilitar autenticação JWT no Swagger, adicione as definições de segurança, permitindo que o usuário insira um token JWT diretamente na interface do Swagger, facilitando a autenticação ao interagir com endpoints protegidos.

