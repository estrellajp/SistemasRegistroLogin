# Tabla de contenidos
- [Tabla de contenidos](#tabla-de-contenidos)
- [Introducción](#introducción)
  - [Funcionalidades](#funcionalidades)
  - [Ramas del Proyecto y Commits realizados](#ramas-del-proyecto-y-commits-realizados)
    - [Rama master](#rama-master)
    - [Rama master2](#rama-master2)
    - [Rama master3](#rama-master3)
  - [Contribución](#contribución)
  - [Requisitos](#requisitos)

# Introducción

Este proyecto es un sistema de login desarrollado en C# utilizando Visual Studio 2019 y controlado con Git en GitHub. El objetivo de este sistema es proporcionar autenticación segura para usuarios que acceden a un sistema de gestión hospitalaria.

## Funcionalidades

El sistema de login hospitalario cuenta con las siguientes funcionalidades:

- **Autenticación de Usuarios:** Los usuarios pueden iniciar sesión utilizando un nombre de usuario y contraseña válidos. Si se deja algún campo vacío o si la contraseña es incorrecta, se muestra un mensaje de error solicitando al usuario que vuelva a intentarlo.

- **Registro de Usuarios:** Si un usuario no está registrado, puede acceder a una opción para registrarse. Al hacer clic en esta opción, el usuario es redirigido al formulario de registro donde puede ingresar su nombre, correo electrónico y contraseña. El sistema verifica si las contraseñas coinciden antes de permitir el registro.

## Ramas del Proyecto y Commits realizados

Este proyecto está organizado en varias ramas en Git:

  ### **Rama master** 
Contiene el formulario de login (Form1) desarrollado por el colaborador Estrella.
  - Se realizan 7 Commits
  
  ### **Rama master2** 
Contiene el formulario de registro (Form2) desarrollado por el colaborador Mari Carmen.
  - Se realizan 4 Commits

  ### **Rama master3** 
Se fusionaron las ramas master y master2, integrando tanto el formulario de login como el de registro para crear la versión final del sistema.
  - Se realizan 14 Commits

## Contribución

Si deseas contribuir al proyecto, puedes seguir estos pasos:

1. Realiza un fork del repositorio.
2. Clona el repositorio a tu máquina local.
3. Crea una nueva rama para tus cambios: `git checkout -b nombre-de-tu-rama`
4. Realiza tus modificaciones y haz commit: `git commit -m "Descripción de tus cambios"`
5. Haz push a tu rama: `git push origin nombre-de-tu-rama`
6. Crea un Pull Request en GitHub explicando tus cambios y esperando su revisión.

## Requisitos

- Visual Studio (o cualquier IDE compatible con C#).
- Conexión a internet para acceder al repositorio en GitHub.
