# 🤖 Guía de Código para .NET Core

## Objetivo
Establecer directrices para la escritura y organización del código en la aplicación de escritorio, promoviendo la legibilidad, mantenibilidad y eficiencia.

## Estructura del Proyecto
- **Organización de Archivos**: agrupar archivos relacionados en carpetas (ej. `Models`, `Views`, `Controllers`, `Services`, `Resources`).

## Convenciones de Nomenclatura
- **Clases**: usar PascalCase (ej. `User`, `StudentManager`).
- **Métodos**: usar PascalCase y un verbo que indique la acción (ej. `GetUser`, `SaveData`).
- **Variables y Parámetros**: usar camelCase (ej. `userName`, `studentList`).
- **Constantes**: usar UPPER_SNAKE_CASE (ej. `MAX_ATTEMPTS`, `DEFAULT_COLOR`).

## Estructura de Clases
- **Encapsulamiento**: usar modificadores de acceso para proteger los datos (ej. `private`, `public`, `protected`).
- **Propiedades**: usar propiedades automáticas y notación de PascalCase (ej. `public string UserName { get; set; }`).
- **Constructores**: definir constructores claros y específicos. Evitar sobrecargar demasiado.
- **Métodos**:
  - Mantener métodos cortos y específicos.
  - Evitar duplicación de código; usar métodos auxiliares si es necesario.
  - Usar comentarios solo para explicar lógica compleja, no para describir lo obvio.

## Manejo de Errores
- **Excepciones**: usar `try-catch` para manejar excepciones, proporcionando mensajes claros y específicos.
- **Logs**: implementar un sistema de logging para registrar errores y eventos importantes.

## Buenas Prácticas de Programación
- **Comentarios**: evitar comentarios innecesarios; el código debe ser lo suficientemente claro por sí mismo.
- **Separación de Responsabilidades**: aplicar el principio de responsabilidad única; cada clase o método debe tener una única responsabilidad.
- **Diseño Orientado a Objetos**:
  - Usar herencia y polimorfismo donde sea necesario.
  - Evitar la herencia múltiple; utilizar interfaces para definir contratos.
- **Principio DRY (Don't Repeat Yourself)**: evitar la duplicación de código utilizando métodos, clases o componentes reutilizables.

## Uso de Bibliotecas y Frameworks
- **Inyección de Dependencias**: implementar la inyección de dependencias para gestionar las instancias de las clases y mejorar la testabilidad.
- **Uso de Linq**: utilizar LINQ para consultas y manipulación de colecciones de manera legible.

## Documentación
- **XML Documentation**: usar documentación XML para describir clases y métodos, lo que permite generar documentación automática.

## Control de Versiones
- **Commits**: hacer commits claros y descriptivos. Usar un formato estándar, comenzando con un verbo en infinitivo como `Agregar`, `Corregir` o `Eliminar` (ej. `Agregar funcionalidad de registrar nuevo usuario`).
  - Opcionalmente, se pueden agregar descripciones más extensas detallando los cambios que introduce el commit.
- **Branches**: usar ramas para nuevas características, correcciones de errores, mejora en la documentación, etc.:
  - **Nuevas Funcionalidades:** `feature/nueva-funcionalidad`.
  - **Corrección de Errores:** `bugfix/error-importante`.
  - **Documentación:** `docs/nueva-documentacion`.
  - **Mejoras o Refactorizaciones:** `enhancement/mejorar-codigo`.
  - **Cambios en el Diseño o la UI:** `design/actualizar-estilos`.
  - **Actualizaciones de la Base de Datos:** `db/agregar-nueva-tabla`.
- **Pull Requests**: incluir descripciones claras en las pull requests y realizar revisiones de código.

## Notas Finales
Esta guía está diseñada para garantizar la escritura de código limpio y mantenible, asegurando que todos sigan un conjunto coherente de principios y directrices en el desarrollo de la aplicación.