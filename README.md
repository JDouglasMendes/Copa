# Copa

Implementação do desafio Copa de Equipes.

![GitHub](https://img.shields.io/github/license/JDouglasMendes/Copa)
![GitHub language count](https://img.shields.io/github/languages/count/JdouglasMendes/Copa)
![GitHub top language](https://img.shields.io/github/languages/top/Jdouglasmendes/Copa)
![GitHub repo size](https://img.shields.io/github/repo-size/jdouglasmendes/Copa)
![GitHub last commit](https://img.shields.io/github/last-commit/jdouglasmendes/Copa)
![Azure DevOps tests (compact)](https://img.shields.io/azure-devops/tests/douglasaleixomendes/copa/2)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/douglasaleixomendes/Copa/2)

### Sobre a Cobertura dos testes
* Aparentemente o coverlet no Azure DevOps não detecta que alguns métodos que foi implementado utilizando _body expression_ do C# teve o teste. 
* Para verificar a cobertura de testes detalhada executar o comando abaixo:
* `dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit*]\*" /p:CoverletOutput="./TestResults/"`

### Frameworks e linguagens utilizadas na implementação da aplicação
C# | Typescript | Asp Net Core 3.1 | Angular 10 | XUnit | RestSharp | AutoMapper

### Ferramentas recomendadas para executar a aplicação
Visual Code - Front End | Visual Studio - Back End

### Passos necessários para executar a aplicação
* Clonar o projeto ou baixar do github.
* Para executar o Front End
  * Entrar na pasta desafio-a-copa
  * Executar o comando `npm install`, aguarde a finalização.
  * Executar o comando `ng serve`, aguarde a finalização.
  * Acessar o browser no endereço __localhost:4200__
* Para executar o Back End
  * Entrar na pasta desafio-a-copa-server
  * Se utilizar _Visual Studio_ compilar o projeto e executar preferencialmente pela opção _Copa.Web.API_
  * Se utilizar _Visual Studio Code_
    * Abrir a pasta _Copa_
    * Executar o comando `dotnet restore`
    * Entrar na pasta _Copa.Web.API_
    * Executar o comando `dotnet rum`
    * Acessar o browser no endereço _http://localhost:5000/swagger_ (Caso queira confirmar que está em execução)
  
### Passos necessários para executar os testes unitários
* Esse projeto tem configurado o _CI_ para obter a porcentagem de cobertura e a quantidade de testes a cada commit.
* Existe dois projetos de testes, a saber:
  * __Copa.Domain.Test:__ para testes regra de negocio.
  * __Copa.Web.API.Integration.Test:__ para testes de integração considerando desde o controller até a conclusão do request.
* Para executar com _Visual Studio_ compilar a aplicação, escolha uma das formas abaixo para executar:
  * Atalho: __CRTL+R,A__
  * Menu->Test->Run All Tests
* Para executar com _Visual Studio Code_ compilar a aplicação, execute o passo abaixo:  
  * Executar o comando `dotnet test Copa.sln` dentro da basta _Copa_
  
  
  

