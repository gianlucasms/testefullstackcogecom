# Teste de Desenvolvimento FullStack

A fim de validar as skills tecnicas do candidato, segue uma proposta de avaliação técnica utilizando as skills usadas diariamente na cogecom.

Tecnologias abordadas neste teste:

![N|Solid](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![N|Solid](https://img.shields.io/badge/Node.js-43853D?style=for-the-badge&logo=node.js&logoColor=white) ![N|Solid](https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white)

O Teste consiste em criar uma API de cadastro de **Cooperado**, **Unidade consumidora** e seus **Endereços** e consumir o serviço usando uma aplicação SPA em Angular.

Segue abaixo o diagrama de entidade relacionamento da aplicação:

![N|Solid](https://cogecomboble.blob.core.windows.net/templates/diagrama_teste.jpg)

### Regras de relacionamento:
- Um cooperado pode conter 0 ou muitas unidades consumidoras cadastradas
- Uma unidade consumidora pode conter 1 e no máximo 1 endereço cadastrado

## Features

- A aplicação deve conter o CRUD (Create, Read, Update e Delete de TODAS as entidades)
- Ao cadastrar um novo cooperado o usuário **PODE OU NÃO** cadastrar uma unidade consumidora
- Para completar o endereço o sistema deve utilizar a API do **Viacep** (https://viacep.com.br)
- Utilizar banco de dados **SQL SERVER** (utilizar versão 2016 ou superior)
- Utilizar .net Core 7+


### Diferenciais
 - Conteinerização da aplicação
 - EF Core Fluent API 
 - Conhecimentos em Azure com WebDeploy
 

### Entrega
Para a resolução fazer um fork desse projeto em um novo repositório e enviar para o email: marcelo.mello@cogecom.com.br e no assunto : **Vaga desenvolvedor FullStack**
