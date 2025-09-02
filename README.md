
# ToysCompany

API REST para cadastro e gerenciamento de brinquedos.

## Funcionalidades
- Cadastro, edição, listagem e remoção de brinquedos
- Estrutura organizada em Controllers, Models, DTO, Services e Context
- Persistência de dados com Entity Framework Core

## Como rodar
1. Instale dependências: `dotnet restore`
2. Execute: `dotnet run`
3. Configure o banco em `appsettings.json`

## Estrutura de Pastas
```
ToysCompany/
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
├── ToysCompany.csproj
├── ToysCompany.csproj.user
├── ToysCompany.http
├── Context/
│   └── BrinquedoDbContext.cs
├── Controllers/
│   └── BrinquedoController.cs
├── DTO/
│   └── BrinquedoDTO.cs
├── Migrations/
│   ├── 20250828190638_InitialCreate.cs
│   ├── 20250828190638_InitialCreate.Designer.cs
│   └── BrinquedoDbContextModelSnapshot.cs
├── Models/
│   └── Brinquedo.cs
├── Properties/
│   └── launchSettings.json
├── Services/
│   └── BrinquedoService.cs
```


## Endpoints principais

- **GET /api/Brinquedo**: Lista todos os brinquedos
- **GET /api/Brinquedo/{id}**: Busca brinquedo por ID
- **POST /api/Brinquedo**: Cadastra novo brinquedo
- **PUT /api/Brinquedo/{id}**: Edita brinquedo existente
- **DELETE /api/Brinquedo/{id}**: Remove brinquedo

## Exemplo de JSON para cadastro (POST /api/Brinquedo)
```json
{
  "nome": "Carrinho",
  "tipo": "Veículo",
  "classificacao": 14,
  "tamanho": 25.5,
  "preco": 99.9
}
```

## Exemplo de resposta de listagem (GET /api/Brinquedo)
```json
[
  {
    "id": 3,
    "nome": "Hot Wheels",
    "tipo": "Carrinho de Brinquedo",
    "classificacao": 14,
    "tamanho": 5,
    "preco": 59.9
  },
  {
    "id": 22,
    "nome": "Relampago marquinhos",
    "tipo": "Carro",
    "classificacao": 14,
    "tamanho": 10,
    "preco": 65.5
  }
]
```

## Exemplo de requisição de edição (PUT /api/Brinquedo/3)
```json
{
  "nome": "Boneca",
  "tipo": "Boneca",
  "classificacao": 14,
  "tamanho": 30.0,
  "preco": 120.00
}
```

## Exemplo de requisição de remoção (DELETE /api/Brinquedo/3)
Sem corpo. Apenas envie o método DELETE para o endpoint com o ID desejado.




