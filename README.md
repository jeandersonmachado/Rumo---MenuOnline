# Menu Online

O Menu Online é um projeto de um menu virtual, onde os clientes chegam no restaurante e podem acessar o menu que qualquer plataforma, bastando somente digitar o nome e a mesa em que está para ter acesso ao cadápio.<br>
 Ao fazer o pedido, imediatamente é informado sobre o valor total do pedido e o tempo de preparo, o pedido é encaminhado para a cozinha se for um prato e para copa se for uma bebida.

## Começando

Essas instruções fornecerão uma cópia do projeto em funcionamento na sua máquina local para fins de desenvolvimento e teste.

### Pré-requisitos

Lista de softwares que você precisa para instalar e rodar o projeto:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Git](https://git-scm.com/)
- [Sql Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Instalação

Para usar o programa será necessário baixar as dependências:

Microsoft.EntityFrameworkCore.Design(6.0.0)<br>
Microsoft.EntityFrameworkCore.SqlServer(6.0.0)<br>
Microsoft.EntityFrameworkCore.Tools(6.0.0)

Será necessário mudar a string de conexão com o banco de dados para sua máquina local<br>
Data Source=nome_server\\sqlexpress;Initial Catalog=Database;Integrated Security=True

Clone o repositório:

   ```bash
   git clone git@github.com:jeandersonmachado/Rumo---MenuOnline.git
