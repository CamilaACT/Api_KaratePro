# API KaratePro

**API KaratePro** es una aplicación backend desarrollada con .NET 8, que proporciona funcionalidades para gestionar competencias de karate. La API permite la gestión de usuarios, peleas, rivales, técnicas y puntuaciones en un entorno seguro y eficiente.

## Características

- Autenticación y autorización mediante JWT.
- Gestión de competidores, rivales y peleas.
- Registro y consulta de técnicas y puntuaciones.
- Implementación de CORS para permitir solicitudes desde diferentes orígenes.
- Respuesta estructurada con manejo de errores.

## Tecnologías utilizadas

- **.NET 8**: Framework principal para la construcción de la API.
- **SQL Server**: Base de datos utilizada para el almacenamiento de la información.
- **Entity Framework Core**: ORM para facilitar la comunicación con la base de datos.
- **JWT (JSON Web Token)**: Seguridad y autenticación.
- **CORS**: Configuración para solicitudes desde diferentes orígenes.

## Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/CamilaACT/Api_KaratePro.git
   cd Api_KaratePro
2. **Clonar el repositorio**:
   Configurar la base de datos: Configura la cadena de conexión en appsettings.json para que coincida con tu entorno de SQL Server.
