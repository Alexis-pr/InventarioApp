# 📦 InventarioApp

Sistema de gestión de inventario de productos desarrollado con **ASP.NET Core 9** y **PostgreSQL**, construido como proyecto de aprendizaje para entender los fundamentos de ASP.NET, Entity Framework y arquitectura por capas.

---

## 🚀 Tecnologías utilizadas

- [.NET 9](https://dotnet.microsoft.com/) — Framework principal
- [ASP.NET Core Razor Pages](https://docs.microsoft.com/aspnet/core/razor-pages) — Interfaz web
- [Entity Framework Core 9](https://docs.microsoft.com/ef/core/) — ORM para acceso a datos
- [PostgreSQL](https://www.postgresql.org/) — Base de datos relacional
- [Npgsql](https://www.npgsql.org/) — Conector de PostgreSQL para .NET
- [Bootstrap](https://getbootstrap.com/) — Estilos y componentes UI

---

## 📁 Estructura del proyecto

```
InventarioApp/
├── Data/
│   └── AppDbContext.cs          # Contexto de base de datos (EF Core)
├── Interfaces/
│   └── IProductoService.cs      # Contrato del servicio de productos
├── Models/
│   └── Producto.cs              # Modelo con validaciones
├── Pages/
│   ├── Index.cshtml             # Lista de productos
│   ├── Agregar.cshtml           # Formulario de agregar
│   ├── Editar.cshtml            # Formulario de editar
│   ├── Eliminar.cshtml          # Eliminar producto
│   └── Shared/
│       └── _Layout.cshtml       # Plantilla base
├── Services/
│   ├── ProductoService.cs       # Servicio en memoria (desarrollo)
│   └── ProductoServiceDb.cs     # Servicio con PostgreSQL (producción)
├── wwwroot/
│   └── js/
│       └── inventario.js        # Búsqueda en tiempo real
├── appsettings.json             # Configuración y cadena de conexión
└── Program.cs                   # Configuración de la aplicación
```

---

## ✨ Funcionalidades

- ✅ Listar productos con valor total del inventario
- ✅ Agregar productos con validaciones
- ✅ Editar productos existentes
- ✅ Eliminar productos
- ✅ Buscador en tiempo real (JavaScript)
- ✅ Cálculo automático del valor total por producto
- ✅ Persistencia de datos con PostgreSQL

---

## ⚙️ Requisitos previos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [PostgreSQL 18](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/)

---

## 🛠️ Instalación y configuración

### 1. Clona el repositorio

```bash
git clone https://github.com/TuUsuario/InventarioApp.git
cd InventarioApp
```

### 2. Configura la base de datos

Crea la base de datos en PostgreSQL:

```sql
CREATE DATABASE inventariodb;
```

### 3. Configura la cadena de conexión

Edita `appsettings.json` con tus credenciales:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=inventariodb;Username=postgres;Password=tu_contraseña"
  }
}
```

### 4. Aplica las migraciones

```bash
dotnet ef database update
```

### 5. Ejecuta el proyecto

```bash
dotnet watch
```

Abre el navegador en `http://localhost:5000` 🎉

---

## 🗄️ Migraciones

Crear una nueva migración después de cambiar el modelo:

```bash
dotnet ef migrations add NombreDeLaMigracion
dotnet ef database update
```

---

## 📐 Arquitectura

Este proyecto sigue una arquitectura por capas:

```
Páginas Razor (UI)
      ↓
Interfaces (Contratos)
      ↓
Servicios (Lógica de negocio)
      ↓
DbContext (Acceso a datos)
      ↓
PostgreSQL (Base de datos)
```

El uso de interfaces permite cambiar la implementación del servicio sin modificar las páginas — por ejemplo, cambiar de base de datos o usar un servicio en memoria para pruebas.

---

## 👨‍💻 Autor

Desarrollado como proyecto de aprendizaje de ASP.NET Core.
