# Aplicação Biblioteca e Conexões

<h4>Projeto desenvolvido para o Professor Enildo na materia de Programação Web (ETIM Desenvolvimento e Analise de Sistema - ETEC 2021).</h4>


## Aprendizados
- [X] Libarys/DLLs (Bibliotecas)
- [X] Opreações CRUD (Create, Read, Update e Delete)
- [X] Orientação Objeto

# Como Executar:

- 1. Clone esse repositorio
```bash
# 1.Clona o Projeto
git clone https://github.com/GuilhermePalma/app-biblioteca_conexao.git

# 2. Acessa o diretorio do Projeto
cd app-biblioteca_conexao

# 3. Abre o Explorar de Arquivos
explorer .
```

- 2. Executar o arquivo ```database.sql``` no seu SGBD 
- 3. Usuario e Senha utilizados na conexão com o banco são "admin"
- 4. Acessar o arquivo: ```AppADO/DataBase.cs"``` e alterar as Variaveis do Banco de Dados Local
  - 1. Localizar no Arquivo comentario ```"// Alterar nessa Parte com os Dados do SGBD da Maquina"```
  - 2. Inserir o **Nome do Servidor** utilizado: ```string server```
  - 3. Inserir o **Usuario do Servidor** utilizado: ```string user```
  - 4. Inserir a **Senha do Servidor** utilizado: ```string password```
  - 5. Manter a variavel ```string database```
  - 6. O unico SGBD aceitado pelo projeto é o **MySql**
  - 7. Caso tenha um outro **banco com esse mesmo nome**, durante a execução do script sql ele será **apagado**
- 5. Verifique se o arquivo ```packages/MySql.Data.8.0.25``` existe. Caso não exista, busque-o na NuGet Package
