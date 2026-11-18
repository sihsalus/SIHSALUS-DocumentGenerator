# SIHSALUS-DocumentGenerator

## Almacenamiento del payload del FUA

`POST /api/mapping/execute` recibe el JSON de la visita. Cuando el mapeador genera el HTML, la API cifra el JSON con AES-256-GCM y lo guarda en PostgreSQL en `GeneratedFuaPayloads` antes de devolver `text/html`. Si falla la generación o la escritura, la API devuelve un error.

Configura las variables de `.env.example` en el entorno de la API o en un archivo local `.env`. `ENCRYPTION_KEY` debe contener 32 bytes aleatorios codificados en Base64. Puedes generar una clave con PowerShell:

```powershell
[Convert]::ToBase64String([System.Security.Cryptography.RandomNumberGenerator]::GetBytes(32))
```

Conserva la clave fuera del repositorio y de PostgreSQL. Los registros existentes requieren la clave con la que se cifraron para poder recuperarse.

Con la conexión a la base de datos configurada, aplica la migración antes de usar el endpoint. Para una base local, desde la raíz del proyecto:

```sh
dotnet ef database update
```

En despliegues que aplican migraciones mediante SQL, genera el script con `dotnet ef migrations script --idempotent`.
