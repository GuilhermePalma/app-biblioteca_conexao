Guilherme Peres Lins da Palma, 22/06/2021
https://github.com/GuilhermePalma/app-biblioteca_conexao

Observação: Esse arquivo está melhor formatado no arquivo 'README.md'. Esse arquivo ('.txt') só foi criado para facilitar a execução desse projeto sem que abra o outro arquivo. Dessa forma, para uma melhor leitura é recomendado que siga a leitura pelo arquivo "README.md"

# Aplicação Biblioteca e Conexões
Projeto desenvolvido para o Professor Enildo na materia de Programação Web (ETIM Desenvolvimento e Analise de Sistema - ETEC 2021).

Foi utilizado os conceitos de Libarys (Biblioteas), operações (CRUD) com MySql e Orientação Objeto.

# Como Executar:

- Executar o arquivo "database.sql" no seu SGBD

- Tipo do Servidor SQL Usado = "MySql"
  - ATENÇÃO: Esse projeto não funciona em servidores que não sejam MySql.

- Usuario e Senha utilizados na conexão com o banco são "admin"
- Nome do Banco: system_users
  - ATENÇÃO: Caso tenha um outro banco com esse mesmo nome, durante a execução do script sql ele será apagado
  - ATENÇÃO: Caso no seu Banco de Dados não tenha um Usuario com o passos abaixo:
    - Dentro desta Pasta, navegue: AppADO/DataBase.cs
    - Na parte indicada com o comentario "// Alterar nessa Parte com os Dados do SGBD da Maquina", coloque nas respectivas variaveis: 
    - Nome do servidor (variavel: server)
    - Login no Servidor (variavel: user)
    - Senha no Servidor (variavel: password)

- ATENÇÃO: Caso depois de ter realizado os passos acima apareça erro na execução da Aplicação:
  - Baixe a versão mais atual desse projeto no meu GitHub 
  - Verifique se o caminho "packages/MySql.Data.8.0.25" existe
  - ATENÇÃO: Essa pasta é FUNDAMENTAL para que a aplicação se comunique com o Banco de Dados