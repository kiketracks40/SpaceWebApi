SpaceWebApi

🚀 SpaceWebApi es una API desarrollada con ASP.NET Core y PostgreSQL que gestiona clientes y pedidos.

📌 Tecnologías utilizadas

ASP.NET Core 7.0

Entity Framework Core

PostgreSQL

Swagger (Swashbuckle)

C#

⚙️ Configuración e Instalación

1️⃣ Clonar el repositorio

  git clone https://github.com/kiketracks40/SpaceWebApi
  cd SpaceWebApi

2️⃣ Configurar la base de datos en appsettings.json

Edita el archivo appsettings.json con los datos de tu conexión a PostgreSQL:

"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5432;Database=PcComputo;Username=postgres;Password=kiketracks1984"
}

3️⃣ Ejecutar las migraciones de Entity Framework

  dotnet ef database update

4️⃣ Ejecutar el proyecto

  dotnet run

La API estará disponible en http://localhost:5095.

📌 Endpoints de la API

🏷️ Clientes

Método

Endpoint

Descripción

GET

/api/Space/GetClientes

Obtiene todos los clientes

GET

/api/Space/GetClientesById/{id}

Obtiene un cliente por ID

POST

/api/Space/SaveOrder

Guarda un nuevo pedido

PUT

/api/Space/UpdateOrder

Actualiza un pedido

DELETE

/api/Space/DeleteOrder/{id}

Elimina un pedido

📌 Para probar la API puedes usar Postman o Swagger en http://localhost:5095/swagger.

🤝 Contribución

Si deseas contribuir:

Haz un fork del repositorio.

Crea una nueva rama (git checkout -b feature/nueva_funcionalidad).

Haz un commit de tus cambios (git commit -m 'Agrega nueva funcionalidad').

Realiza un push (git push origin feature/nueva_funcionalidad).

Abre un pull request.

