# 🎨 Guía de Diseño para WinForms

## Objetivo
Establecer directrices para el diseño de la interfaz gráfica, asegurando consistencia, claridad y facilidad de uso.

## Estructura General de la Interfaz
- **Layout**: utiliza `TableLayoutPanel` o `FlowLayoutPanel` para organizar controles.
- **Espaciado**: mantén un espaciado uniforme entre controles.
- **Colores y Temas**: utiliza una paleta de 3-5 colores coherente que respete el branding.

## Controles Comunes y Atributos

### General
- **Name**: usa prefijos y camelCase (ej. `btnEnviar`, `txtContraseña`).
- **Font**: `Microsoft Sans Serif`, `12pt` (en su defecto, `10pt`).
- **Colores**:
  - Títulos: `#0d171c`
  - Descripciones: `#4f7a94`
  - Botón Principal: `#3ba1e3`
  - Botón Secundario: `#e8edf2`
  - Campos: `#e8edf2`
  - Fondo: `#f7fafa`

### 0. Form
- **Name:** `DescripcionForm` (ej. `MainForm`)
- **Backcolor:** `#f7fafa`.
- **Font:** `Microsoft Sans Serif, 10pt`.
- **ForeColor:** `#0d171c`.
- **ShowIcon:** `false`.
- **StartPosition:** `CenterScreen`.
-  **WindowState:** `Maximized`.

### 1. Button
- **Name**: `btnAccion` (ej. `btnEnviar`, `btnCancelar`)
- **Text**: Acción clara (ej. "Enviar").
- **Font**: `12pt`, estilo `Bold` para acciones importantes.
- **Size**: altura `30px`, ancho mínimo `80px`.
- **Dock**: `DockStyle.Top` o `DockStyle.Left`.
- **FlatStyle:** `Flat`.
- **ForeColor**: `#3ba1e3` o `#e8edf2`.

### 2. Label
- **Name**: `lblDescripción` (ej. `lblError`)
- **Text**: breve y claro; usa colores de advertencia si es necesario.
- **Font**: `12pt` (o más para títulos).
- **Size**: ajustar automáticamente, mínimo `50px`.
- **Dock**: `DockStyle.Top` para encabezados.
- **ForeColor**: `#0d171c` o `#4f7a94`.

### 3. TextBox
- **Name**: `txtCampo` (ej. `txtUsuario`, `txtContraseña`)
- **Font**: `12pt`.
- **Size**: mínimo `150px` ancho, `25px` alto.
- **Dock**: `DockStyle.Fill`.
- **PasswordChar**: `PasswordChar = '●'` para contraseñas.
- **Multiline**: establecer `true` si es necesario.

### 4. ComboBox
- **Name**: `cmbOpcion` (ej. `cmbCurso`)
- **Font**: `12pt`.
- **Size**: mínimo `150px` ancho, `25px` alto.
- **DropDownStyle**: `DropDown` para entrada personalizada.
- **Items**: agregar elementos relevantes.

### 5. DataGridView
- **Name**: `dgvTabla` (ej. `dgvEstudiantes`)
- **Font**: `12pt`.
- **Size**: mínimo `300px` de ancho y alto.
- **AutoSizeColumnsMode**: `DataGridViewAutoSizeColumnsMode.Fill`.
- **RowHeadersVisible**: Establecer `false` si no es necesario.

### 6. TabControl
- **Name**: `tcPrincipal`
- **Font**: `12pt`.
- **Size**: ajustar para llenar el contenedor.
- **TabPages**: nombrar cada página según su contenido (ej. `tDatosPersonales`, `tHistorial`).
- **Dock**: `DockStyle.Fill` para adaptarse al contenedor.

### 7. CheckBox
- **Name**: `chkOpcion` (ej. `chkRecibirNotificaciones`)
- **Font**: `12pt`.
- **Text**: descripción clara (ej. "Recibir notificaciones").
- **Size**: ajustar automáticamente según el texto.
- **Dock**: `DockStyle.Top` si es parte de un grupo.

### 8. RadioButton
- **Name**: `rbOpcion` (ej. `rbMasculino`, `rbFemenino`)
- **Font**: `12pt`.
- **Text**: descripción clara (ej. "Masculino").
- **Size**: ajustar automáticamente.
- **Dock**: `DockStyle.Top` para agrupar opciones.

### 9. PictureBox
- **Name**: `pbImagen` (ej. `pbLogo`)
- **SizeMode**: `PictureBoxSizeMode.StretchImage` para ajustar la imagen al control.
- **Size**: mínimo `100px` de ancho y alto.
- **Dock**: `DockStyle.Top` o `DockStyle.Left` según el diseño.

### 10. ProgressBar
- **Name**: `pbCarga` (ej. `pbCarga`)
- **Style**: `ProgressBarStyle.Blocks` o `ProgressBarStyle.Marquee` según el uso.
- **Size**: mínimo `200px` de ancho y `20px` de alto.
- **Dock**: `DockStyle.Bottom` para indicadores de carga.

## Accesibilidad
- **TabIndex**: orden lógico para la navegación con teclado.
- **ToolTip**: proporcionar descripciones para controles menos evidentes.
- **Contraste**: asegurar legibilidad entre texto y fondo.

## Notas Finales
Esta guía proporciona una referencia rápida para el diseño de la interfaz gráfica, asegurando que todos los desarrolladores sigan un conjunto coherente de principios y directrices.