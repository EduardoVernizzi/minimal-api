# Minimal API de Veículos

API minimalista em **.NET 8 Minimal API** para gerenciamento de veículos com autenticação de administradores. Documentação interativa via **Swagger/OpenAPI**.

---

## Tecnologias Utilizadas

- .NET 8 Minimal API  
- Entity Framework Core  
- MySQL  
- Swagger/OpenAPI  
- Dependency Injection  
- DTOs para entrada de dados  

---

## Endpoints

| Método | Rota | Descrição | Request Body | Response |
|--------|------|-----------|--------------|---------|
| GET | `/` | Boas-vindas + link Swagger | – | 200 OK |
| POST | `/administradores/login` | Autentica administrador | `{ "usuario": "...", "senha": "..." }` | 200 OK / 401 Unauthorized |
| POST | `/veiculos` | Cria veículo | `{ "nome": "...", "marca": "...", "ano": 2020 }` | 201 Created |
| GET | `/veiculos?pagina={pagina}` | Lista veículos (opcionalmente paginado) | – | 200 OK |
| GET | `/veiculos/{id}` | Retorna veículo por ID | – | 200 OK / 404 Not Found |
| PUT | `/veiculos/{id}` | Atualiza veículo | `{ "nome": "...", "marca": "...", "ano": 2021 }` | 200 OK / 404 Not Found |
| DELETE | `/veiculos/{id}` | Remove veículo | – | 204 No Content / 404 Not Found |

---
