

```shell
# Exemplo para geração de contexto com models "Database First"
dotnet ef dbcontext scaffold "server=localhost;database=entity_mvc_anima;user=root;password=root" Pomelo.EntityFrameworkCore.MySql --force --no-pluralize --context UlifeDbContext --context-dir Database --output-dir Database/Entities
```


```shell
dotnet ef migrations add TabelasDoSistema
dotnet ef database update
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.5
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.5
dotnet build
dotnet aspnet-codegenerator controller -name ClientesController -m Cliente -dc BancoDeDadosContexto --relativeFolderPath Controllers --useDefaultLayout
dotnet aspnet-codegenerator controller -name FornecedoresController -m Fornecedor -dc BancoDeDadosContexto --relativeFolderPath Controllers --useDefaultLayout
dotnet aspnet-codegenerator controller -name PedidosController -m Pedido -dc BancoDeDadosContexto --relativeFolderPath Controllers --useDefaultLayout
dotnet aspnet-codegenerator controller -name ProdutosController -m Produto -dc BancoDeDadosContexto --relativeFolderPath Controllers --useDefaultLayout
dotnet aspnet-codegenerator controller -name PedidosProdutosController -m PedidoProduto -dc BancoDeDadosContexto --relativeFolderPath Controllers --useDefaultLayout
```