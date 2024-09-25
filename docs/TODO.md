# To-Do List
## Fase 1: Configuración Inicial y Requisitos
- [x] Definir alcance y objetivos del proyecto
- [x] Configurar repositorio de GitHub
- [x] Instalar bibliotecas .NET necesarias
- [x] Definir esquema de base de datos (Usuarios, Asignaturas, Horarios, etc.)

## Fase 2: Diseño de la Interfaz de Usuario
- [ ] **Diseñar formularios del sistema:**
  - [x] Inicio de sesión (frmLogIn)
  - [x] Registrarse (frmSignIn)
  - [ ] **Panel principal dinámico por roles (frmDashboard):**
    - [ ] Dashboard para profesores
    - [ ] Dashboard para estudiantes
    - [ ] **Dashboard para admins (6 ABMs):**
      1. [ ] CRUD Usuarios (frmManageUsers)
      2. [ ] CRUD Cursos (frmManageCourses)
      3. [ ] CRUD Asignatura (frmManageSubject)
      4. [ ] CRUD Horario (frmManageSchedule)
      5. [ ] CRUD Inscripción (frmManageEnrollment)
      6. [ ] CRUD Asistencia (frmManageAttendance)
  - [ ] Configuración (frmSettings)
  - [ ] Perfil de usuario (frmProfile)
  - [ ] Marcar asistencia por asignatura (frmTakeAttendance)
  - [ ] Inscribirse a curso (frmCourseEnrollment)
  - [ ] ...
- [x] Implementar "Recordarme" en frmLogIn
- [ ] Implementar navegación entre formularios (uso fluido y sin errores entre pantallas)

## Fase 3: Lógica de Negocio
- [ ] Implementar control de acceso por roles (MVC)
- [ ] **Desarrollar marcado de asistencia:**
  - [ ] Validación de entrada
  - [ ] Gestión de ausentes y tardíos
- [ ] **Desarrollar evaluación del rendimiento académico:**
  - [ ] Integrar con asistencia
  - [ ] Implementar cálculo de estado regular/libre

## Fase 4: Integración con la Base de Datos
- [x] Configurar Entity Framework
- [ ] Usar ADO.NET en al menos una operación de acceso a datos (requisito de TPI)
- [ ] Desarrollar al menos una búsqueda con filtro

## Fase 5: Pruebas y Depuración
- [ ] Pruebas unitarias para la lógica de asistencia
- [ ] Desarrollar casos de prueba para los campos de entrada y salida

## Fase 6: Reportes
- [ ] **Desarrollar al menos 2 reportes:**
  - [ ] Asistencia por asignatura
  - [ ] Rendimiento académico por estudiante
- [ ] Crear gráfico para uno de los reportes

## Fase 7: Documentación y Despliegue
- [ ] Escribir manual de usuario
- [ ] Crear guía de instalación
- [ ] Finalizar configuración del proyecto para despliegue

---

## Tareas Adicionales:
- [ ] Revisar métodos CRUD y validar datos (Create/Update)
- [ ] Mejorar responsividad de formularios y añadir mensajes de error
- [ ] Validar entradas en tiempo real (signin y login)
- [ ] Bloquear formulario de login tras 5 intentos fallidos
- [ ] Exportar informes de asistencia a Excel/PDF
