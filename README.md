# ImoveisWebApp

Projeto produzido para o teste técnico do processo seletivo da Netimóveis.

Consiste em uma aplicação MVC que simula o cadastro de imóveis em um sistema (CRUD), consumindo uma API externa utilizando a biblioteca [RestEase](https://github.com/canton7/RestEase). Desenvolvido utilizando ASP.NET 6, em linguagem C#.

Foi criada uma API utilizando o [mockapi.io](https://mockapi.io) para uso neste projeto.

Para compilar a aplicação:

- Utilizando o Visual Studio:

 1. Baixe o [instalador](https://visualstudio.microsoft.com/pt-br/vs/community/) do Visual Studio 2022 e execute;
 2. Instale a carga de trabalho "ASP.NET e desenvolvimento Web"
 3. Execute o Visual Studio e clone o repositório do projeto
 4. Abra a solução ImoveisWebApp.sln com o Visual Studio;
 5. Selecione a configuração Release;
 6. Pressione Ctrl+Shift+B para compilar o projeto;
 7. Pressione Ctrl+F5 para executar a aplicação.

- Utilizando o .NET SDK:

1. Baixe o [.NET 6 SDK x64](https://dotnet.microsoft.com/en-us/download);
3. Clone o repositório do projeto;
4. Abra um prompt de comando na pasta onde está localizado o projeto ImoveisWebApp.csproj;
5. Execute o comando `dotnet run -c Release` para compilar e executar o projeto;
