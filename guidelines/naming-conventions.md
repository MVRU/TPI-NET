# Directrices de Nombres del Proyecto

Este documento establece las directrices de nombres para garantizar consistencia y claridad en el código y la estructura de archivos del proyecto.

## Estructura General

- **Archivos y Carpetas**:
  - Usa **camelCase** para nombres de archivos y carpetas que no son clases.
  - Usa **PascalCase** para nombres de clases y carpetas que contienen clases.
  - Usa **kebab-case** para archivos de documentación y configuraciones (ej. `readme.md`, `app-settings.json`).

## Nomenclatura en Visual Studio

### Archivos de Clases (`.cs`)

- Usa **PascalCase**.
- Ejemplos: `StudentController.cs`, `UserService.cs`.

### Formularios (`.cs`, `.designer.cs`, `.resx`)

- Usa **PascalCase**.
- Ejemplo: `MainForm.cs`.
- Archivos complementarios deben compartir el mismo nombre base: `LogInForm.designer.cs`.

### Archivos de Configuración y Scripts

- Usa **kebab-case**.
- Ejemplos: `app-settings.json`, `deploy-script.sh`.

## Nombres de Carpetas

- **Generales**: Usa **camelCase** (ej. `docs`, `assets`).
- **Clases**: Usa **PascalCase** (ej. `Controllers`, `Models`, `Views`).

## Nombres de Variables y Métodos

- **Variables**: Usa **camelCase**. Ejemplos: `studentName`, `isLoggedIn`.
- **Métodos**: Usa **PascalCase**. Ejemplos: `GetUserDetails()`, `ValidatePassword()`.

## Nombres de Controles de WinForms

- Usa prefijos y **camelCase**. Ejemplos:
  - `txt` para TextBox: `txtUserName`
  - `btn` para Button: `btnSubmit`

## Ejemplo de Estructura del Proyecto

```plaintext
TPI-NET/
├── readme.md
├── naming-conventions.md
├── src/
│   ├── tpiNet.sln
│   ├── tpiNet/
│       ├── tpiNet.csproj
│       ├── Controllers/
│       │   ├── StudentController.cs
│       │   ├── UserController.cs
│       ├── Models/
│       │   ├── Student.cs
│       │   ├── Enrollment.cs
│       ├── Views/
│       │   ├── MainForm.cs
│       │   ├── LogInForm.cs
│       ├── Services/
│       │   ├── AuthenticationService.cs
│       ├── Utilities/
│       │   ├── DateHelper.cs
│       ├── DataAccess/
│       │   ├── DatabaseContext.cs
├── assets/
│   ├── logo.png
├── config/
│   ├── app-settings.json
├── scripts/
│   ├── deploy-script.sh
```


## Convenciones en Base de Datos

- Usa **snake_case** para nombres de tablas y columnas. Ejemplo: `student_record`.
- Prefiere nombres de tablas en singular. Ejemplo: `student`.

## Nombres de Commits y Versionado

- **Etiquetas de Commits**:
  - Usa etiquetas claras: `[feature-implemented]`, `[bug-fix]`, `[pending-review]`.

- **Versiones (SemVer)**:
  - Usa el formato **X.Y.Z**:
    - **X (mayor)**: Cambios incompatibles. Ej. `1.0.0` a `2.0.0`.
    - **Y (menor)**: Nuevas funcionalidades compatibles. Ej. `1.0.0` a `1.1.0`.
    - **Z (parche)**: Correcciones compatibles. Ej. `1.0.0` a `1.0.1`.

### Ejemplos de Versiones

- `1.0.0`: Primera versión estable.
- `1.1.0`: Nuevas funcionalidades.
- `1.1.1`: Correcciones en `1.1.0`.
- `2.0.0`: Cambios importantes.

## Notas Finales

Estas convenciones mejoran la colaboración y el mantenimiento a largo plazo, facilitando la búsqueda de archivos y componentes.