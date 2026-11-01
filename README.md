# ChatWeb

# Problema y requerimientos

- Una app que permita que registre un usuario
    - **Solo usuarios que existan y que hayan iniciado sesion deberan ser capaces de usar la aplicacion.**
- Que pueda iniciar sesion.
- Con seguridad de para que pueda usar el api.
- El usuario ha de ser capaz de enviar mensajes privados a otros usuarios que existan en la aplicacion.
    - **En caso de no existir el usuario manejar la excepcion.**
- Los usuarios deberan de ser capaces de poder enviar mensajes a grupos donde hayan sido agregados.
- Los usuarios deberan de ser capaces de crear grupos y agregar a otros usuarios.
- Los usuarios no podran entrar a un grupo x a no ser que un usuario de adentro lo agregue.
    - **Sino manejar la excepcion.**
- Los usuarios podran mandar solicitud para que otro lo agregue y esta le llegara por correo.
    - **Cualquier usuario con permisos lo podra agregar.**
- El sistema debera de tener una jerarquia de grupo, administrador, usuarios normales.
    - **Los administradores seran los unicos que podran agregar a otra persona al grupo.**

# Arquitectura

Para este proyecto se usara veritcal slice.

Vertical Slices

```csharp
src/ChatWeb.Api/
├─ 📁 Features/
│  ├─ 📁 Users/
│  │  ├─ UpsertUserCommand.cs   # command + handler + endpoint PUT
│  │  ├─ LoginUserQuery.cs 
│  │  ├─ RequestPasswordResetCommand.cs
│  │  └─ DeleteUserCommand.cs
│  ├─ 📁 Chat/   
│  │  ├─ SendPrivateMessageCommand.cs   # command + handler + endpoint
│  │  ├─ SendMessageGroupCommand.cs
│  │  ├─ RemoveGroupCommand.cs
│  │  └─ JoinToGroupCommand.cs
│  ├─ 📁 Email/   
│  │  └─ SendEmailCommand.cs   # command + handler
├─ 📁 Shared/   
├─ 📁 Database/
│   ├── AppDbContext.cs
│   └── 📁 Configurations/
├─ 📁 Middleware
└─ Program.cs
 
tests/
├─ Web.Api.UnitTests/
└─ IntegrationTests/   # Testcontainers
```

# Tecnologias

- WolverineFX (endpoint, handlers).
- JWT
- WolverineEF
- EF
- SignalR
- Jaeger
- OpenTelemtry