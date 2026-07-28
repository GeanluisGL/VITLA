 # 🏛️ VITLA - Sistema de Gestión de Visitas ITLA

[![GitHub](https://img.shields.io/badge/Repositorio-GeanluisGL%2FVITLA-blue?logo=github)](https://github.com/GeanluisGL/VITLA)
[![Estado del Proyecto](https://img.shields.io/badge/Estado-Completado-brightgreen)]()
[![Lenguaje](https://img.shields.io/badge/Lenguaje-C%23-purple)]()

## 📝 Descripción del Proyecto

**VITLA** es un sistema de escritorio desarrollado en C# para la gestión y el registro de visitas en el **Instituto Tecnológico de las Américas (ITLA)**. Su objetivo principal es proporcionar una herramienta eficiente y profesional para controlar el flujo de visitantes en los diferentes edificios y aulas de la institución.

El sistema ofrece una solución integral que abarca desde la autenticación de usuarios hasta la generación de consultas y la administración de la configuración del sistema, todo ello construido sobre una **arquitectura multicapa** y utilizando **procedimientos almacenados** para garantizar la integridad y el rendimiento de los datos.

## 🎯 Características y Funcionalidades Principales

El sistema VITLA se compone de varios módulos interconectados para cubrir todas las necesidades de gestión de visitas:

### 1. 🔐 Autenticación y Control de Acceso (Login)

- **Formulario de Login**: Pantalla inicial para que los usuarios se autentiquen en el sistema.
- **Roles de Usuario**: Soporte para dos tipos de perfiles:
    - **Usuario Administrador**: Con permisos totales para la configuración y gestión del sistema.
    - **Usuario General**: Con permisos limitados al registro y consulta de visitas.

### 2. ✍️ Registro de Visitantes

Formulario principal para capturar la información detallada de cada visita:
- **Datos Personales**: Nombre, Apellido, Carrera (Opcional).
- **Información de Contacto**: Correo electrónico (con máscara de entrada para validación).
- **Detalles de la Visita**:
    - **Edificio**: Seleccionado desde un combo box que se carga automáticamente.
    - **Aula o Lugar**: Combo box que se actualiza de forma dinámica según el edificio seleccionado.
    - **Hora de Entrada y Salida**: Seleccionadas mediante un control de calendario.
    - **Motivo de la Visita**: Campo de texto para describir el propósito.
- **Multimedia**: Opción para adjuntar una foto del visitante.

### 3. 🔍 Consulta de Visitas

- **Pantalla de Búsqueda**: Permite filtrar y visualizar el historial de visitas registradas.
- **Filtro por Edificio**: Funcionalidad clave para consultar las visitas realizadas a un edificio específico.

### 4. ⚙️ Panel de Administración y Configuración

Módulo exclusivo para usuarios administradores que permite:
- **Gestión de Edificios y Aulas**: Añadir, modificar o eliminar edificios y las aulas asociadas a cada uno. Esta configuración se refleja automáticamente en los combo boxes del formulario de registro.
- **Gestión de Usuarios**: Crear nuevos usuarios del sistema, asignándoles un rol (Administrador o General). Los campos requeridos son:
    - Nombre, Apellido, Fecha de Nacimiento (Calendario).
    - Tipo de Usuario (Administrador/General).
    - **Usuario**: Puede ser autogenerado por el sistema para simplificar el proceso.

## 🏗️ Arquitectura del Proyecto

El proyecto sigue una **arquitectura multicapa (N-Tier)** para garantizar la separación de responsabilidades, el mantenimiento y la escalabilidad. La solución se organiza de la siguiente manera:

```text
VITLA/
├── VITLA/                 # Capa de Presentación (Presentation Layer)
│                           # Contiene los formularios (Windows Forms) y la interfaz de usuario.
├── ELayer/                # Capa de Entidades (Entities Layer)
│                           # Define las clases de los objetos del negocio (Visitante, Edificio, Usuario, etc.)
├── NLayer/                # Capa de Negocio (Business Logic Layer)
│                           # Contiene la lógica de negocio, validaciones y orquesta las operaciones.
├── DLayer/                # Capa de Datos (Data Access Layer)
│                           # Responsable de la comunicación con la base de datos y la ejecución de SPs.
├── packages/              # Paquetes NuGet utilizados en el proyecto.
├── Querry(A).sql          # Scripts de la base de datos (tablas, procedimientos almacenados).
├── Links.txt              # Enlaces de interés o referencias.
└── VITLA.sln              # Archivo de solución de Visual Studio.
```

### Descripción de Capas

#### `VITLA` (Capa de Presentación)
Es la interfaz de usuario. Aquí se encuentran todos los formularios (Windows Forms) que los usuarios finales utilizan para interactuar con el sistema (Login, Registro de Visitas, Consultas, Administración). Su única función es mostrar datos y capturar la entrada del usuario.

#### `ELayer` (Capa de Entidades)
Define las clases que representan los objetos del mundo real (como `Visitante`, `Edificio`, `Aula`, `Usuario`). Estas clases son simples (POCOs) y se utilizan para transportar datos a través de las diferentes capas.

#### `NLayer` (Capa de Negocio)
Actúa como el cerebro de la aplicación. Contiene toda la lógica de negocio, incluyendo las reglas de validación (ej. correo válido, campos obligatorios), la gestión de la seguridad y la coordinación entre la capa de presentación y la capa de datos. Se comunica con `DLayer` para obtener o guardar información.

#### `DLayer` (Capa de Datos)
Es la responsable del acceso y la persistencia de los datos. Su función principal es ejecutar los **procedimientos almacenados (Stored Procedures)** definidos en la base de datos para realizar las operaciones CRUD (Crear, Leer, Actualizar, Eliminar). Traduce los resultados de la base de datos en objetos de la capa de entidades.

## 🗄️ Base de Datos y Procedimientos Almacenados

El script `Querry(A).sql` contiene la definición completa de la base de datos. Siguiendo los requisitos del proyecto, se hace un uso intensivo de **procedimientos almacenados** para todas las operaciones principales:

- `SP_Login`: Para autenticar a los usuarios.
- `SP_RegistrarVisita`: Para insertar un nuevo registro de visita.
- `SP_ConsultarVisitas`: Para obtener el historial de visitas, posiblemente con filtros.
- `SP_GestionEdificios`: Para administrar (insertar, actualizar, eliminar) los edificios.
- `SP_GestionAulas`: Para administrar las aulas, vinculándolas a un edificio específico.
- `SP_GestionUsuarios`: Para crear y administrar los usuarios del sistema.

El uso de procedimientos almacenados mejora el rendimiento, la seguridad (al prevenir la inyección SQL) y centraliza la lógica de acceso a datos.

## 🚀 Tecnologías Utilizadas

- **Lenguaje de Programación:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Base de Datos:** SQL Server
- **Arquitectura:** Multicapa (N-Tier)
- **Acceso a Datos:** Procedimientos Almacenados (Stored Procedures)
- **Gestión de Paquetes:** NuGet

## ⚙️ Cómo Ejecutar el Proyecto

Para poner en marcha el sistema VITLA en tu entorno local, sigue estos pasos:

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/GeanluisGL/VITLA.git
    ```

2.  **Abrir la solución:** Abre el archivo `VITLA.sln` con Visual Studio (versión 2019 o superior recomendada).

3.  **Configurar la Base de Datos:**
    - Ejecuta el script `Querry(A).sql` en tu instancia de SQL Server. Esto creará la base de datos, las tablas y todos los procedimientos almacenados necesarios.
    - Actualiza la cadena de conexión en la capa de datos (`DLayer`) para que apunte a tu servidor SQL. Esta cadena suele encontrarse en un archivo de configuración (ej. `App.config`).

4.  **Restaurar paquetes NuGet:** Visual Studio debería restaurar automáticamente los paquetes necesarios. Si no, hazlo manualmente desde la consola del Administrador de paquetes.

5.  **Compilar y Ejecutar:** Compila la solución y ejecuta el proyecto de la capa de presentación (`VITLA`).

## 🎨 Enfoque Profesional

El proyecto pone énfasis en aplicar técnicas de visualización aprendidas en clase para lograr un **aspecto profesional**, lo que incluye:
- Uso de controles avanzados (combo boxes dinámicos, masked text boxes, calendarios).
- Interfaces de usuario limpias e intuitivas.
- Experiencia de usuario fluida y coherente en todos los módulos.

## 🤝 Contribuciones

Este es un proyecto de práctica académica que demuestra la aplicación de conceptos avanzados de desarrollo de software. Si tienes sugerencias para mejorarlo, no dudes en abrir un *issue* o enviar un *pull request*.

## 👤 Autor

**GeanluisGL** - [Perfil de GitHub](https://github.com/GeanluisGL)

---

⭐ Si este proyecto te parece útil o interesante, ¡no olvides darle una estrella en GitHub!
 
