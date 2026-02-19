# 🚀 Clase de Git: Domina el Flujo de Trabajo Básico

Bienvenido a esta guía práctica diseñada para ayudarte a entender y dominar los conceptos fundamentales de Git. Hoy aprenderemos a clonar repositorios, guardar nuestros cambios y compartirlos con el mundo.

## 📋 Contenido
1. [Clonar un Repositorio](#1-clonar-un-repositorio)
2. [Hacer Commit (Guardar Cambios)](#2-hacer-commit-guardar-cambios)
3. [Hacer Push (Subir al Servidor)](#3-hacer-push-subir-al-servidor)
4. [Resumen de Comandos](#4-resumen-de-comandos)

---

## 🏗️ 1. Clonar un Repositorio
Clonar es el proceso de crear una copia local exacta de un repositorio que se encuentra en un servidor remoto (como GitHub o GitLab).

### ¿Cómo se hace?
1. Busca la URL del repositorio (usualmente termina en `.git`).
2. Abre tu terminal y ejecuta:
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   ```
3. Entra en la carpeta creada:
   ```bash
   cd <NOMBRE_DE_LA_CARPETA>
   ```

---

## ✍️ 2. Hacer Commit (Guardar Cambios)
Un **commit** es como una "foto" o un punto de restauración de tu proyecto en un momento específico.

### Pasos para realizar un commit:

#### Paso A: Preparar los archivos (Staging)
Antes de guardar, debemos decirle a Git qué archivos queremos incluir en la foto.
```bash
git add <nombre_del_archivo>  # Para un archivo específico
git add .                     # Para incluir TODOS los cambios
```

#### Paso B: Crear el commit
Ahora guardamos los cambios con un mensaje descriptivo que explique qué hemos hecho.
```bash
git commit -m "feat: agrega nueva funcionalidad de login"
```
> **Tip:** Intenta que tus mensajes sean claros y concisos.

---

## 📤 3. Hacer Push (Subir al Servidor)
Una vez que tienes tus "fotos" (commits) guardadas localmente, necesitas enviarlas al servidor remoto para que otros puedan verlas o para tener un respaldo.

### ¿Cómo se hace?
```bash
git push origin <nombre_de_la_rama>
```
*   `origin`: Es el nombre corto del servidor remoto.
*   `<nombre_de_la_rama>`: Usualmente es `main` o `master`.

---

## 🌿 4. Trabajar con Ramas (Branches)
Las ramas nos permiten trabajar en diferentes funcionalidades o correcciones sin afectar el código principal.

### Crear una rama nueva:
```bash
git branch <nombre_de_la_rama>
```

### Crear y cambiarse a la rama inmediatamente:
```bash
git checkout -b <nombre_de_la_rama>
```

### Cambiar entre ramas existentes:
```bash
git checkout <nombre_de_la_rama>
# O usando el comando moderno:
git switch <nombre_de_la_rama>
```

---

## 🛠️ 5. Resumen de Comandos Útiles

| Comando | Descripción |
| :--- | :--- |
| `git status` | Muestra el estado actual de tus archivos (cuáles han cambiado). |
| `git log` | Muestra el historial de commits realizados. |
| `git pull` | Trae los cambios más recientes del servidor a tu computadora. |

---

¡Felicidades! Ahora ya conoces el flujo básico de trabajo con Git. 🌟
