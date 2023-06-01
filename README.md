# WebAPIFluxocaixa
Tecnogias usadas:
Para desenvolvimento da solução, foram usadas as tecnologias: IDE Microsoft Visual Studio 2022, .NET Core 6.0 para desenvolvimento da API de CRUD e listagem de lançamentos com o Framework (ORM) NHibernate 5.3.13. Usei essas tecnologias por serem tecnólogias que estavam mais ao meu alcance e domínio.

Passo a passo para execução:
Conectar em um banco Microsoft SQL Server e rodar a script "CreateDatabase.sql". Com isso será criado o banco, a tabela e incluídos alguns registros de exemplo.
Abrir a solução WebAPIFluxoCaixa-Mai-23 com o Visual Studio 2022, Abrir o arquivo "SessionFactory.cs" na pasta Repository e alterar a variável connectionString na linha 12 de acordo com os dados do seu servidor sql. Após feita esta alteração, rodar a aplicação pelo próprio visual stúdio e será aberto o browser com o swagger mostrando todos os endpoints da api.
Pode ser testado cada endpoint de acordo com ao documentação do swagger.
Além do swagger a API pode ser comsunida também, com o Postman. Para este fim geramos um arquivo "FluxoCaixa.postman_collection.json", que pode ser importado por este aplicativo e testado.

Resumo:
A proposta da solução, é uma API que contém um CRUD e listagems dos lançamentos de um fluxo de caixa.
A mesma conta com endpoint´s para Incluir, Alterar, Consultar e Excluir Lançamentos de Entrada e Saída. Também conta com um endpoint para Consultar os lançamentos consolidados por data e tipo de lançamento.
Para desenvolvimento da solução usamos o .NET e um framework OMR para persistência de dados em banco de dados SQL SERVER.
